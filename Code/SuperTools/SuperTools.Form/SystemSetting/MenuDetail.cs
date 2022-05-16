using DevExpress.XtraEditors;
using SuperTools.Form.HelperForm;
using SuperTools.VO;

namespace SuperTools.Form.SystemSetting
{
    public partial class MenuDetail : DialogForm
    {
        private long _id;

        public MenuDetail()
        {
            InitializeComponent();
        }

        public MenuDetail(long id)
        {
            InitializeComponent();
            _id = id;
        }

        private void MenuDetail_Load(object sender, System.EventArgs e)
        {
            MyControls = layoutControl.Controls;
            LoadDataSource();
        }

        /// <summary>
        /// 获取菜单详情
        /// </summary>
        /// <returns></returns>
        private void LoadDataSource()
        {
            DataSource = new MenuVO();
            if (_id != 0)
            {
                var result = Get("/api/Menu/GetMenu", new { id = _id });
                if (result.Code == 1)
                {
                    DataSource = result.GetData<MenuVO>();
                }
            }
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, System.EventArgs e)
        {
            DataSourceSaveChange();
            var result = Post("/api/Menu/AddOrUpdateMenu", DataSource);
            if (result.Code == 1)
            {
                Success("保存成功");
                Close(System.Windows.Forms.DialogResult.OK);
            }
            else
            {
                var msg = result.Msg;
                XtraMessageBox.Show(msg);
            }
        }

        /// <summary>
        /// 父菜单帮助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btePareint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var menuHelper = new MenuHelper(btePareint);
            menuHelper.ShowDialog();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close(System.Windows.Forms.DialogResult.None);
        }
    }
}