using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuperTools.Api.Models;

namespace SuperTools.Api.Controllers
{
    /// <summary>
    /// 基础控制器
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BaseController : Controller
    {
        /// <summary>
        /// 重写Json方法
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public override JsonResult Json(object? data)
        {
            return new CustomJsonResult(data);
        }

        /// <summary>
        /// 重写Json方法
        /// </summary>
        /// <param name="data"></param>
        /// <param name="serializerSettings"></param>
        /// <returns></returns>
        public override JsonResult Json(object? data, object? serializerSettings)
        {
            return new CustomJsonResult(data, serializerSettings);
        }
    }
}
