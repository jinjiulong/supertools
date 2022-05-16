namespace SuperTools.Form.SystemSetting
{
    partial class MenuDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDetail));
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.btePareint = new DevExtControls.ExtButtonEdit();
            this.txtClass = new DevExtControls.ExtTextEdit();
            this.txtNamespace = new DevExtControls.ExtTextEdit();
            this.txtAssembly = new DevExtControls.ExtTextEdit();
            this.txtOrder = new DevExtControls.ExtTextEdit();
            this.txtName = new DevExtControls.ExtTextEdit();
            this.txtCode = new DevExtControls.ExtTextEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btePareint11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btePareint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamespace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssembly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btePareint11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.btePareint);
            this.layoutControl.Controls.Add(this.txtClass);
            this.layoutControl.Controls.Add(this.txtNamespace);
            this.layoutControl.Controls.Add(this.txtAssembly);
            this.layoutControl.Controls.Add(this.txtOrder);
            this.layoutControl.Controls.Add(this.txtName);
            this.layoutControl.Controls.Add(this.txtCode);
            this.layoutControl.Controls.Add(this.btnOk);
            this.layoutControl.Controls.Add(this.btnCancel);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(664, 180);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // btePareint
            // 
            this.btePareint.DisplayName = "ParentName";
            this.btePareint.Location = new System.Drawing.Point(91, 12);
            this.btePareint.Name = "btePareint";
            this.btePareint.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btePareint.Size = new System.Drawing.Size(238, 24);
            this.btePareint.StyleController = this.layoutControl;
            this.btePareint.TabIndex = 20;
            this.btePareint.ValueName = "ParentId";
            this.btePareint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btePareint_ButtonClick);
            // 
            // txtClass
            // 
            this.txtClass.FileName = "Class";
            this.txtClass.Location = new System.Drawing.Point(91, 96);
            this.txtClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(238, 24);
            this.txtClass.StyleController = this.layoutControl;
            this.txtClass.TabIndex = 19;
            // 
            // txtNamespace
            // 
            this.txtNamespace.FileName = "Namespace";
            this.txtNamespace.Location = new System.Drawing.Point(411, 68);
            this.txtNamespace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(241, 24);
            this.txtNamespace.StyleController = this.layoutControl;
            this.txtNamespace.TabIndex = 18;
            // 
            // txtAssembly
            // 
            this.txtAssembly.FileName = "Assembly";
            this.txtAssembly.Location = new System.Drawing.Point(91, 68);
            this.txtAssembly.Name = "txtAssembly";
            this.txtAssembly.Size = new System.Drawing.Size(237, 24);
            this.txtAssembly.StyleController = this.layoutControl;
            this.txtAssembly.TabIndex = 14;
            // 
            // txtOrder
            // 
            this.txtOrder.FileName = "Order";
            this.txtOrder.Location = new System.Drawing.Point(411, 40);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(241, 24);
            this.txtOrder.StyleController = this.layoutControl;
            this.txtOrder.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.FileName = "Name";
            this.txtName.Location = new System.Drawing.Point(91, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 24);
            this.txtName.StyleController = this.layoutControl;
            this.txtName.TabIndex = 12;
            // 
            // txtCode
            // 
            this.txtCode.FileName = "Code";
            this.txtCode.Location = new System.Drawing.Point(412, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(240, 24);
            this.txtCode.StyleController = this.layoutControl;
            this.txtCode.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(485, 124);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(79, 27);
            this.btnOk.StyleController = this.layoutControl;
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "确定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(568, 124);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 27);
            this.btnCancel.StyleController = this.layoutControl;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.emptySpaceItem3,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.btePareint11});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(664, 180);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 143);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(644, 17);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancel;
            this.layoutControlItem6.Location = new System.Drawing.Point(556, 112);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(88, 31);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnOk;
            this.layoutControlItem7.Location = new System.Drawing.Point(473, 112);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(83, 31);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 112);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(473, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtName;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(320, 28);
            this.layoutControlItem9.Text = "菜单名称：";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(75, 18);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtAssembly;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(320, 28);
            this.layoutControlItem11.Text = "程序集：";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(75, 18);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtCode;
            this.layoutControlItem8.Location = new System.Drawing.Point(321, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(323, 28);
            this.layoutControlItem8.Text = "菜单编号：";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(75, 18);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtOrder;
            this.layoutControlItem10.Location = new System.Drawing.Point(320, 28);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(324, 28);
            this.layoutControlItem10.Text = "菜单排序：";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(75, 18);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(321, 84);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(323, 28);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtNamespace;
            this.layoutControlItem12.Location = new System.Drawing.Point(320, 56);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(324, 28);
            this.layoutControlItem12.Text = "命名空间：";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(75, 18);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.txtClass;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(321, 28);
            this.layoutControlItem13.Text = "类名称：";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(75, 18);
            // 
            // btePareint11
            // 
            this.btePareint11.Control = this.btePareint;
            this.btePareint11.Location = new System.Drawing.Point(0, 0);
            this.btePareint11.Name = "btePareint11";
            this.btePareint11.Size = new System.Drawing.Size(321, 28);
            this.btePareint11.Text = "父菜单：";
            this.btePareint11.TextSize = new System.Drawing.Size(75, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btePareint;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(320, 28);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 18);
            // 
            // MenuDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 180);
            this.Controls.Add(this.layoutControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MenuDetail.IconOptions.Icon")));
            this.LookAndFeel.SkinName = "Metropolis";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuDetail";
            this.Text = "菜单信息";
            this.Load += new System.EventHandler(this.MenuDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btePareint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamespace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssembly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btePareint11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExtControls.ExtTextEdit txtAssembly;
        private DevExtControls.ExtTextEdit txtOrder;
        private DevExtControls.ExtTextEdit txtName;
        private DevExtControls.ExtTextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExtControls.ExtTextEdit txtClass;
        private DevExtControls.ExtTextEdit txtNamespace;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExtControls.ExtButtonEdit btePareint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem btePareint11;
    }
}