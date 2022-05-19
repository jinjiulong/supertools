namespace SuperTools.Form.SmallTools
{
    partial class ToolsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsList));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGSCloudSql = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2766, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // btnGSCloudSql
            // 
            this.btnGSCloudSql.Location = new System.Drawing.Point(39, 126);
            this.btnGSCloudSql.Name = "btnGSCloudSql";
            this.btnGSCloudSql.Size = new System.Drawing.Size(177, 154);
            this.btnGSCloudSql.TabIndex = 1;
            this.btnGSCloudSql.Text = "GSCloudSQL";
            this.btnGSCloudSql.Click += new System.EventHandler(this.btnGSCloudSql_Click);
            // 
            // ToolsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2766, 1843);
            this.Controls.Add(this.btnGSCloudSql);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ToolsList.IconOptions.Icon")));
            this.LookAndFeel.SkinName = "Metropolis";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "ToolsList";
            this.Text = "ToolsList";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGSCloudSql;
    }
}