namespace TaxServiceDesktop.Report
{
    partial class ReportTemplateListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTemplateListForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnCreateReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCreate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tstbSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvReportTemplateList = new System.Windows.Forms.DataGridView();
            this.cmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportTemplateList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCreateReport,
            this.toolStripSeparator1,
            this.tsbtnCreate,
            this.tsbtnDelete,
            this.toolStripSeparator3,
            this.tstbSearchValue,
            this.tsbtnSearch,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnCreateReport
            // 
            this.tsbtnCreateReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCreateReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCreateReport.Image")));
            this.tsbtnCreateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCreateReport.Name = "tsbtnCreateReport";
            this.tsbtnCreateReport.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCreateReport.Text = "Создать отчет";
            this.tsbtnCreateReport.Click += new System.EventHandler(this.tsbtnCreateReport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnCreate
            // 
            this.tsbtnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCreate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCreate.Image")));
            this.tsbtnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCreate.Name = "tsbtnCreate";
            this.tsbtnCreate.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCreate.Text = "Создать шаблон";
            this.tsbtnCreate.Click += new System.EventHandler(this.tsbtnCreate_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDelete.Text = " ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tstbSearchValue
            // 
            this.tstbSearchValue.Name = "tstbSearchValue";
            this.tstbSearchValue.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSearch.Text = "Найти";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvReportTemplateList
            // 
            this.dgvReportTemplateList.AllowUserToAddRows = false;
            this.dgvReportTemplateList.AllowUserToDeleteRows = false;
            this.dgvReportTemplateList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportTemplateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportTemplateList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmId,
            this.cmName,
            this.cmDescription,
            this.cmFile});
            this.dgvReportTemplateList.Location = new System.Drawing.Point(12, 34);
            this.dgvReportTemplateList.MultiSelect = false;
            this.dgvReportTemplateList.Name = "dgvReportTemplateList";
            this.dgvReportTemplateList.ReadOnly = true;
            this.dgvReportTemplateList.Size = new System.Drawing.Size(832, 450);
            this.dgvReportTemplateList.TabIndex = 2;
            // 
            // cmId
            // 
            this.cmId.DataPropertyName = "id";
            this.cmId.HeaderText = "ID";
            this.cmId.Name = "cmId";
            this.cmId.ReadOnly = true;
            // 
            // cmName
            // 
            this.cmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmName.DataPropertyName = "name";
            this.cmName.HeaderText = "Название";
            this.cmName.Name = "cmName";
            this.cmName.ReadOnly = true;
            this.cmName.Width = 82;
            // 
            // cmDescription
            // 
            this.cmDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmDescription.DataPropertyName = "description";
            this.cmDescription.HeaderText = "Описание";
            this.cmDescription.Name = "cmDescription";
            this.cmDescription.ReadOnly = true;
            this.cmDescription.Width = 82;
            // 
            // cmFile
            // 
            this.cmFile.DataPropertyName = "file";
            this.cmFile.HeaderText = "Шаблон";
            this.cmFile.Name = "cmFile";
            this.cmFile.ReadOnly = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ReportTemplateListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 496);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvReportTemplateList);
            this.Name = "ReportTemplateListForm";
            this.Text = "Список шаблонов отчетов";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportTemplateList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnCreate;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tstbSearchValue;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvReportTemplateList;
        private System.Windows.Forms.ToolStripButton tsbtnCreateReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmFile;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}