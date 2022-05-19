namespace SuperTools.Form.SmallTools
{
    partial class GSCloudSql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSCloudSql));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnReplace = new DevExpress.XtraEditors.SimpleButton();
            this.txtReplacedSql = new DevExpress.XtraEditors.MemoEdit();
            this.txtOriginSql = new DevExpress.XtraEditors.MemoEdit();
            this.txtParams = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReplacedSql.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOriginSql.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParams.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1152, 72);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.layoutControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 72);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1152, 784);
            this.panelControl2.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnReplace);
            this.layoutControl1.Controls.Add(this.txtReplacedSql);
            this.layoutControl1.Controls.Add(this.txtOriginSql);
            this.layoutControl1.Controls.Add(this.txtParams);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1148, 780);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(1078, 741);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(58, 27);
            this.btnReplace.StyleController = this.layoutControl1;
            this.btnReplace.TabIndex = 7;
            this.btnReplace.Text = "执行";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtReplacedSql
            // 
            this.txtReplacedSql.Location = new System.Drawing.Point(79, 395);
            this.txtReplacedSql.Margin = new System.Windows.Forms.Padding(2);
            this.txtReplacedSql.Name = "txtReplacedSql";
            this.txtReplacedSql.Properties.ReadOnly = true;
            this.txtReplacedSql.Size = new System.Drawing.Size(1057, 342);
            this.txtReplacedSql.StyleController = this.layoutControl1;
            this.txtReplacedSql.TabIndex = 6;
            // 
            // txtOriginSql
            // 
            this.txtOriginSql.Location = new System.Drawing.Point(79, 88);
            this.txtOriginSql.Margin = new System.Windows.Forms.Padding(2);
            this.txtOriginSql.Name = "txtOriginSql";
            this.txtOriginSql.Size = new System.Drawing.Size(1057, 303);
            this.txtOriginSql.StyleController = this.layoutControl1;
            this.txtOriginSql.TabIndex = 5;
            // 
            // txtParams
            // 
            this.txtParams.Location = new System.Drawing.Point(79, 12);
            this.txtParams.Margin = new System.Windows.Forms.Padding(2);
            this.txtParams.Name = "txtParams";
            this.txtParams.Size = new System.Drawing.Size(1057, 72);
            this.txtParams.StyleController = this.layoutControl1;
            this.txtParams.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1148, 780);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtParams;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1128, 76);
            this.layoutControlItem1.Text = "参数：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(63, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtOriginSql;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1128, 307);
            this.layoutControlItem2.Text = "Sql语句：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtReplacedSql;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 383);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1128, 346);
            this.layoutControlItem3.Text = "sql语句：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(63, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnReplace;
            this.layoutControlItem4.Location = new System.Drawing.Point(1066, 729);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(62, 31);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 729);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1066, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(61, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1075, 36);
            this.labelControl1.StyleController = this.layoutControl2;
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "此工具用于IGIX中的XXX，跟踪出SQL后，SQL语句中含有参数?，我们只需要将跟出参数列表放入第一行，将跟出的SQL放到第二行，点击【执行】，则会将SQL语句" +
    "中的参数?替换成对应参数的值。";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.labelControl2);
            this.layoutControl2.Controls.Add(this.labelControl1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1148, 68);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1148, 68);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.labelControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(49, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1079, 48);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 18);
            this.labelControl2.StyleController = this.layoutControl2;
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "说明：";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.labelControl2;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(49, 48);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // GSCloudSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 856);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GSCloudSql.IconOptions.Icon")));
            this.LookAndFeel.SkinName = "Metropolis";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "GSCloudSql";
            this.Text = "GSCloudSql";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtReplacedSql.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOriginSql.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParams.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit txtOriginSql;
        private DevExpress.XtraEditors.MemoEdit txtParams;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.MemoEdit txtReplacedSql;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnReplace;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}