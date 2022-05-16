using DevExpress.XtraEditors;
using System.ComponentModel;

namespace DevExtControls
{
    public partial class ExtTextEdit : TextEdit
    {
        private string _fileName;
        [Category("自定义属性"), Description("绑定数据源字段名称")]
        public string FileName
        {
            set { _fileName = value; }
            get { return _fileName; }
        }
        public ExtTextEdit()
        {
            InitializeComponent();
        }
    }
}
