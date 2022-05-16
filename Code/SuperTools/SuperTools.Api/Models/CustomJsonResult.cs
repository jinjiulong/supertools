using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SuperTools.Api.Models
{
    /// <summary>
    /// Json数据处理
    /// </summary>
    public class CustomJsonResult : JsonResult
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="value"></param>
        public CustomJsonResult(object? value) : base(value)
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="value"></param>
        /// <param name="serializerSettings"></param>
        public CustomJsonResult(object? value, object? serializerSettings) : base(value, serializerSettings)
        {
        }

        /// <summary>
        /// 重写执行后异步返回方法
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public override Task ExecuteResultAsync(ActionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            var response = context.HttpContext.Response;
            response.ContentType = !string.IsNullOrEmpty(ContentType) ? ContentType : "application/json";
            var jsonSerizlizerSetting = new JsonSerializerSettings();
            //设置取消循环引用
            jsonSerizlizerSetting.MissingMemberHandling = MissingMemberHandling.Ignore;
            //设置日期的格式为：yyyy-MM-dd
            jsonSerizlizerSetting.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            var json = JsonConvert.SerializeObject(Value, Formatting.None, jsonSerizlizerSetting);
            return response.WriteAsync(json);
        }
    }
}
