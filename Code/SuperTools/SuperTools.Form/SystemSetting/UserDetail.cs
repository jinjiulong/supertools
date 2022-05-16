using DevExpress.XtraEditors;
using SuperTools.VO;
using System;
using System.Windows.Forms;

namespace SuperTools.Form.SystemSetting
{
    public partial class UserDetail : DialogForm
    {
        private long _id;

        public UserDetail()
        {
            InitializeComponent();
        }
        public UserDetail(long id)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataSourceSaveChange();
            var result = Post("/api/User/AddOrUpdateUser", DataSource);
            if (result.Code == 1)
            {
                Success("保存成功");
                Close(DialogResult.OK);
            }
            else
            {
                var msg = result.Msg;
                XtraMessageBox.Show(msg);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(DialogResult.None);
        }

        private void UserDetail_Load(object sender, EventArgs e)
        {
            MyControls = layoutControl.Controls;
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            DataSource = new UserVO();
            if (_id != 0)
            {
                var result = Get($"/api/User/GetUser?id={_id}");
                if (result.Code == 1)
                {
                    DataSource = result.GetData<UserVO>();
                }
            }
        }
    }
}