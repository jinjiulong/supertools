using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTools.Form
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userCode = txtUserCode.Text;
            var password = txtPassword.Text;
            var result = Post($"/api/OAuth/GetToken?code={userCode}&password={password}");
            if (result.Code != 1)
            {
                XtraMessageBox.Show(result.Msg);
                return;
            }
            else
            {
                var token = result.Data?.ToString();
                //将token写入缓存
                LocalStorage.Token = token;
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}