namespace TaxServiceDesktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnTaxpayerList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReportTemplateList = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAreaList = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.окноToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.окноToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1461, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnTaxpayerList,
            this.tsbtnReportTemplateList,
            this.tsbtnAreaList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1461, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnTaxpayerList
            // 
            this.tsbtnTaxpayerList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnTaxpayerList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTaxpayerList.Image")));
            this.tsbtnTaxpayerList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTaxpayerList.Name = "tsbtnTaxpayerList";
            this.tsbtnTaxpayerList.Size = new System.Drawing.Size(23, 22);
            this.tsbtnTaxpayerList.Text = "Список налогаплательщиков";
            this.tsbtnTaxpayerList.Click += new System.EventHandler(this.tsbtnTaxpayerList_Click);
            // 
            // tsbtnReportTemplateList
            // 
            this.tsbtnReportTemplateList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnReportTemplateList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReportTemplateList.Image")));
            this.tsbtnReportTemplateList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReportTemplateList.Name = "tsbtnReportTemplateList";
            this.tsbtnReportTemplateList.Size = new System.Drawing.Size(23, 22);
            this.tsbtnReportTemplateList.Text = "Отчётность";
            this.tsbtnReportTemplateList.Click += new System.EventHandler(this.tsbtnReportTemplateList_Click);
            // 
            // tsbtnAreaList
            // 
            this.tsbtnAreaList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAreaList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAreaList.Image")));
            this.tsbtnAreaList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAreaList.Name = "tsbtnAreaList";
            this.tsbtnAreaList.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAreaList.Text = "toolStripButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 906);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налогооблажение";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnTaxpayerList;
        private System.Windows.Forms.ToolStripButton tsbtnReportTemplateList;
        private System.Windows.Forms.ToolStripButton tsbtnAreaList;
    }
}