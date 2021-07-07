namespace TaxServiceDesktop.Taxpayer
{
    partial class TaxpayerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxpayerListForm));
            this.dgvTaxpayerList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnCreate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstbSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmInn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmKPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmBeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmTaxType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmPlaceAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmAdditionalInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmPlateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxpayerList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTaxpayerList
            // 
            this.dgvTaxpayerList.AllowUserToAddRows = false;
            this.dgvTaxpayerList.AllowUserToDeleteRows = false;
            this.dgvTaxpayerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaxpayerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaxpayerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmId,
            this.cmInn,
            this.cmKPP,
            this.cmName,
            this.cmCategory,
            this.cmBeginDate,
            this.cmTaxType,
            this.cmPlaceAddress,
            this.cmAdditionalInfo,
            this.cmPlateType,
            this.cmPercent});
            this.dgvTaxpayerList.Location = new System.Drawing.Point(12, 28);
            this.dgvTaxpayerList.Name = "dgvTaxpayerList";
            this.dgvTaxpayerList.Size = new System.Drawing.Size(776, 410);
            this.dgvTaxpayerList.TabIndex = 0;
            this.dgvTaxpayerList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTaxpayerList_MouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCreate,
            this.tsbtnEdit,
            this.tsbtnDelete,
            this.toolStripSeparator1,
            this.tstbSearchValue,
            this.tsbtnSearch,
            this.toolStripSeparator2,
            this.tsbtnRefresh,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnCreate
            // 
            this.tsbtnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCreate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCreate.Image")));
            this.tsbtnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCreate.Name = "tsbtnCreate";
            this.tsbtnCreate.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCreate.Text = "Создать";
            this.tsbtnCreate.Click += new System.EventHandler(this.tsbtnCreate_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnEdit.Text = "Изменить";
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDelete.Text = "Удалить";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnSearch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbtnRefresh.Text = "Обновить";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cmId
            // 
            this.cmId.DataPropertyName = "id";
            this.cmId.HeaderText = "ID";
            this.cmId.Name = "cmId";
            this.cmId.ReadOnly = true;
            this.cmId.Visible = false;
            // 
            // cmInn
            // 
            this.cmInn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmInn.DataPropertyName = "inn";
            this.cmInn.HeaderText = "ИНН";
            this.cmInn.Name = "cmInn";
            this.cmInn.ReadOnly = true;
            this.cmInn.Width = 56;
            // 
            // cmKPP
            // 
            this.cmKPP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmKPP.DataPropertyName = "kpp";
            this.cmKPP.HeaderText = "КПП";
            this.cmKPP.Name = "cmKPP";
            this.cmKPP.ReadOnly = true;
            this.cmKPP.Width = 55;
            // 
            // cmName
            // 
            this.cmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmName.DataPropertyName = "name";
            this.cmName.HeaderText = "Имя";
            this.cmName.Name = "cmName";
            this.cmName.ReadOnly = true;
            this.cmName.Width = 54;
            // 
            // cmCategory
            // 
            this.cmCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmCategory.DataPropertyName = "category";
            this.cmCategory.HeaderText = "Категория";
            this.cmCategory.Name = "cmCategory";
            this.cmCategory.ReadOnly = true;
            this.cmCategory.Width = 85;
            // 
            // cmBeginDate
            // 
            this.cmBeginDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmBeginDate.DataPropertyName = "beginDate";
            this.cmBeginDate.HeaderText = "Дата постановки на учет";
            this.cmBeginDate.Name = "cmBeginDate";
            this.cmBeginDate.ReadOnly = true;
            this.cmBeginDate.Width = 126;
            // 
            // cmTaxType
            // 
            this.cmTaxType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmTaxType.DataPropertyName = "taxType";
            this.cmTaxType.HeaderText = "Тип налогооблажения";
            this.cmTaxType.Name = "cmTaxType";
            this.cmTaxType.ReadOnly = true;
            this.cmTaxType.Width = 132;
            // 
            // cmPlaceAddress
            // 
            this.cmPlaceAddress.DataPropertyName = "placeAddress";
            this.cmPlaceAddress.HeaderText = "Место регистрации";
            this.cmPlaceAddress.Name = "cmPlaceAddress";
            this.cmPlaceAddress.ReadOnly = true;
            this.cmPlaceAddress.Width = 200;
            // 
            // cmAdditionalInfo
            // 
            this.cmAdditionalInfo.DataPropertyName = "additionalInfo";
            this.cmAdditionalInfo.HeaderText = "Дполонительные сведения";
            this.cmAdditionalInfo.Name = "cmAdditionalInfo";
            this.cmAdditionalInfo.Visible = false;
            // 
            // cmPlateType
            // 
            this.cmPlateType.DataPropertyName = "placeType";
            this.cmPlateType.HeaderText = "Тип места регистрации";
            this.cmPlateType.Name = "cmPlateType";
            this.cmPlateType.ReadOnly = true;
            this.cmPlateType.Visible = false;
            // 
            // cmPercent
            // 
            this.cmPercent.DataPropertyName = "percent";
            this.cmPercent.HeaderText = "Процентная ставка";
            this.cmPercent.Name = "cmPercent";
            this.cmPercent.ReadOnly = true;
            this.cmPercent.Visible = false;
            // 
            // TaxpayerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvTaxpayerList);
            this.Name = "TaxpayerListForm";
            this.Text = "Список налогоплательщиков";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxpayerList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaxpayerList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnCreate;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tstbSearchValue;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmInn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmKPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmBeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmTaxType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmPlaceAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmAdditionalInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmPlateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmPercent;
    }
}