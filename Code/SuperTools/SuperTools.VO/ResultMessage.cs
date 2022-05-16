using System.ComponentModel;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using SuperHelper.Extension;

namespace SuperTools.VO
{
    public class ResultMessage
    {
        public ResultMessage()
        {

        }

        /// <summary>
        /// 执行结果
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        public object Data { get; set; }

        public T GetData<T>()
        {
            var json =JsonConvert.SerializeObject(Data);
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// 正则
        /// </summary>
        private static readonly Regex Regex = new Regex(@"{\d}");

        /// <summary>
        /// 构建返回信息
        /// </summary>
        /// <param name="code">错误类型</param>
        /// <param name="errormsg">错误信息</param>
        /// <param name="data">返回数据</param>
        public ResultMessage(ResultEnum code, string errormsg = null, object data = null)
        {
            if (!string.IsNullOrEmpty(errormsg))
                errormsg = Regex.Replace(errormsg, "");

            Code = (int)code;
            Msg = errormsg;
            Data = data;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="code">错误类型</param>
        /// <param name="msg">信息</param>
        /// <param name="data">返回数据</param>
        public ResultMessage(int code, string msg, object data = null)
        {
            if (!string.IsNullOrEmpty(msg))
                msg = Regex.Replace(msg, "");

            Code = code;
            Msg = msg;
            Data = data;
        }

        /// <summary>
        /// 返回成功
        /// </summary>
        /// <returns>ResultMessage</returns>
        public static ResultMessage Ok()
        {
            return new ResultMessage(ResultEnum.Success, "成功");
        }

        /// <summary>
        /// 返回成功
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>ResultMessage</returns>
        public static ResultMessage Ok(object data)
        {
            return new ResultMessage(ResultEnum.Success, "成功", data);
        }
        /// <summary>
        /// 自定义返回码
        /// </summary>
        /// <param name="code">状态码</param>
        /// <param name="msg">消息</param>
        /// <param name="data">数据</param>
        /// <returns>ResultMessage</returns>
        public static ResultMessage Ok(int code, string msg, object data = null)
        {
            return new ResultMessage(code, msg, data);
        }

        /// <summary>
        /// 请求失败
        /// </summary>
        /// <param name="message">失败信息</param>
        /// <returns>ResultMessage</returns>
        public static ResultMessage Error(string message)
        {
            return new ResultMessage(ResultEnum.Error, message);
        }

        /// <summary>
        /// 请求失败
        /// </summary>
        /// <param name="message">失败信息</param>
        /// <param name="data">数据</param>
        /// <returns>ResultMessage</returns>
        public static ResultMessage Error(string message, object data)
        {
            return new ResultMessage(ResultEnum.Error, message, data);
        }

        /// <summary>
        /// 请求错误
        /// </summary>
        /// <param name="code">错误码</param>
        /// <param name="message">错误信息</param>
        /// <returns>ResultMessage</returns>
        public static ResultMessage Error(ResultEnum code = ResultEnum.Error, string message = null)
        {
            if (string.IsNullOrEmpty(message))
                message = code.GetEnumDescription();

            return new ResultMessage(code, message);
        }

        /// <summary>
        /// 异常错误
        /// </summary>
        /// <param name="code">错误码</param>
        /// <param name="args">信息</param>
        /// <returns>ResultMessage</returns>
        public static ResultMessage ErrorFormat(ResultEnum code, params object[] args)
        {
            if (args.Length == 0)
                return new ResultMessage(code, code.GetEnumDescription());

            var desc = code.GetEnumDescription();
            var msg = string.Format(desc, args);

            return new ResultMessage(code, msg);
        }

        /// <summary>
        /// 服务器内部错误
        /// </summary>
        /// <returns>ResultMessage</returns>
        public static ResultMessage Fail()
        {
            ResultEnum code = ResultEnum.Fail;
            var message = code.GetEnumDescription();
            return new ResultMessage(code, message);
        }

        /// <summary>
        /// 未授权
        /// </summary>
        /// <returns>ResultMessage</returns>
        public static ResultMessage InvalidAuth()
        {
            ResultEnum code = ResultEnum.InvalidAuth;
            var message = code.GetEnumDescription();
            return new ResultMessage(code, message);
        }

        /// <summary>
        /// 存在无效的请求参数
        /// </summary>
        /// <returns>ResultMessage</returns>
        public static ResultMessage InvalidParams()
        {
            ResultEnum code = ResultEnum.InvalidParams;
            var message = code.GetEnumDescription();
            return new ResultMessage(code, message);
        }

        /// <summary>
        /// 验签失败
        /// </summary>
        /// <returns>ResultMessage</returns>
        public static ResultMessage InvalidHttpMethod()
        {
            ResultEnum code = ResultEnum.InvalidHttpMethod;
            var message = code.GetEnumDescription();
            return new ResultMessage(code, message);
        }


    }

    public enum ResultEnum
    {
        /// <summary>
        /// 成功
        /// </summary>
        [Description("成功")]
        Success = 1,

        /// <summary>
        /// 失败
        /// </summary>
        [Description("请求失败：{0}")]
        Error = -1,

        /// <summary>
        /// 内部错误
        /// </summary>
        [Description("内部错误")]
        Fail = -500,

        /// <summary>
        /// 未授权
        /// </summary>
        [Description("未授权")]
        InvalidAuth = 401,

        /// <summary>
        /// 缺少必选参数
        /// </summary>
        [Description("缺少必选参数{0}")]
        LossRequiredParams = -2,

        /// <summary>
        /// 请求参数无效
        /// </summary>
        [Description("存在无效的请求参数")]
        InvalidParams = -3,

        /// <summary>
        /// 应用不存在
        /// </summary>
        [Description("应用不存在")]
        AppNotExists = -4,

        /// <summary>
        /// 应用不存在
        /// </summary>
        [Description("密码错误")]
        PasswordErr = -5,

        /// <summary>
        /// 验签失败
        /// </summary>
        [Description("签名验证失败")]
        InvalidSign = -10,

        /// <summary>
        /// 请求方式不支持
        /// </summary>
        [Description("不支持{0}请求方式")]
        InvalidHttpMethod = -11
    }
}
