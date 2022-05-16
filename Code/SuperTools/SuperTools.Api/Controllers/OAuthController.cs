using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SuperTools.VO;
using SupeTools.Service;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SuperTools.Api.Controllers
{
    [AllowAnonymous]
    public class OAuthController : BaseController
    {
        private LoginService _loginService;

        private readonly IConfiguration _configuration;
        public OAuthController(IConfiguration configuration, LoginService loginService)
        {
            _configuration = configuration;
            _loginService = loginService;
        }

        [HttpPost]
        public JsonResult GetToken(string code, string password)
        {
            //验证用户名密码：
            var flag = _loginService.Login(code, password, out var user, out var msg);
            if (!flag)
            {
                return Json(ResultMessage.Error(msg));
            }
            //生成JWT
            //Header，选择签名算法
            var securityAlgorithm = SecurityAlgorithms.HmacSha256;
            //存放用户信息，目前存放的是用户编号userCode
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Code),
                new Claim(JwtRegisteredClaimNames.Name,user.Name),
                new Claim(JwtRegisteredClaimNames.NameId,user.Id.ToString()),
                new Claim(ClaimTypes.Role,"admin")
            };
            //取出私钥，并以utf8编码字节输出
            var secretByte = Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]);
            //使用非对称算法对私钥进行加密
            var signingKey = new SymmetricSecurityKey(secretByte);
            //使用HamcSha256来验证加密后的私钥生成数字签名
            var signingCredentials = new SigningCredentials(signingKey, securityAlgorithm);
            //生成token
            var token = new JwtSecurityToken(
                issuer: _configuration["Authentication:Issuer"],//发布者
                audience: _configuration["Authentication:Audience"],//接收者
                claims: claims, //存放的用户信息
                notBefore: DateTime.UtcNow,//发布时间
                expires: DateTime.UtcNow.AddDays(1),//有效期 设置为1天
                signingCredentials: signingCredentials//数字签名
                );
            //生成字符串token
            var tokenStr = new JwtSecurityTokenHandler().WriteToken(token);
            return Json(ResultMessage.Ok(tokenStr));

        }
    }
}
