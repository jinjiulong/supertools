using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using System.ComponentModel;

namespace DevExtControls
{
    public partial class ExtButtonEdit : ButtonEdit
    {
        [Category("自定义属性"), Description("展示字段")]
        public string DisplayName { get; set; }

        [Category("自定义属性"), Description("存储字段")]
        public string ValueName { get; set; }

        public ExtButtonEdit()
        {
            InitializeComponent();
        }

        protected override void OnClickButton(EditorButtonObjectInfoArgs buttonInfo)
        {
            if (ReadOnly == false)
            {
                base.OnClickButton(buttonInfo);
            }

        }
    }
}
