using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTools.VO
{

    public class MenuVO
    {
        /// <summary>
        /// 菜单的唯一标识
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// 菜单编号
        /// </summary>
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
        public long ParentId { get; set; }

        /// <summary>
        /// 父菜单名称
        /// </summary>
        public string ParentName { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public long Order { get; set; }

        /// <summary>
        /// 程序集名称
        /// </summary>
        public string Assembly { get; set; } = "";

        /// <summary>
        /// 命名空间
        /// </summary>
        public string Namespace { get; set; } = "";

        /// <summary>
        /// 类名称
        /// </summary>
        public string Class { get; set; } = "";
    }
}
