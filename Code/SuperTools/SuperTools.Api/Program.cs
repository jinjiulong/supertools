using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SuperTools.Api;
using SuperTools.Data;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddBizService();
var connectionStr = builder.Configuration.GetConnectionString("MySQL");
builder.Services.AddDbContext<ToolsDbContext>(x => x.UseMySQL(connectionStr));
//ע��JWT�����֤����
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(x =>
{
    //ȡ��˽Կ
    var secretByte = Encoding.UTF8.GetBytes(builder.Configuration["Authentication:SecretKey"]);
    x.TokenValidationParameters = new TokenValidationParameters()
    {
        //��֤������
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration["Authentication:Issuer"],
        //��֤������
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Authentication:Audience"],
        //��֤�Ƿ����
        ValidateLifetime = true,
        //��֤˽Կ
        IssuerSigningKey = new SymmetricSecurityKey(secretByte)
    };
});
//var section = builder.Configuration.GetSection("Redis:Default");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//���JWT��֤
//��֤
app.UseAuthentication();
//��Ȩ
app.UseAuthorization();

app.MapControllers();
app.Run();
