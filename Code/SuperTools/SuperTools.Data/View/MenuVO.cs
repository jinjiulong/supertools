using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTools.Data.View
{
    [Table("v_menu")]
    public class MenuVO
    {
        /// <summary>
        /// 菜单的唯一标识
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
        /// 菜单描述
        /// </summary>
        public string Des
        {
            get
            {
                if (ParentId == 0)
                {
                    return "无";
                }
                else
                {
                    return $"程序集:{Assembly}，类全限定名：{Namespace}.{Class}";
                }
            }
        }

        /// <summary>
        /// 菜单父ID
        /// </summary>
        [Column("parentid")]
        public long ParentId { get; set; }

        /// <summary>
        /// 父菜单名称
        /// </summary>
        [Column("parentname")]
        public string? ParentName { get; set; } = "";

        /// <summary>
        /// 排序
        /// </summary>
        [Column("order")]
        public long Order { get; set; }

        /// <summary>
        /// 程序集名称
        /// </summary>
        [Column("assembly")]
        public string? Assembly { get; set; } = "";

        /// <summary>
        /// 命名空间
        /// </summary>
        [Column("namespace")]
        public string? Namespace { get; set; } = "";

        /// <summary>
        /// 类名称
        /// </summary>
        [Column("class")]
        public string? Class { get; set; } = "";
    }
}
