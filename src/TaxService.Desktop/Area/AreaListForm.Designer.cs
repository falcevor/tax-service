
namespace TaxService.Desktop.Area
{
    partial class AreaListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaListForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddArea = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDeleteArea = new System.Windows.Forms.ToolStripButton();
            this.dgvTaxAreas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dgvTaxAreas);
            this.panel1.Location = new System.Drawing.Point(13, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 411);
            this.panel1.TabIndex = 49;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddArea,
            this.tsbtnDeleteArea});
            this.toolStrip1.Location = new System.Drawing.Point(0, 386);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(739, 25);
            this.toolStrip1.TabIndex = 43;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAddArea
            // 
            this.tsbtnAddArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddArea.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddArea.Image")));
            this.tsbtnAddArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddArea.Name = "tsbtnAddArea";
            this.tsbtnAddArea.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAddArea.Text = "Добавить зону";
            this.tsbtnAddArea.Click += new System.EventHandler(this.tsbtnAddArea_Click);
            // 
            // tsbtnDeleteArea
            // 
            this.tsbtnDeleteArea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDeleteArea.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDeleteArea.Image")));
            this.tsbtnDeleteArea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDeleteArea.Name = "tsbtnDeleteArea";
            this.tsbtnDeleteArea.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDeleteArea.Text = "Удалить зону";
            this.tsbtnDeleteArea.Click += new System.EventHandler(this.tsbtnDeleteArea_Click);
            // 
            // dgvTaxAreas
            // 
            this.dgvTaxAreas.AllowUserToAddRows = false;
            this.dgvTaxAreas.AllowUserToDeleteRows = false;
            this.dgvTaxAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaxAreas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmId,
            this.cmName});
            this.dgvTaxAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaxAreas.Location = new System.Drawing.Point(0, 0);
            this.dgvTaxAreas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTaxAreas.Name = "dgvTaxAreas";
            this.dgvTaxAreas.Size = new System.Drawing.Size(739, 411);
            this.dgvTaxAreas.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Налоговое зоны";
            // 
            // cmId
            // 
            this.cmId.HeaderText = "Id";
            this.cmId.Name = "cmId";
            this.cmId.ReadOnly = true;
            // 
            // cmName
            // 
            this.cmName.HeaderText = "Наименование";
            this.cmName.Name = "cmName";
            this.cmName.ReadOnly = true;
            // 
            // AreaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AreaListForm";
            this.Text = "Список налоговых зон";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAddArea;
        private System.Windows.Forms.ToolStripButton tsbtnDeleteArea;
        private System.Windows.Forms.DataGridView dgvTaxAreas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmName;
    }
}