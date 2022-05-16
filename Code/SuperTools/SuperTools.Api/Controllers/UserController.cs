using Microsoft.AspNetCore.Mvc;
using SuperTools.Data.Entity;
using SuperTools.VO;
using SupeTools.Service;

namespace SuperTools.Api.Controllers
{
    public class UserController : BaseController
    {
        private UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public JsonResult AddOrUpdateUser(User user)
        {
            var flag = _userService.AddOrUpdateUser(user, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok());
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

        [HttpPost]
        public JsonResult DeleteUser(long id)
        {
            var flag = _userService.Delete(id, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok());
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

        [HttpGet]
        public JsonResult GetUser(long id)
        {
            var flag = _userService.GetUser(id, out var user, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok(user));
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

        [HttpGet]
        public JsonResult GetUsers()
        {
            var flag = _userService.GetUsers(out var users, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok(users));
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }
    }
}
