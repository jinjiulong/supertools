using SuperHelper.Extension;
using SuperHelper.Utils;
using SuperTools.Data;
using SuperTools.Data.Entity;
using SuperTools.Data.View;

namespace SupeTools.Service
{
    public class MenuService
    {
        private ToolsDbContext _db;

        public MenuService(ToolsDbContext db)
        {
            _db = db;
        }

        public bool Delete(long id, out string msg)
        {
            var menu = _db.Menus.FirstOrDefault(x => x.Id == id);
            if (menu == null)
            {
                msg = "未找到该菜单";
                return false;
            }
            var childrenMenuCount = _db.Menus.Count(x => x.ParentId == menu.Id);
            if (childrenMenuCount > 0)
            {
                msg = "该菜单尚有子菜单，请先删除子菜单";
                return false;
            }
            _db.Menus.Remove(menu);
            _db.SaveChanges();
            msg = "成功";
            return true;
        }

        public bool Edit(Menu menu, out string msg)
        {
            if (menu.Id == 0)
            {
                _db.Menus.Add(menu);
                _db.SaveChanges();
                msg = "成功";
                return true;
            }
            else
            {
                var oldmenu = _db.Menus.FirstOrDefault(x => x.Id == menu.Id);
                if (oldmenu == null)
                {
                    msg = "未找到该菜单信息";
                    return false;
                }
                oldmenu.ValueAssign(menu);
                _db.SaveChanges();
                msg = "成功";
                return true;
            }
        }

        public bool GetMenu(long id, out MenuVO? menu, out string msg)
        {
            menu = _db.MenuVOs.FirstOrDefault(x => x.Id == id);
            if (menu == null)
            {
                msg = "为找到该菜单";
                return false;
            }
            msg = "成功";
            return true;
        }

        public bool GetMenus(out List<MenuVO> menus, out string msg)
        {
            menus = _db.MenuVOs.Where(x => true).ToList();
            msg = "成功";
            return true;
        }
    }
}