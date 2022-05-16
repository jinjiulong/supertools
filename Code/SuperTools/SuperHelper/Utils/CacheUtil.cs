using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Caching.Memory;

namespace SuperHelper.Utils
{
    public class CacheUtil
    {
        private static MemoryCache cache = new MemoryCache(new MemoryCacheOptions());

        #region 获取缓存值
        /// <summary>
        /// 获取缓存值
        /// </summary>
        /// <param name="key">缓存的键</param>
        /// <returns>返回缓存的值</returns>
        public static object GetCacheValue(string key)
        {
            object val = null;
            if (key != null && cache.TryGetValue(key, out val))
            {
                return val;
            }
            else
            {
                return default(object);
            }
        }
        #endregion

        #region 设置缓存值
        /// <summary>
        /// 设置缓存值
        /// </summary>
        /// <param name="key">缓存的键</param>
        /// <param name="value">缓存值</param>
        public static void SetChacheValue(string key, object value)
        {
            if (key != null)
            {
                cache.Set(key, value, new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromHours(1)
                });
            }
        }
        #endregion

        public static void DeleteChacheValue(string key)
        {
            if (key!=null)
            {
                cache.Remove(key);
            }
        }
    }
}
