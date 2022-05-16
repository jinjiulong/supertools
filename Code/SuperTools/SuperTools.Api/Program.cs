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
//注入JWT身份认证服务
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(x =>
{
    //取出私钥
    var secretByte = Encoding.UTF8.GetBytes(builder.Configuration["Authentication:SecretKey"]);
    x.TokenValidationParameters = new TokenValidationParameters()
    {
        //验证发布者
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration["Authentication:Issuer"],
        //验证接收者
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Authentication:Audience"],
        //验证是否过期
        ValidateLifetime = true,
        //验证私钥
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

//添加JWT认证
//认证
app.UseAuthentication();
//授权
app.UseAuthorization();

app.MapControllers();
app.Run();
