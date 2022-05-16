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
using static SuperTools.Form.DialogForm;

namespace SuperTools.Form.SystemSetting
{
    public partial class UserList : TabForm
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void Init()
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            var result = Get("/api/User/GetUsers");
            if (result.Code == 1)
            {
                var data = result.GetData<List<UserVO>>();
                gridControl.DataSource = null;
                gridControl.DataSource = data;
            }
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var userDetail = new UserDetail();
            userDetail.State = EditState.Edit;
            var result = userDetail.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDataSource();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var currentRow = gridView.GetFocusedRow();
            if (currentRow == null)
            {
                Warring("请选择需要查看的数据");
                return;
            }
            var row = (UserVO)currentRow;
            var userDetail = new UserDetail(row.Id);
            userDetail.State = EditState.Edit;
            var result = userDetail.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDataSource();
            }
        }

        private void btnView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var currentRow = gridView.GetFocusedRow();
            if (currentRow == null)
            {
                Warring("请选择需要查看的数据");
                return;
            }
            var row = (UserVO)currentRow;
            var userDetail = new UserDetail(row.Id);
            userDetail.State = EditState.View;
            userDetail.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var currentRow = gridView.GetFocusedRow();
            if (currentRow == null)
            {
                Warring("请选择需要删除的数据");
                return;
            }
            var row = (UserVO)currentRow;
            var id = row.Id;
            var result = Post($"/api/User/DeleteUser?id={id}");
            if (result.Code == 1)
            {
                Success("删除成功");
                LoadDataSource();
                return;
            }
            else
            {
                Error(result.Msg);
                return;
            }
        }
    }
}