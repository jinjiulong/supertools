using System.Windows.Forms;

namespace SuperTools.Form
{
    /// <summary>
    /// Tab窗体
    /// </summary>
    public partial class TabForm : BaseForm
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public TabForm()
        {
            InitializeComponent();
            ControlBox = false;
            TopLevel = false;
            Dock = DockStyle.Fill;
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}