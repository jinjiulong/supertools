using System.Collections.Generic;

namespace SuperTools.VO
{
    /// <summary>
    /// 导航的视图对象
    /// </summary>
    public class NavVO
    {
        /// <summary>
        /// 菜单的唯一标识
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 导航标题
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 导航编号
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// 程序集
        /// </summary>
        public string Assembly { get; set; } = string.Empty;

        /// <summary>
        /// 命名空间
        /// </summary>
        public string Namespace { get; set; } = string.Empty;

        /// <summary>
        /// 类名称
        /// </summary>
        public string Class { get; set; } = string.Empty;

        /// <summary>
        /// 排序
        /// </summary>
        public long Order { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public long ParentId { get; set; }

        /// <summary>
        /// 子菜单
        /// </summary>
        public List<NavVO> ChildNavs { get; set; } = new List<NavVO>();
    }
}
