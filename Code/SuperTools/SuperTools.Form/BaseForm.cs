using DevExpress.XtraEditors;
using SuperTools.VO;
using SuperHelper.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace SuperTools.Form
{
    /// <summary>
    /// 基础窗体
    /// </summary>
    public partial class BaseForm : XtraForm
    {
        /// <summary>
        /// apiHost地址
        /// </summary>
        private string _url = ConfigurationManager.AppSettings["apiUrl"];

        public BaseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发送post请求
        /// </summary>
        /// <param name="url">请求路径</param>
        /// <param name="obj">post数据，可以是一个匿名类</param>
        /// <returns></returns>
        public ResultMessage Post(string url, object obj = null, ContentType contentType = ContentType.Json, System.Text.Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = System.Text.Encoding.UTF8;
            }
            var httpItem = new HttpItem();
            httpItem.Url = $"{_url}{url}";
            var ct = "application/json";
            switch (contentType)
            {
                case ContentType.Json:
                    ct = "application/json";
                    break;
                case ContentType.Form:
                    ct = "application/x-www-form-urlencoded";
                    break;
                default:
                    break;
            }
            httpItem.Header.Add(System.Net.HttpRequestHeader.Authorization, $"bearer {LocalStorage.Token}");
            httpItem.ContentType = ct;
            httpItem.Method = "POST";
            httpItem.PostEncoding = encoding;
            if (obj != null)
            {
                httpItem.Postdata = JsonConvert.SerializeObject(obj);
            }
            var httpUtils = new HttpUtils();
            var result = httpUtils.GetHtml(httpItem);
            if (result.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                XtraMessageBox.Show("登录超时，请重新登录！");
                System.Environment.Exit(0);
                return null;
            }
            return JsonConvert.DeserializeObject<ResultMessage>(result.Html);
        }

        /// <summary>
        /// 发送get请求
        /// </summary>
        /// <param name="url">请求路径</param>
        /// <param name="obj">请求参数，可以是一个匿名类</param>
        /// <returns></returns>
        public ResultMessage Get(string url, object obj = null)
        {
            var httpItem = new HttpItem();
            var param = new List<string>();
            httpItem.Method = "GET";
            httpItem.Header.Add(System.Net.HttpRequestHeader.Authorization, $"bearer {LocalStorage.Token}");
            if (obj != null)
            {
                var properties = obj.GetType().GetProperties();
                foreach (var property in properties)
                {
                    var value = property.GetValue(obj, null);
                    param.Add($"{property.Name}={value}");
                }
            }
            if (param.Count > 0)
            {
                httpItem.Url = $"{_url}{url}?{string.Join("&", param)}";
            }
            else
            {
                httpItem.Url = $"{_url}{url}";
            }

            var httpUtils = new HttpUtils();
            var result = httpUtils.GetHtml(httpItem);
            if (result.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                XtraMessageBox.Show("登录超时，请重新登录！");
                System.Environment.Exit(0);
                return null;
            }
            return JsonConvert.DeserializeObject<ResultMessage>(result.Html);
        }

        /// <summary>
        /// 错误提示框
        /// </summary>
        /// <param name="err"></param>
        public void Error(string err = "失败")
        {
            XtraMessageBox.Show(err, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Warring(string err = "警告")
        {
            XtraMessageBox.Show(err, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 成功
        /// </summary>
        /// <param name="msg"></param>
        public void Success(string msg = "成功")
        {
            XtraMessageBox.Show(msg, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}