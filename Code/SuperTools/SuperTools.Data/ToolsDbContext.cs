using Microsoft.EntityFrameworkCore;
using SuperTools.Data.Entity;
using SuperTools.Data.View;

namespace SuperTools.Data
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public class ToolsDbContext : DbContext
    {
        /// <summary>
        /// 菜单
        /// </summary>
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuVO> MenuVOs { get; set; }
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="options"></param>
        public ToolsDbContext(DbContextOptions<ToolsDbContext> options) : base(options)
        {

        }
    }
}
