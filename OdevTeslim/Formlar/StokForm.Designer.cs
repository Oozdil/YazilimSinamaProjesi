using OdevTeslim.Datasets;

namespace OdevTeslim.Formlar
{
    partial class StokForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.dgVStock = new System.Windows.Forms.DataGridView();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zIMMETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.lblForStokFormu = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.stockViewTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.StockViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStokEkle.Location = new System.Drawing.Point(888, 75);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(86, 90);
            this.btnStokEkle.TabIndex = 18;
            this.btnStokEkle.Text = "Stok Gir";
            this.btnStokEkle.UseVisualStyleBackColor = true;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // dgVStock
            // 
            this.dgVStock.AllowUserToAddRows = false;
            this.dgVStock.AllowUserToDeleteRows = false;
            this.dgVStock.AutoGenerateColumns = false;
            this.dgVStock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.urunIsimDataGridViewTextBoxColumn,
            this.dEPODataGridViewTextBoxColumn,
            this.zIMMETDataGridViewTextBoxColumn,
            this.aTIKDataGridViewTextBoxColumn});
            this.dgVStock.DataSource = this.stockViewBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVStock.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgVStock.Location = new System.Drawing.Point(25, 75);
            this.dgVStock.MultiSelect = false;
            this.dgVStock.Name = "dgVStock";
            this.dgVStock.ReadOnly = true;
            this.dgVStock.RowHeadersVisible = false;
            this.dgVStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgVStock.Size = new System.Drawing.Size(857, 369);
            this.dgVStock.TabIndex = 12;
            this.dgVStock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgVStock_DataBindingComplete);
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "URUN ID";
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "KATEGORİ";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "MARKA";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunIsimDataGridViewTextBoxColumn
            // 
            this.urunIsimDataGridViewTextBoxColumn.DataPropertyName = "UrunIsim";
            this.urunIsimDataGridViewTextBoxColumn.HeaderText = "URUN ADI";
            this.urunIsimDataGridViewTextBoxColumn.Name = "urunIsimDataGridViewTextBoxColumn";
            this.urunIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIsimDataGridViewTextBoxColumn.Width = 390;
            // 
            // dEPODataGridViewTextBoxColumn
            // 
            this.dEPODataGridViewTextBoxColumn.DataPropertyName = "DEPO";
            this.dEPODataGridViewTextBoxColumn.HeaderText = "DEPO";
            this.dEPODataGridViewTextBoxColumn.Name = "dEPODataGridViewTextBoxColumn";
            this.dEPODataGridViewTextBoxColumn.ReadOnly = true;
            this.dEPODataGridViewTextBoxColumn.Width = 70;
            // 
            // zIMMETDataGridViewTextBoxColumn
            // 
            this.zIMMETDataGridViewTextBoxColumn.DataPropertyName = "ZIMMET";
            this.zIMMETDataGridViewTextBoxColumn.HeaderText = "ZIMMET";
            this.zIMMETDataGridViewTextBoxColumn.Name = "zIMMETDataGridViewTextBoxColumn";
            this.zIMMETDataGridViewTextBoxColumn.ReadOnly = true;
            this.zIMMETDataGridViewTextBoxColumn.Width = 70;
            // 
            // aTIKDataGridViewTextBoxColumn
            // 
            this.aTIKDataGridViewTextBoxColumn.DataPropertyName = "ATIK";
            this.aTIKDataGridViewTextBoxColumn.HeaderText = "ATIK";
            this.aTIKDataGridViewTextBoxColumn.Name = "aTIKDataGridViewTextBoxColumn";
            this.aTIKDataGridViewTextBoxColumn.ReadOnly = true;
            this.aTIKDataGridViewTextBoxColumn.Width = 70;
            // 
            // stockViewBindingSource1
            // 
            this.stockViewBindingSource1.DataMember = "StockView";
            this.stockViewBindingSource1.DataSource = this.projeDataSeti;
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblForStokFormu
            // 
            this.lblForStokFormu.AutoSize = true;
            this.lblForStokFormu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForStokFormu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForStokFormu.Location = new System.Drawing.Point(25, 25);
            this.lblForStokFormu.Name = "lblForStokFormu";
            this.lblForStokFormu.Size = new System.Drawing.Size(107, 18);
            this.lblForStokFormu.TabIndex = 11;
            this.lblForStokFormu.Text = "Stok Durumu";
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(888, 354);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 90);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Rapor Al";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // stockViewTableAdapter1
            // 
            this.stockViewTableAdapter1.ClearBeforeFill = true;
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(986, 472);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.dgVStock);
            this.Controls.Add(this.lblForStokFormu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StokForm";
            this.Text = "StokForm";
            this.Load += new System.EventHandler(this.StokForm_Load);
            this.VisibleChanged += new System.EventHandler(this.StokForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgVStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.DataGridView dgVStock;
        private System.Windows.Forms.Label lblForStokFormu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIMMETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTIKDataGridViewTextBoxColumn;
        private ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource stockViewBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.StockViewTableAdapter stockViewTableAdapter1;
    }
}