using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SuperTools.Form.SmallTools
{
    public partial class GSCloudSql : TabForm
    {
        public GSCloudSql()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            var sqlParams = txtParams.Text;
            var originSql=txtOriginSql.Text;
            var flag= ReplaceSql(sqlParams,originSql,out var replaceSql,out var msg);
            if (flag)
            {
                txtReplacedSql.Text = replaceSql;
            }
            else
            {
                Error(msg);
            }

        }

        private bool ReplaceSql(string sqlParams, string originSql, out string replacedSql, out string msg)
        {
            var arrParams = new List<string>();
            try
            {
                arrParams = JsonConvert.DeserializeObject<List<string>>(sqlParams);
            }
            catch (Exception ex)
            {
                //TODO 记录日志
                msg = "参数格式不正确";
                replacedSql = String.Empty;
                return false;

            }
            foreach (var item in arrParams)
            {
                var index = originSql.IndexOf("?");
                originSql = originSql.Remove(index, 1).Insert(index, "'"+item+"'");
            }
            replacedSql = originSql;
            msg = "成功";
            return true;
        }
    }
}