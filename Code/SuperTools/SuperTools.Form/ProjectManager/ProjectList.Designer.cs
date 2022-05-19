namespace SuperTools.Form.ProjectManager
{
    partial class ProjectList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectList));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnView = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnView,
            this.btnDelete});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnView),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "新增";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "编辑";
            this.btnEdit.Id = 1;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Name = "btnEdit";
            // 
            // btnView
            // 
            this.btnView.Caption = "查看";
            this.btnView.Id = 2;
            this.btnView.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnView.ImageOptions.SvgImage")));
            this.btnView.Name = "btnView";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "删除";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Name = "btnDelete";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(2766, 100);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1760);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(2766, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 100);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1660);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(2766, 100);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1660);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl.Location = new System.Drawing.Point(0, 100);
            this.gridControl.MainView = this.cardView1;
            this.gridControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl.MenuManager = this.barManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(2766, 1660);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.CardWidth = 300;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3});
            this.cardView1.DetailHeight = 486;
            this.cardView1.GridControl = this.gridControl;
            this.cardView1.Name = "cardView1";
            this.cardView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.layoutViewColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "layoutViewColumn1";
            this.layoutViewColumn1.MinWidth = 37;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.Visible = true;
            this.layoutViewColumn1.VisibleIndex = 0;
            this.layoutViewColumn1.Width = 141;
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "layoutViewColumn2";
            this.layoutViewColumn2.MinWidth = 37;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            this.layoutViewColumn2.Visible = true;
            this.layoutViewColumn2.VisibleIndex = 1;
            this.layoutViewColumn2.Width = 141;
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "layoutViewColumn3";
            this.layoutViewColumn3.MinWidth = 37;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            this.layoutViewColumn3.Visible = true;
            this.layoutViewColumn3.VisibleIndex = 2;
            this.layoutViewColumn3.Width = 141;
            // 
            // ProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2766, 1760);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ProjectList.IconOptions.Icon")));
            this.LookAndFeel.SkinName = "Metropolis";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.Name = "ProjectList";
            this.Text = "ProjectList";
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnAdd;
        private DevExpress.XtraBars.BarLargeButtonItem btnEdit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnView;
        private DevExpress.XtraBars.BarLargeButtonItem btnDelete;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn3;
    }
}