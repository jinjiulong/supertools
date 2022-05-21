using SuperTools.VO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SuperTools.Form.DialogForm;

namespace SuperTools.Form.SystemSetting
{
    public partial class CustomerList : TabForm
    {
        public CustomerList()
        {
            InitializeComponent();
        }
        private void Init()
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            var result = Get("/api/Customer/GetCustomers");
            if (result.Code == 1)
            {
                var data = result.GetData<List<CustomerVO>>();
                gridControl.DataSource = null;
                gridControl.DataSource = data;
            }
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var customerDetail = new CustomerDetail();
            customerDetail.State = EditState.Edit;
            var result = customerDetail.ShowDialog();
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
            var row = (CustomerVO)currentRow;
            var customerDetail = new CustomerDetail(row.Id);
            customerDetail.State = EditState.Edit;
            var result = customerDetail.ShowDialog();
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
            var row = (CustomerVO)currentRow;
            var customerDetail = new CustomerDetail(row.Id);
            customerDetail.State = EditState.View;
            customerDetail.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var currentRow = gridView.GetFocusedRow();
            if (currentRow == null)
            {
                Warring("请选择需要删除的数据");
                return;
            }
            var row = (CustomerVO)currentRow;
            var id = row.Id;
            var result = Post($"/api/Customer/DeleteCustomer?id={id}");
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