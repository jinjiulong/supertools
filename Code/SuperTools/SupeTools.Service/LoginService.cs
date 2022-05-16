using SuperHelper.Utils;
using SuperTools.Data;
using SuperTools.Data.Entity;

namespace SupeTools.Service
{
    public class LoginService
    {
        private ToolsDbContext _db;
        public LoginService(ToolsDbContext db)
        {
            _db = db;
        }

        /// <summary>
        ///登录
        /// </summary>
        /// <param name="userCode">用户编号</param>
        /// <param name="password">密码（明文）</param>
        /// <param name="user">用户信息</param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool Login(string userCode, string password, out User? user, out string msg)
        {
            password = CryptographyUtil.MD5Encrypt(password);
            user = _db.Users.FirstOrDefault(x => x.Code == userCode && x.Password == password);
            if (user == null)
            {
                msg = "用户名或密码错误";
                return false;
            }
            else
            {
                msg = "成功";
                return true;
            }
        }

    }
}
