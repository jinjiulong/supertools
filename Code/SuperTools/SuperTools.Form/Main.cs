using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraTab;
using Newtonsoft.Json;
using SuperTools.VO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperTools.Form
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class Main : BaseForm
    {
        public Main()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            var result = Get("/api/Menu/GetNav");
            if (result.Code == 1)
            {
                var nav = result.GetData<List<NavVO>>();
                NavInit(nav);
            }
            else
            {
                XtraMessageBox.Show(result.Msg);
            }
        }

        /// <summary>
        /// 导航初始化
        /// </summary>
        /// <param name="navs"></param>
        private void NavInit(List<NavVO> navs)
        {
            navs = navs.OrderBy(x => x.Order).ToList();
            foreach (var nav in navs)
            {
                var navBarGroup = new NavBarGroup();
                navBarGroup.Name = nav.Code;
                navBarGroup.Caption = nav.Title;
                foreach (var item in nav.ChildNavs)
                {
                    var navBarItem = new NavBarItem();
                    navBarItem.Name = item.Code;
                    navBarItem.Caption = item.Title;
                    navBarItem.Tag = $"{item.Assembly}-{item.Namespace}-{item.Class}";
                    navBarItem.LinkClicked += NavBarItem_LinkClicked;
                    navBarGroup.ItemLinks.Add(navBarItem);
                }
                navBarControl.Groups.Add(navBarGroup);
            }
        }

        /// <summary>
        /// 注册菜单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavBarItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var navBarItem = (NavBarItem)sender;
            var menuTag = navBarItem.Tag?.ToString();
            var tags = menuTag.Split('-');
            if (tags.Length != 3)
            {
                XtraMessageBox.Show("该菜单信息维护异常");
                return;
            }
            foreach (XtraTabPage page in xtraTabControl.TabPages)
            {
                if (page.Name == $"tab_{navBarItem.Name}")
                {
                    xtraTabControl.SelectedTabPage = page;//显示该页
                    return;
                }
            }
            var assembly = tags[0];
            var namespaceInfo = tags[1];
            var classInfo = tags[2];
            var instance = Activator.CreateInstance(assembly, $"{namespaceInfo}.{classInfo}");
            if (instance.Unwrap() is TabForm)
            {
                var tabForm = (TabForm)instance.Unwrap();
                var tabPage = new XtraTabPage
                {
                    Text = navBarItem.Caption,
                    Name = $"tab_{navBarItem.Name}"
                };
                xtraTabControl.TabPages.Add(tabPage);
                tabForm.Parent = tabPage;
                tabForm.Show();
                xtraTabControl.SelectedTabPage = tabPage;
            }
            else
            {
                XtraMessageBox.Show("该窗体不是Tab窗体");
                return;
            }
        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            var page = (XtraTabPage)((DevExpress.XtraTab.ViewInfo.PageEventArgs)e).Page;
            xtraTabControl.TabPages.Remove(page);
        }
    }
}
