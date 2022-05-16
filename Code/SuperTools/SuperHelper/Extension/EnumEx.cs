using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SuperHelper.Extension
{
    public static class EunmEx
    {
        /// <summary>
        /// 获取枚举的描述
        /// </summary>
        /// <param name="enumSubitem">枚举</param>
        /// <returns>枚举描述</returns>
        public static string GetEnumDescription(this Enum enumSubitem)
        {
            var strValue = enumSubitem.ToString();
            var fieldinfo = enumSubitem.GetType().GetField(strValue);
            var objs = fieldinfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (objs.Length == 0)
            {
                return strValue;
            }
            var da = (DescriptionAttribute)objs[0];
            return da.Description;
        }
    }
}
