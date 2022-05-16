using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHelper.Extension
{
    public static class ObjectEx
    {
        public static void ValueAssign<T>(this T sourceObj, T newObj)
        {
            var type = typeof(T);
            foreach (var property in type.GetProperties())
            {
                property.SetValue(sourceObj, property.GetValue(newObj));
            }
        }
    }
}
