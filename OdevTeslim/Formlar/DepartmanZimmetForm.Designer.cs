namespace OdevTeslim.Formlar
{
    partial class DepartmanZimmetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblForDepartmanZimmetFormu = new System.Windows.Forms.Label();
            this.comBxDepartmanlar = new System.Windows.Forms.ComboBox();
            this.departmanTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.lblForDepartmanlar = new System.Windows.Forms.Label();
            this.dgVDepartmanStok = new System.Windows.Forms.DataGridView();
            this.stokIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDurumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zimmetliStockViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSeciliDepartman = new System.Windows.Forms.Label();
            this.departmanTBLTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.DepartmanTBLTableAdapter();
            this.zimmetliStockViewTableAdapter = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.ZimmetliStockViewTableAdapter();
            this.btnHareketDetay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmanTBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVDepartmanStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetliStockViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForDepartmanZimmetFormu
            // 
            this.lblForDepartmanZimmetFormu.AutoSize = true;
            this.lblForDepartmanZimmetFormu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForDepartmanZimmetFormu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForDepartmanZimmetFormu.Location = new System.Drawing.Point(25, 25);
            this.lblForDepartmanZimmetFormu.Name = "lblForDepartmanZimmetFormu";
            this.lblForDepartmanZimmetFormu.Size = new System.Drawing.Size(250, 18);
            this.lblForDepartmanZimmetFormu.TabIndex = 26;
            this.lblForDepartmanZimmetFormu.Text = "Departman Bazlı Zimmet Görme";
            // 
            // comBxDepartmanlar
            // 
            this.comBxDepartmanlar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.comBxDepartmanlar.DataSource = this.departmanTBLBindingSource1;
            this.comBxDepartmanlar.DisplayMember = "DepIsim";
            this.comBxDepartmanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBxDepartmanlar.FormattingEnabled = true;
            this.comBxDepartmanlar.Location = new System.Drawing.Point(668, 25);
            this.comBxDepartmanlar.Name = "comBxDepartmanlar";
            this.comBxDepartmanlar.Size = new System.Drawing.Size(214, 26);
            this.comBxDepartmanlar.TabIndex = 45;
            this.comBxDepartmanlar.ValueMember = "DepID";
            this.comBxDepartmanlar.Visible = false;
            this.comBxDepartmanlar.SelectedIndexChanged += new System.EventHandler(this.comBxDepartmanlar_SelectedIndexChanged);
            // 
            // departmanTBLBindingSource1
            // 
            this.departmanTBLBindingSource1.DataMember = "DepartmanTBL";
            this.departmanTBLBindingSource1.DataSource = this.projeDataSeti;
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRaporAl.Location = new System.Drawing.Point(880, 369);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(94, 90);
            this.btnRaporAl.TabIndex = 44;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // lblForDepartmanlar
            // 
            this.lblForDepartmanlar.AutoSize = true;
            this.lblForDepartmanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForDepartmanlar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForDepartmanlar.Location = new System.Drawing.Point(548, 27);
            this.lblForDepartmanlar.Name = "lblForDepartmanlar";
            this.lblForDepartmanlar.Size = new System.Drawing.Size(114, 20);
            this.lblForDepartmanlar.TabIndex = 43;
            this.lblForDepartmanlar.Text = "Departmanlar :";
            // 
            // dgVDepartmanStok
            // 
            this.dgVDepartmanStok.AllowUserToAddRows = false;
            this.dgVDepartmanStok.AllowUserToDeleteRows = false;
            this.dgVDepartmanStok.AutoGenerateColumns = false;
            this.dgVDepartmanStok.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVDepartmanStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVDepartmanStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVDepartmanStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokIDDataGridViewTextBoxColumn,
            this.stokDurumIDDataGridViewTextBoxColumn,
            this.urunIsimDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.perIsimDataGridViewTextBoxColumn,
            this.perSoyisimDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn,
            this.depIDDataGridViewTextBoxColumn});
            this.dgVDepartmanStok.DataSource = this.zimmetliStockViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVDepartmanStok.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgVDepartmanStok.Location = new System.Drawing.Point(28, 115);
            this.dgVDepartmanStok.Name = "dgVDepartmanStok";
            this.dgVDepartmanStok.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVDepartmanStok.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgVDepartmanStok.RowHeadersVisible = false;
            this.dgVDepartmanStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVDepartmanStok.Size = new System.Drawing.Size(846, 344);
            this.dgVDepartmanStok.TabIndex = 42;
            this.dgVDepartmanStok.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgVDepartmanStok_DataBindingComplete);
            // 
            // stokIDDataGridViewTextBoxColumn
            // 
            this.stokIDDataGridViewTextBoxColumn.DataPropertyName = "StokID";
            this.stokIDDataGridViewTextBoxColumn.HeaderText = "Stok ID";
            this.stokIDDataGridViewTextBoxColumn.Name = "stokIDDataGridViewTextBoxColumn";
            this.stokIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // stokDurumIDDataGridViewTextBoxColumn
            // 
            this.stokDurumIDDataGridViewTextBoxColumn.DataPropertyName = "StokDurumID";
            this.stokDurumIDDataGridViewTextBoxColumn.HeaderText = "StokDurumID";
            this.stokDurumIDDataGridViewTextBoxColumn.Name = "stokDurumIDDataGridViewTextBoxColumn";
            this.stokDurumIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokDurumIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // urunIsimDataGridViewTextBoxColumn
            // 
            this.urunIsimDataGridViewTextBoxColumn.DataPropertyName = "UrunIsim";
            this.urunIsimDataGridViewTextBoxColumn.HeaderText = "Urun Isim";
            this.urunIsimDataGridViewTextBoxColumn.Name = "urunIsimDataGridViewTextBoxColumn";
            this.urunIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIsimDataGridViewTextBoxColumn.Width = 325;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perIsimDataGridViewTextBoxColumn
            // 
            this.perIsimDataGridViewTextBoxColumn.DataPropertyName = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn.HeaderText = "Isim";
            this.perIsimDataGridViewTextBoxColumn.Name = "perIsimDataGridViewTextBoxColumn";
            this.perIsimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perSoyisimDataGridViewTextBoxColumn
            // 
            this.perSoyisimDataGridViewTextBoxColumn.DataPropertyName = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.perSoyisimDataGridViewTextBoxColumn.Name = "perSoyisimDataGridViewTextBoxColumn";
            this.perSoyisimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "Personel No";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Width = 55;
            // 
            // depIDDataGridViewTextBoxColumn
            // 
            this.depIDDataGridViewTextBoxColumn.DataPropertyName = "DepID";
            this.depIDDataGridViewTextBoxColumn.HeaderText = "DepID";
            this.depIDDataGridViewTextBoxColumn.Name = "depIDDataGridViewTextBoxColumn";
            this.depIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.depIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // zimmetliStockViewBindingSource
            // 
            this.zimmetliStockViewBindingSource.DataMember = "ZimmetliStockView";
            this.zimmetliStockViewBindingSource.DataSource = this.projeDataSeti;
            // 
            // lblSeciliDepartman
            // 
            this.lblSeciliDepartman.AutoSize = true;
            this.lblSeciliDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeciliDepartman.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeciliDepartman.Location = new System.Drawing.Point(24, 77);
            this.lblSeciliDepartman.Name = "lblSeciliDepartman";
            this.lblSeciliDepartman.Size = new System.Drawing.Size(141, 20);
            this.lblSeciliDepartman.TabIndex = 48;
            this.lblSeciliDepartman.Text = "Tüm Departmanlar";
            // 
            // departmanTBLTableAdapter1
            // 
            this.departmanTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // zimmetliStockViewTableAdapter
            // 
            this.zimmetliStockViewTableAdapter.ClearBeforeFill = true;
            // 
            // btnHareketDetay
            // 
            this.btnHareketDetay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnHareketDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHareketDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHareketDetay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHareketDetay.Location = new System.Drawing.Point(880, 115);
            this.btnHareketDetay.Name = "btnHareketDetay";
            this.btnHareketDetay.Size = new System.Drawing.Size(94, 90);
            this.btnHareketDetay.TabIndex = 49;
            this.btnHareketDetay.Text = "Seçili Ürün Hareket Detayı";
            this.btnHareketDetay.UseVisualStyleBackColor = true;
            this.btnHareketDetay.Click += new System.EventHandler(this.btnHareketDetay_Click);
            // 
            // DepartmanZimmetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(994, 479);
            this.Controls.Add(this.btnHareketDetay);
            this.Controls.Add(this.lblSeciliDepartman);
            this.Controls.Add(this.comBxDepartmanlar);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.lblForDepartmanlar);
            this.Controls.Add(this.dgVDepartmanStok);
            this.Controls.Add(this.lblForDepartmanZimmetFormu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmanZimmetForm";
            this.Text = "DepartmanZimmetForm";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.DepartmanZimmetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmanTBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVDepartmanStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetliStockViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblForDepartmanZimmetFormu;
        private System.Windows.Forms.ComboBox comBxDepartmanlar;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.Label lblForDepartmanlar;
        private System.Windows.Forms.DataGridView dgVDepartmanStok;
        private System.Windows.Forms.Label lblSeciliDepartman;
        private Datasets.ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource departmanTBLBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.DepartmanTBLTableAdapter departmanTBLTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zimmetliIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perDepIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zimmetliStockViewBindingSource;
        private Datasets.ProjeDataSetiTableAdapters.ZimmetliStockViewTableAdapter zimmetliStockViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDurumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnHareketDetay;
    }
}