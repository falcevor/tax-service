namespace TaxServiceDesktop.Report
{
    partial class NewTemplateForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTemplatePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTemplateChoose = new System.Windows.Forms.Button();
            this.dgvParameters = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(15, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(446, 20);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(12, 64);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(449, 96);
            this.tbDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Файл шаблона";
            // 
            // tbTemplatePath
            // 
            this.tbTemplatePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTemplatePath.Location = new System.Drawing.Point(12, 179);
            this.tbTemplatePath.Name = "tbTemplatePath";
            this.tbTemplatePath.Size = new System.Drawing.Size(449, 20);
            this.tbTemplatePath.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Параметры";
            // 
            // btnTemplateChoose
            // 
            this.btnTemplateChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateChoose.Location = new System.Drawing.Point(424, 177);
            this.btnTemplateChoose.Name = "btnTemplateChoose";
            this.btnTemplateChoose.Size = new System.Drawing.Size(37, 23);
            this.btnTemplateChoose.TabIndex = 7;
            this.btnTemplateChoose.Text = "...";
            this.btnTemplateChoose.UseVisualStyleBackColor = true;
            this.btnTemplateChoose.Click += new System.EventHandler(this.btnTemplateChoose_Click);
            // 
            // dgvParameters
            // 
            this.dgvParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clName,
            this.cmDescription,
            this.cmDefaultValue});
            this.dgvParameters.Location = new System.Drawing.Point(15, 218);
            this.dgvParameters.Name = "dgvParameters";
            this.dgvParameters.Size = new System.Drawing.Size(446, 212);
            this.dgvParameters.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(249, 436);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(359, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // clName
            // 
            this.clName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clName.HeaderText = "Наименование";
            this.clName.Name = "clName";
            this.clName.Width = 108;
            // 
            // cmDescription
            // 
            this.cmDescription.HeaderText = "Описание";
            this.cmDescription.Name = "cmDescription";
            // 
            // cmDefaultValue
            // 
            this.cmDefaultValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmDefaultValue.HeaderText = "Значение поумолчанию";
            this.cmDefaultValue.Name = "cmDefaultValue";
            this.cmDefaultValue.Width = 138;
            // 
            // NewTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 474);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvParameters);
            this.Controls.Add(this.btnTemplateChoose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTemplatePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "NewTemplateForm";
            this.Text = "Новый шаблон отчета";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTemplatePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTemplateChoose;
        private System.Windows.Forms.DataGridView dgvParameters;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDefaultValue;
    }
}