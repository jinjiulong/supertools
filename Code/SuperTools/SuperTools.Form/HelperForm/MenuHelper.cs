using DevExpress.XtraGrid.Columns;
using DevExtControls;
using SuperTools.VO;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SuperTools.Form.HelperForm
{
    public partial class MenuHelper : BaseForm
    {
        private ExtButtonEdit _bte;
        public MenuHelper(ExtButtonEdit bte)
        {
            InitializeComponent();
            _bte = bte;
        }

        public object DataSource { get; set; }

        /// <summary>
        /// 绑定值
        /// </summary>
        public string ValueName { get; set; }

        /// <summary>
        /// 展示值
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 列表列信息
        /// </summary>
        public List<Column> Columns { get; set; }

        /// <summary>
        /// 获取父菜单
        /// </summary>
        /// <returns></returns>
        private List<MenuVO> GetParentMenus()
        {
            var result = Get("/api/Menu/GetMenus");
            if (result.Code == 1)
            {
                var menus = result.GetData<List<MenuVO>>();
                var parentMenus = menus.Where(x => x.ParentId == 0).ToList();
                return parentMenus;
            }
            return null;
        }

        /// <summary>
        /// 确定按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, System.EventArgs e)
        {
            var currentRow = gridView.GetFocusedRow();
            foreach (var property in currentRow.GetType().GetProperties())
            {
                if (property.Name == DisplayName)
                {
                    DisplayName = property.GetValue(currentRow, null)?.ToString();
                }
                if (property.Name == ValueName)
                {
                    ValueName = property.GetValue(currentRow, null)?.ToString();
                }
            }
            _bte.Tag = ValueName;
            _bte.EditValue = DisplayName;
            Close();
        }

        /// <summary>
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuHelper_Load(object sender, System.EventArgs e)
        {
            DataSource = GetParentMenus();
            gridControl.DataSource = DataSource;
            DisplayName = "Name";
            ValueName = "Id";
        }

        /// <summary>
        /// 列表初始化
        /// </summary>
        private void GridInit()
        {
            foreach (var column in Columns)
            {
                var gridColumn = new GridColumn { Name = $"gridColunm_{column.FileName}", Caption = column.Caption, FieldName = column.FileName };
                gridView.Columns.Add(gridColumn);
            }
        }

        /// <summary>
        /// 添加列表列
        /// </summary>
        private void AddColunm()
        {
            Columns = new List<Column>
            {
                new Column{ Caption ="编号",FileName="Code"},
                new Column{ Caption ="名称",FileName="Name"}
            };
        }
    }

    public class Column
    {
        public string FileName { get; set; }
        public string Caption { get; set; }
    }

}