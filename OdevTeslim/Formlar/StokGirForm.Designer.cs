using OdevTeslim.Datasets;

namespace OdevTeslim.Formlar
{
    partial class StokGirForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnYeniUrun = new System.Windows.Forms.Button();
            this.dgVUrunler = new System.Windows.Forms.DataGridView();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMarkaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKategoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblFatTarihi = new System.Windows.Forms.Label();
            this.lblfatNo = new System.Windows.Forms.Label();
            this.lblSeciliUrun = new System.Windows.Forms.Label();
            this.lblForSeciliUrunInfo = new System.Windows.Forms.Label();
            this.txBxFiyat = new System.Windows.Forms.TextBox();
            this.txBxFatNo = new System.Windows.Forms.TextBox();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.lblForStokGirForm = new System.Windows.Forms.Label();
            this.btnYeniTedarikci = new System.Windows.Forms.Button();
            this.linkLblClose = new System.Windows.Forms.LinkLabel();
            this.lblAdet = new System.Windows.Forms.Label();
            this.txBxAdet = new System.Windows.Forms.TextBox();
            this.comboBxTedarikciler = new System.Windows.Forms.ComboBox();
            this.dTPickerFaturaTarih = new System.Windows.Forms.DateTimePicker();
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.tedarikciTBLBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tedarikciTBLTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.TedarikciTBLTableAdapter();
            this.urunlerViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerViewTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.UrunlerViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciTBLBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniUrun
            // 
            this.btnYeniUrun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnYeniUrun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniUrun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYeniUrun.Location = new System.Drawing.Point(759, 287);
            this.btnYeniUrun.Name = "btnYeniUrun";
            this.btnYeniUrun.Size = new System.Drawing.Size(78, 70);
            this.btnYeniUrun.TabIndex = 20;
            this.btnYeniUrun.Text = "Yeni Ürün Tanımla";
            this.btnYeniUrun.UseVisualStyleBackColor = true;
            this.btnYeniUrun.Click += new System.EventHandler(this.btnYeniUrun_Click);
            // 
            // dgVUrunler
            // 
            this.dgVUrunler.AllowUserToAddRows = false;
            this.dgVUrunler.AllowUserToDeleteRows = false;
            this.dgVUrunler.AutoGenerateColumns = false;
            this.dgVUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.urunIsimDataGridViewTextBoxColumn,
            this.urunMarkaIDDataGridViewTextBoxColumn,
            this.urunKategoriIDDataGridViewTextBoxColumn});
            this.dgVUrunler.DataSource = this.urunlerViewBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgVUrunler.Location = new System.Drawing.Point(18, 46);
            this.dgVUrunler.Name = "dgVUrunler";
            this.dgVUrunler.ReadOnly = true;
            this.dgVUrunler.RowHeadersVisible = false;
            this.dgVUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVUrunler.Size = new System.Drawing.Size(717, 409);
            this.dgVUrunler.TabIndex = 21;
            this.dgVUrunler.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgVUrunler_DataBindingComplete);
            this.dgVUrunler.SelectionChanged += new System.EventHandler(this.dgVUrunler_SelectionChanged);
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "Urun ID";
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIDDataGridViewTextBoxColumn.Width = 50;
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
            // urunIsimDataGridViewTextBoxColumn
            // 
            this.urunIsimDataGridViewTextBoxColumn.DataPropertyName = "UrunIsim";
            this.urunIsimDataGridViewTextBoxColumn.HeaderText = "UrunIsim";
            this.urunIsimDataGridViewTextBoxColumn.Name = "urunIsimDataGridViewTextBoxColumn";
            this.urunIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIsimDataGridViewTextBoxColumn.Width = 450;
            // 
            // urunMarkaIDDataGridViewTextBoxColumn
            // 
            this.urunMarkaIDDataGridViewTextBoxColumn.DataPropertyName = "UrunMarkaID";
            this.urunMarkaIDDataGridViewTextBoxColumn.HeaderText = "UrunMarkaID";
            this.urunMarkaIDDataGridViewTextBoxColumn.Name = "urunMarkaIDDataGridViewTextBoxColumn";
            this.urunMarkaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunMarkaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // urunKategoriIDDataGridViewTextBoxColumn
            // 
            this.urunKategoriIDDataGridViewTextBoxColumn.DataPropertyName = "UrunKategoriID";
            this.urunKategoriIDDataGridViewTextBoxColumn.HeaderText = "UrunKategoriID";
            this.urunKategoriIDDataGridViewTextBoxColumn.Name = "urunKategoriIDDataGridViewTextBoxColumn";
            this.urunKategoriIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunKategoriIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunEkle.Location = new System.Drawing.Point(759, 363);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(200, 39);
            this.btnUrunEkle.TabIndex = 30;
            this.btnUrunEkle.Text = "Stok Girişi Yap";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiyat.Location = new System.Drawing.Point(759, 151);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(126, 18);
            this.lblFiyat.TabIndex = 32;
            this.lblFiyat.Text = "Alış Fiyatı (TL) :";
            // 
            // lblFatTarihi
            // 
            this.lblFatTarihi.AutoSize = true;
            this.lblFatTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFatTarihi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFatTarihi.Location = new System.Drawing.Point(759, 97);
            this.lblFatTarihi.Name = "lblFatTarihi";
            this.lblFatTarihi.Size = new System.Drawing.Size(113, 18);
            this.lblFatTarihi.TabIndex = 31;
            this.lblFatTarihi.Text = "Fatura Tarihi :";
            // 
            // lblfatNo
            // 
            this.lblfatNo.AutoSize = true;
            this.lblfatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfatNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfatNo.Location = new System.Drawing.Point(759, 46);
            this.lblfatNo.Name = "lblfatNo";
            this.lblfatNo.Size = new System.Drawing.Size(93, 18);
            this.lblfatNo.TabIndex = 29;
            this.lblfatNo.Text = "Fatura No :";
            // 
            // lblSeciliUrun
            // 
            this.lblSeciliUrun.AutoSize = true;
            this.lblSeciliUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeciliUrun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeciliUrun.Location = new System.Drawing.Point(344, 18);
            this.lblSeciliUrun.Name = "lblSeciliUrun";
            this.lblSeciliUrun.Size = new System.Drawing.Size(145, 15);
            this.lblSeciliUrun.TabIndex = 27;
            this.lblSeciliUrun.Text = "Lütfen Ürün Seçiniz...";
            // 
            // lblForSeciliUrunInfo
            // 
            this.lblForSeciliUrunInfo.AutoSize = true;
            this.lblForSeciliUrunInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForSeciliUrunInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForSeciliUrunInfo.Location = new System.Drawing.Point(238, 16);
            this.lblForSeciliUrunInfo.Name = "lblForSeciliUrunInfo";
            this.lblForSeciliUrunInfo.Size = new System.Drawing.Size(100, 18);
            this.lblForSeciliUrunInfo.TabIndex = 25;
            this.lblForSeciliUrunInfo.Text = "Seçili Ürün :";
            // 
            // txBxFiyat
            // 
            this.txBxFiyat.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxFiyat.Location = new System.Drawing.Point(759, 175);
            this.txBxFiyat.Name = "txBxFiyat";
            this.txBxFiyat.Size = new System.Drawing.Size(111, 24);
            this.txBxFiyat.TabIndex = 24;
            this.txBxFiyat.TextChanged += new System.EventHandler(this.txBxFiyat_TextChanged);
            // 
            // txBxFatNo
            // 
            this.txBxFatNo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxFatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxFatNo.Location = new System.Drawing.Point(759, 70);
            this.txBxFatNo.Name = "txBxFatNo";
            this.txBxFatNo.Size = new System.Drawing.Size(162, 24);
            this.txBxFatNo.TabIndex = 22;
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.AutoSize = true;
            this.lblTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedarikci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTedarikci.Location = new System.Drawing.Point(759, 218);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(87, 18);
            this.lblTedarikci.TabIndex = 33;
            this.lblTedarikci.Text = "Tedarikçi :";
            // 
            // lblForStokGirForm
            // 
            this.lblForStokGirForm.AutoSize = true;
            this.lblForStokGirForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForStokGirForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForStokGirForm.Location = new System.Drawing.Point(15, 16);
            this.lblForStokGirForm.Name = "lblForStokGirForm";
            this.lblForStokGirForm.Size = new System.Drawing.Size(122, 18);
            this.lblForStokGirForm.TabIndex = 35;
            this.lblForStokGirForm.Text = "Tanımlı Ürünler";
            // 
            // btnYeniTedarikci
            // 
            this.btnYeniTedarikci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnYeniTedarikci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniTedarikci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYeniTedarikci.Location = new System.Drawing.Point(864, 287);
            this.btnYeniTedarikci.Name = "btnYeniTedarikci";
            this.btnYeniTedarikci.Size = new System.Drawing.Size(95, 70);
            this.btnYeniTedarikci.TabIndex = 36;
            this.btnYeniTedarikci.Text = "Yeni Tedarikçi Tanımla";
            this.btnYeniTedarikci.UseVisualStyleBackColor = true;
            this.btnYeniTedarikci.Click += new System.EventHandler(this.btnYeniTedarikci_Click);
            // 
            // linkLblClose
            // 
            this.linkLblClose.AutoSize = true;
            this.linkLblClose.BackColor = System.Drawing.Color.Red;
            this.linkLblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblClose.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLblClose.Location = new System.Drawing.Point(886, 435);
            this.linkLblClose.Name = "linkLblClose";
            this.linkLblClose.Size = new System.Drawing.Size(69, 20);
            this.linkLblClose.TabIndex = 37;
            this.linkLblClose.TabStop = true;
            this.linkLblClose.Text = "Vazgeç";
            this.linkLblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblClose_LinkClicked);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdet.Location = new System.Drawing.Point(873, 151);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(51, 18);
            this.lblAdet.TabIndex = 39;
            this.lblAdet.Text = "Adet :";
            // 
            // txBxAdet
            // 
            this.txBxAdet.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxAdet.Location = new System.Drawing.Point(876, 175);
            this.txBxAdet.Name = "txBxAdet";
            this.txBxAdet.Size = new System.Drawing.Size(45, 24);
            this.txBxAdet.TabIndex = 38;
            this.txBxAdet.Text = "0";
            this.txBxAdet.TextChanged += new System.EventHandler(this.txBxAdet_TextChanged);
            // 
            // comboBxTedarikciler
            // 
            this.comboBxTedarikciler.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.comboBxTedarikciler.DataSource = this.tedarikciTBLBindingSource2;
            this.comboBxTedarikciler.DisplayMember = "TedarikciIsim";
            this.comboBxTedarikciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBxTedarikciler.FormattingEnabled = true;
            this.comboBxTedarikciler.Location = new System.Drawing.Point(759, 248);
            this.comboBxTedarikciler.Name = "comboBxTedarikciler";
            this.comboBxTedarikciler.Size = new System.Drawing.Size(200, 23);
            this.comboBxTedarikciler.TabIndex = 40;
            this.comboBxTedarikciler.ValueMember = "TedarikciID";
            // 
            // dTPickerFaturaTarih
            // 
            this.dTPickerFaturaTarih.CalendarMonthBackground = System.Drawing.Color.LightGoldenrodYellow;
            this.dTPickerFaturaTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTPickerFaturaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPickerFaturaTarih.Location = new System.Drawing.Point(759, 119);
            this.dTPickerFaturaTarih.Name = "dTPickerFaturaTarih";
            this.dTPickerFaturaTarih.Size = new System.Drawing.Size(162, 24);
            this.dTPickerFaturaTarih.TabIndex = 41;
            this.dTPickerFaturaTarih.ValueChanged += new System.EventHandler(this.dTPickerFaturaTarih_ValueChanged);
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tedarikciTBLBindingSource2
            // 
            this.tedarikciTBLBindingSource2.DataMember = "TedarikciTBL";
            this.tedarikciTBLBindingSource2.DataSource = this.projeDataSeti;
            // 
            // tedarikciTBLTableAdapter1
            // 
            this.tedarikciTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // urunlerViewBindingSource1
            // 
            this.urunlerViewBindingSource1.DataMember = "UrunlerView";
            this.urunlerViewBindingSource1.DataSource = this.projeDataSeti;
            // 
            // urunlerViewTableAdapter1
            // 
            this.urunlerViewTableAdapter1.ClearBeforeFill = true;
            // 
            // StokGirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(967, 488);
            this.Controls.Add(this.dTPickerFaturaTarih);
            this.Controls.Add(this.comboBxTedarikciler);
            this.Controls.Add(this.txBxAdet);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.linkLblClose);
            this.Controls.Add(this.btnYeniTedarikci);
            this.Controls.Add(this.lblForStokGirForm);
            this.Controls.Add(this.lblTedarikci);
            this.Controls.Add(this.txBxFatNo);
            this.Controls.Add(this.txBxFiyat);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblFatTarihi);
            this.Controls.Add(this.lblfatNo);
            this.Controls.Add(this.lblSeciliUrun);
            this.Controls.Add(this.lblForSeciliUrunInfo);
            this.Controls.Add(this.dgVUrunler);
            this.Controls.Add(this.btnYeniUrun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StokGirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokGirForm";
            this.Load += new System.EventHandler(this.StokGirForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StokGirForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgVUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciTBLBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerViewBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniUrun;
        private System.Windows.Forms.DataGridView dgVUrunler;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblFatTarihi;
        private System.Windows.Forms.Label lblfatNo;
        private System.Windows.Forms.Label lblSeciliUrun;
        private System.Windows.Forms.Label lblForSeciliUrunInfo;
        private System.Windows.Forms.TextBox txBxFiyat;
        private System.Windows.Forms.TextBox txBxFatNo;
        private System.Windows.Forms.Label lblTedarikci;
        private System.Windows.Forms.Label lblForStokGirForm;
        private System.Windows.Forms.Button btnYeniTedarikci;
        private System.Windows.Forms.LinkLabel linkLblClose;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.TextBox txBxAdet;
        private System.Windows.Forms.ComboBox comboBxTedarikciler;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMarkaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKategoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dTPickerFaturaTarih;
        private ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource tedarikciTBLBindingSource2;
        private Datasets.ProjeDataSetiTableAdapters.TedarikciTBLTableAdapter tedarikciTBLTableAdapter1;
        private System.Windows.Forms.BindingSource urunlerViewBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.UrunlerViewTableAdapter urunlerViewTableAdapter1;
    }
}