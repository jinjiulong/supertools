using SuperTools.Data;
using SuperTools.Data.Entity;
using SuperHelper.Extension;
using SuperHelper.Utils;

namespace SupeTools.Service
{
    public class UserService
    {
        private ToolsDbContext _db;
        public UserService(ToolsDbContext db)
        {
            _db = db;
        }

        public bool AddOrUpdateUser(User user, out string msg)
        {
            if (user.Id == 0)
            {
                //校验用户编号是否重复
                var info = _db.Users.FirstOrDefault(x => x.Code == user.Code);
                if (info != null)
                {
                    msg = "该用户编号已存在";
                    return false;
                }
                user.Password = CryptographyUtil.MD5Encrypt("aaaaaa");
                _db.Users.Add(user);
                _db.SaveChanges();
                msg = "成功";
                return true;
            }
            else
            {
                var id = user.Id;
                var oldUser = _db.Users.FirstOrDefault(x => x.Id == user.Id);
                if (oldUser == null)
                {
                    msg = "未找到该用户";
                    return false;
                }
                oldUser.ValueAssign(user);
                _db.SaveChanges();
                msg = "成功";
                return true;
            }
        }

        public bool GetUser(long id, out User? user, out string msg)
        {
            user = _db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                msg = "未找到该用户信息";
                return false;
            }
            else
            {
                msg = "成功";
                return true;
            }
        }

        public bool GetUsers(out List<User> users, out string msg)
        {
            users = _db.Users.ToList();
            msg = "成功";
            return true;
        }

        public bool Delete(long id, out string msg)
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                msg = "未找到该用户信息";
                return false;
            }
            else
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
                msg = "成功";
                return true;
            }
        }
    }
}
