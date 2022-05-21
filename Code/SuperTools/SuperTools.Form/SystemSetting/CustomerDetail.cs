using DevExpress.XtraEditors;
using SuperTools.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTools.Form.SystemSetting
{
    public partial class CustomerDetail : DialogForm
    {
        private long _id;
        public CustomerDetail()
        {
            InitializeComponent();
        }
        public CustomerDetail(long id)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(DialogResult.None);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataSourceSaveChange();
            var result = Post("/api/Customer/AddOrUpdateCustomer", DataSource);
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

        private void LoadDataSource()
        {
            DataSource = new CustomerVO();
            if (_id != 0)
            {
                var result = Get($"/api/Customer/GetCustomer?id={_id}");
                if (result.Code == 1)
                {
                    DataSource = result.GetData<CustomerVO>();
                }
            }
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            MyControls = layoutControl.Controls;
            LoadDataSource();
        }
    }
}