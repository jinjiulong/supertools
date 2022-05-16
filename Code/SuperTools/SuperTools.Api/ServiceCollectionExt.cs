using Microsoft.EntityFrameworkCore;
using SuperTools.Data;
using SupeTools.Service;

namespace SuperTools.Api
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection AddBizService(this IServiceCollection services)
        {
            //注入数据库上下文
            services.AddScoped<DbContext, ToolsDbContext>();
            //注入菜单模块服务
            services.AddScoped<MenuService, MenuService>();
            //注入用户模块服务
            services.AddScoped<UserService, UserService>();
            //注入登录模块服务
            services.AddScoped<LoginService, LoginService>();            
            return services;
        }

        //public static IServiceCollection AddRedis(this IServiceCollection services)
        //{
        //    //redis缓存
        //    var section = Configuration.GetSection("Redis:Default");
        //    //连接字符串
        //    string _connectionString = section.GetSection("Connection").Value;
        //    //实例名称
        //    string _instanceName = section.GetSection("InstanceName").Value;
        //    //默认数据库 
        //    int _defaultDB = int.Parse(section.GetSection("DefaultDB").Value ?? "0");
        //    //密码
        //    string _password = section.GetSection("Password").Value;
        //    //注入容器
        //    services.AddSingleton(new RedisHelper(_connectionString, _instanceName, _password, _defaultDB));
        //}
    }
}
