using DevExpress.XtraEditors;
using DevExtControls;
using System;
using System.Windows.Forms;

namespace SuperTools.Form
{
    /// <summary>
    /// 对话框窗体
    /// </summary>
    public partial class DialogForm : BaseForm
    {
        public DialogForm()
        {
            InitializeComponent();
        }
        public Control.ControlCollection MyControls { get; set; }
        public object DataSource { get; set; }
        public EditState State { get; set; }

        /// <summary>
        /// 编辑状态枚举值
        /// </summary>
        public enum EditState
        {
            View,
            Edit
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            DataSourceControlsMapping();
            ControlStateInit();
        }

        /// <summary>
        /// 数据初始化，用户初始化控件的数据
        /// </summary>
        /// <param name="controls">控件集合</param>
        /// <param name="dataSource">数据源</param>
        public virtual void DataSourceControlsMapping()
        {
            if (MyControls == null)
            {
                return;
            }
            if (DataSource == null)
            {
                return;
            }
            foreach (var property in DataSource.GetType().GetProperties())
            {

                foreach (var control in MyControls)
                {
                    if (control is ExtTextEdit)
                    {
                        if (((ExtTextEdit)control).FileName == property.Name)
                        {
                            ((ExtTextEdit)control).EditValue = property.GetValue(DataSource, null)?.ToString();
                        }
                    }
                    if (control is ExtButtonEdit)
                    {
                        if (((ExtButtonEdit)control).DisplayName == property.Name)
                        {
                            ((ExtButtonEdit)control).EditValue = property.GetValue(DataSource, null)?.ToString();
                        }
                        if (((ExtButtonEdit)control).ValueName == property.Name)
                        {
                            ((ExtButtonEdit)control).Tag = property.GetValue(DataSource, null)?.ToString();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 控件状态初始化，使控件只读和非只读（根据State）
        /// </summary>
        /// <param name="controls"></param>
        public virtual void ControlStateInit()
        {
            if (MyControls == null)
            {
                return;
            }
            if (State == EditState.View)
            {
                foreach (var control in MyControls)
                {
                    if (control is ExtTextEdit)
                    {
                        ((ExtTextEdit)control).ReadOnly = true;
                    }
                    if (control is ExtButtonEdit)
                    {
                        ((ExtButtonEdit)control).ReadOnly = true;
                    }
                    if (control is SimpleButton)
                    {
                        ((SimpleButton)control).Enabled = false;
                    }
                }
            }
        }

        /// <summary>
        /// 数据保存
        /// </summary>
        public virtual void DataSourceSaveChange()
        {
            foreach (var property in DataSource.GetType().GetProperties())
            {
                foreach (var control in MyControls)
                {
                    if (control is ExtTextEdit)
                    {
                        if (((ExtTextEdit)control).FileName == property.Name)
                        {
                            property.SetValue(DataSource, Convert.ChangeType(((ExtTextEdit)control).EditValue, property.PropertyType));
                        }
                    }
                    if (control is ExtButtonEdit)
                    {
                        if (((ExtButtonEdit)control).ValueName == property.Name)
                        {
                            property.SetValue(DataSource, Convert.ChangeType(((ExtButtonEdit)control).Tag, property.PropertyType));
                        }
                    }
                }
            }
        }


        /// <summary>
        /// 关闭窗体
        /// </summary>
        public void Close(DialogResult dialogResult)
        {

            DialogResult = dialogResult;
            Close();
        }
    }
}