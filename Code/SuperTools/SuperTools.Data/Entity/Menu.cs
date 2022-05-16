using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTools.Data.Entity
{
    /// <summary>
    /// 菜单
    /// </summary>
    [Table("t_menu")]
    public class Menu
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        [Key]
        [Column("id")]
        public long Id { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [Column("name")]
        public string Name { get; set; } = "";

        /// <summary>
        /// 菜单编号
        /// </summary>
        [Column("code")]
        public string Code { get; set; } = "";

        /// <summary>
        /// 菜单父Id
        /// </summary>
        [Column("parentid")]
        public long ParentId { get; set; }

        /// <summary>
        /// 菜单排序，0、1、2、3……
        /// </summary>
        [Column("order")]
        public long Order { get; set; }

        /// <summary>
        /// 菜单所属程序集
        /// </summary>
        [Column("assembly")]
        public string? Assembly { get; set; } = "";

        /// <summary>
        /// 菜单的命名空间
        /// </summary>
        [Column("namespace")]
        public string? Namespace { get; set; } = "";

        /// <summary>
        /// 菜单的类名
        /// </summary>
        [Column("class")]
        public string? Class { get; set; } = "";
    }
}
