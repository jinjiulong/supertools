using Microsoft.AspNetCore.Mvc;
using SuperTools.Data.Entity;
using SuperTools.VO;
using SupeTools.Service;
using System.IdentityModel.Tokens.Jwt;

namespace SuperTools.Api.Controllers
{
    /// <summary>
    /// 菜单
    /// </summary>
    public class MenuController : BaseController
    {
        /// <summary>
        /// 菜单服务
        /// </summary>
        private MenuService _menuService;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="menuService"></param>
        public MenuController(MenuService menuService)
        {
            _menuService = menuService;
        }

        /// <summary>
        /// 添加或更新菜单
        /// </summary>
        /// <param name="menu">菜单信息</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult AddOrUpdateMenu(Menu menu)
        {
            var flag = _menuService.Edit(menu, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok());
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

        /// <summary>
        /// 菜单删除
        /// </summary>
        /// <param name="id">菜单id</param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult DeleteMenu(long id)
        {
            var flag = _menuService.Delete(id, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok());
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

        /// <summary>
        /// 获取菜单信息
        /// </summary>
        /// <param name="id">菜单唯一标识</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetMenu(long id)
        {
            var flag = _menuService.GetMenu(id, out var menu, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok(menu));
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetMenus()
        {
            var flag = _menuService.GetMenus(out var menus, out var msg);
            if (flag)
            {
                return Json(ResultMessage.Ok(menus));
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

        /// <summary>
        /// 获取导航信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetNav()
        {
            var navs = new List<NavVO>();
            var flag = _menuService.GetMenus(out var menus, out string msg);
            if (flag)
            {
                foreach (var item in menus.Where(x => x.ParentId == 0))
                {
                    var nav = new NavVO
                    {
                        Id = item.Id,
                        Title = item.Name,
                        Code = item.Code,
                        Order = item.Order,
                        ParentId = item.ParentId
                    };
                    navs.Add(nav);
                }
                foreach (var item in navs)
                {
                    var childMenus = menus.Where(x => x.ParentId == item.Id);
                    foreach (var childMenu in childMenus)
                    {
                        var nav = new NavVO
                        {
                            Id = childMenu.Id,
                            Title = childMenu.Name,
                            Code = childMenu.Code,
                            Order = childMenu.Order,
                            ParentId = childMenu.ParentId,
                            Assembly = childMenu.Assembly,
                            Namespace = childMenu.Namespace,
                            Class = childMenu.Class
                        };
                        item.ChildNavs.Add(nav);
                    }
                }
                return Json(ResultMessage.Ok(navs));
            }
            else
            {
                return Json(ResultMessage.Error(msg));
            }
        }

    }
}
