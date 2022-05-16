using DevExpress.XtraEditors;
using SuperTools.VO;
using System.Collections.Generic;
using static SuperTools.Form.DialogForm;

namespace SuperTools.Form.SystemSetting
{
    public partial class MenuList : TabForm
    {
        /// <summary>
        /// 菜单列表
        /// </summary>
        public MenuList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            var result = Get("/api/Menu/GetMenus");
            if (result.Code == 1)
            {
                var data = result.GetData<List<MenuVO>>();
                treeList.DataSource = null;
                treeList.DataSource = data;
                treeList.ExpandAll();
            }
            else
            {
                var msg = result.Msg;
                Error(msg);
                return;
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var menuDetail = new MenuDetail();
            menuDetail.State = EditState.Edit;
            var result = menuDetail.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                LoadDataSource();
            }
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var currentRow = treeList.GetFocusedRow();
            if (currentRow == null)
            {
                Warring("请选择需要查看的数据");
                return;
            }
            var row = (MenuVO)currentRow;
            var menuDetail = new MenuDetail(row.Id);
            menuDetail.State = EditState.Edit;
            var result = menuDetail.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                LoadDataSource();
            }
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuList_Load(object sender, System.EventArgs e)
        {
            Init();
        }

        /// <summary>
        /// 查看按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var currentRow = treeList.GetFocusedRow();
            if (currentRow == null)
            {
                Warring("请选择需要查看的数据");
                return;
            }
            var row = (MenuVO)currentRow;
            var menuDetail = new MenuDetail(row.Id);
            menuDetail.State = EditState.View;
            menuDetail.ShowDialog();
        }

        /// <summary>
        /// 删除按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var currentRow = treeList.GetFocusedRow();
            if (currentRow == null)
            {
                Warring("请选择需要删除的数据");
                return;
            }
            var row = (MenuVO)currentRow;
            var id = row.Id;
            var result = Post($"/api/Menu/DeleteMenu?id={id}");
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