using OdevTeslim.Datasets;

namespace OdevTeslim.Formlar
{
    partial class ZimmetDuzenleForm
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
            this.lblForZimmetAtamaFormu = new System.Windows.Forms.Label();
            this.radioBtnKisiyeAta = new System.Windows.Forms.RadioButton();
            this.radioBtnDepoyaAl = new System.Windows.Forms.RadioButton();
            this.radioBtnAtigaAl = new System.Windows.Forms.RadioButton();
            this.btnKisiSecKime = new System.Windows.Forms.Button();
            this.dgVZimmetliUrunler = new System.Windows.Forms.DataGridView();
            this.stokIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDurumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zimmetliStockViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.lblZimmetSonuc = new System.Windows.Forms.Label();
            this.groupBoxKimden = new System.Windows.Forms.GroupBox();
            this.lblKimden = new System.Windows.Forms.Label();
            this.btnKisiSecKimden = new System.Windows.Forms.Button();
            this.radioBtnDepodanAl = new System.Windows.Forms.RadioButton();
            this.radioBtnKisidenAl = new System.Windows.Forms.RadioButton();
            this.groupBoxKime = new System.Windows.Forms.GroupBox();
            this.lblKime = new System.Windows.Forms.Label();
            this.btnZimmetAta = new System.Windows.Forms.Button();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.zimmetliStockViewTableAdapter = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.ZimmetliStockViewTableAdapter();
            this.dgVZimmetSonucu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokHareketTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokHareketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokHareketTipiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zimmetViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zimmetTutanagiDataSet = new OdevTeslim.Datasets.ZimmetTutanagiDataSet();
            this.zimmetViewTableAdapter = new OdevTeslim.Datasets.ZimmetTutanagiDataSetTableAdapters.ZimmetViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVZimmetliUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetliStockViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            this.groupBoxKimden.SuspendLayout();
            this.groupBoxKime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVZimmetSonucu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetTutanagiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForZimmetAtamaFormu
            // 
            this.lblForZimmetAtamaFormu.AutoSize = true;
            this.lblForZimmetAtamaFormu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForZimmetAtamaFormu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForZimmetAtamaFormu.Location = new System.Drawing.Point(25, 25);
            this.lblForZimmetAtamaFormu.Name = "lblForZimmetAtamaFormu";
            this.lblForZimmetAtamaFormu.Size = new System.Drawing.Size(235, 18);
            this.lblForZimmetAtamaFormu.TabIndex = 20;
            this.lblForZimmetAtamaFormu.Text = "Zimmet Atama veya İptal Etme";
            // 
            // radioBtnKisiyeAta
            // 
            this.radioBtnKisiyeAta.AutoSize = true;
            this.radioBtnKisiyeAta.Checked = true;
            this.radioBtnKisiyeAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnKisiyeAta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioBtnKisiyeAta.Location = new System.Drawing.Point(6, 55);
            this.radioBtnKisiyeAta.Name = "radioBtnKisiyeAta";
            this.radioBtnKisiyeAta.Size = new System.Drawing.Size(145, 22);
            this.radioBtnKisiyeAta.TabIndex = 24;
            this.radioBtnKisiyeAta.TabStop = true;
            this.radioBtnKisiyeAta.Text = "Kişiye Zimmetle";
            this.radioBtnKisiyeAta.UseVisualStyleBackColor = true;
            this.radioBtnKisiyeAta.CheckedChanged += new System.EventHandler(this.KimeSecimi);
            // 
            // radioBtnDepoyaAl
            // 
            this.radioBtnDepoyaAl.AutoSize = true;
            this.radioBtnDepoyaAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnDepoyaAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioBtnDepoyaAl.Location = new System.Drawing.Point(6, 23);
            this.radioBtnDepoyaAl.Name = "radioBtnDepoyaAl";
            this.radioBtnDepoyaAl.Size = new System.Drawing.Size(102, 22);
            this.radioBtnDepoyaAl.TabIndex = 23;
            this.radioBtnDepoyaAl.Text = "Depoya Al";
            this.radioBtnDepoyaAl.UseVisualStyleBackColor = true;
            this.radioBtnDepoyaAl.CheckedChanged += new System.EventHandler(this.KimeSecimi);
            // 
            // radioBtnAtigaAl
            // 
            this.radioBtnAtigaAl.AutoSize = true;
            this.radioBtnAtigaAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnAtigaAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioBtnAtigaAl.Location = new System.Drawing.Point(6, 90);
            this.radioBtnAtigaAl.Name = "radioBtnAtigaAl";
            this.radioBtnAtigaAl.Size = new System.Drawing.Size(124, 22);
            this.radioBtnAtigaAl.TabIndex = 25;
            this.radioBtnAtigaAl.Text = "Atığa Gönder";
            this.radioBtnAtigaAl.UseVisualStyleBackColor = true;
            this.radioBtnAtigaAl.CheckedChanged += new System.EventHandler(this.KimeSecimi);
            // 
            // btnKisiSecKime
            // 
            this.btnKisiSecKime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnKisiSecKime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiSecKime.Location = new System.Drawing.Point(161, 52);
            this.btnKisiSecKime.Name = "btnKisiSecKime";
            this.btnKisiSecKime.Size = new System.Drawing.Size(102, 29);
            this.btnKisiSecKime.TabIndex = 31;
            this.btnKisiSecKime.Text = "Kişi Seç";
            this.btnKisiSecKime.UseVisualStyleBackColor = true;
            this.btnKisiSecKime.Click += new System.EventHandler(this.btnKisiSecKime_Click);
            // 
            // dgVZimmetliUrunler
            // 
            this.dgVZimmetliUrunler.AllowUserToAddRows = false;
            this.dgVZimmetliUrunler.AllowUserToDeleteRows = false;
            this.dgVZimmetliUrunler.AutoGenerateColumns = false;
            this.dgVZimmetliUrunler.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVZimmetliUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVZimmetliUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVZimmetliUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokIDDataGridViewTextBoxColumn,
            this.stokDurumIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.personelIDDataGridViewTextBoxColumn,
            this.depIDDataGridViewTextBoxColumn});
            this.dgVZimmetliUrunler.DataSource = this.zimmetliStockViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVZimmetliUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgVZimmetliUrunler.Location = new System.Drawing.Point(374, 25);
            this.dgVZimmetliUrunler.Name = "dgVZimmetliUrunler";
            this.dgVZimmetliUrunler.ReadOnly = true;
            this.dgVZimmetliUrunler.RowHeadersVisible = false;
            this.dgVZimmetliUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVZimmetliUrunler.Size = new System.Drawing.Size(600, 233);
            this.dgVZimmetliUrunler.TabIndex = 32;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UrunIsim";
            this.dataGridViewTextBoxColumn1.HeaderText = "Urun Isim";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 275;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kategori";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kategori";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marka";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marka";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PerIsim";
            this.dataGridViewTextBoxColumn4.HeaderText = "PerIsim";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PerSoyisim";
            this.dataGridViewTextBoxColumn5.HeaderText = "PerSoyisim";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Visible = false;
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
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblZimmetSonuc
            // 
            this.lblZimmetSonuc.AutoSize = true;
            this.lblZimmetSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZimmetSonuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZimmetSonuc.Location = new System.Drawing.Point(796, 278);
            this.lblZimmetSonuc.Name = "lblZimmetSonuc";
            this.lblZimmetSonuc.Size = new System.Drawing.Size(178, 18);
            this.lblZimmetSonuc.TabIndex = 36;
            this.lblZimmetSonuc.Text = "Zimmet Atama Sonucu";
            // 
            // groupBoxKimden
            // 
            this.groupBoxKimden.Controls.Add(this.lblKimden);
            this.groupBoxKimden.Controls.Add(this.btnKisiSecKimden);
            this.groupBoxKimden.Controls.Add(this.radioBtnDepodanAl);
            this.groupBoxKimden.Controls.Add(this.radioBtnKisidenAl);
            this.groupBoxKimden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKimden.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxKimden.Location = new System.Drawing.Point(28, 61);
            this.groupBoxKimden.Name = "groupBoxKimden";
            this.groupBoxKimden.Size = new System.Drawing.Size(340, 128);
            this.groupBoxKimden.TabIndex = 37;
            this.groupBoxKimden.TabStop = false;
            this.groupBoxKimden.Text = "Kimden Alıncak";
            // 
            // lblKimden
            // 
            this.lblKimden.AutoSize = true;
            this.lblKimden.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKimden.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblKimden.Location = new System.Drawing.Point(8, 101);
            this.lblKimden.Name = "lblKimden";
            this.lblKimden.Size = new System.Drawing.Size(75, 18);
            this.lblKimden.TabIndex = 37;
            this.lblKimden.Text = "Depodan";
            // 
            // btnKisiSecKimden
            // 
            this.btnKisiSecKimden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnKisiSecKimden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiSecKimden.Location = new System.Drawing.Point(167, 53);
            this.btnKisiSecKimden.Name = "btnKisiSecKimden";
            this.btnKisiSecKimden.Size = new System.Drawing.Size(97, 28);
            this.btnKisiSecKimden.TabIndex = 36;
            this.btnKisiSecKimden.Text = "Kişi Seç";
            this.btnKisiSecKimden.UseVisualStyleBackColor = true;
            this.btnKisiSecKimden.Visible = false;
            this.btnKisiSecKimden.Click += new System.EventHandler(this.btnKisiSecKimden_Click);
            // 
            // radioBtnDepodanAl
            // 
            this.radioBtnDepodanAl.AutoSize = true;
            this.radioBtnDepodanAl.Checked = true;
            this.radioBtnDepodanAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnDepodanAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioBtnDepodanAl.Location = new System.Drawing.Point(20, 21);
            this.radioBtnDepodanAl.Name = "radioBtnDepodanAl";
            this.radioBtnDepodanAl.Size = new System.Drawing.Size(112, 22);
            this.radioBtnDepodanAl.TabIndex = 34;
            this.radioBtnDepodanAl.TabStop = true;
            this.radioBtnDepodanAl.Text = "Depodan Al";
            this.radioBtnDepodanAl.UseVisualStyleBackColor = true;
            this.radioBtnDepodanAl.CheckedChanged += new System.EventHandler(this.KimdenSecimi);
            // 
            // radioBtnKisidenAl
            // 
            this.radioBtnKisidenAl.AutoSize = true;
            this.radioBtnKisidenAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnKisidenAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioBtnKisidenAl.Location = new System.Drawing.Point(20, 56);
            this.radioBtnKisidenAl.Name = "radioBtnKisidenAl";
            this.radioBtnKisidenAl.Size = new System.Drawing.Size(100, 22);
            this.radioBtnKisidenAl.TabIndex = 35;
            this.radioBtnKisidenAl.Text = "Kişiden Al";
            this.radioBtnKisidenAl.UseVisualStyleBackColor = true;
            this.radioBtnKisidenAl.CheckedChanged += new System.EventHandler(this.KimdenSecimi);
            // 
            // groupBoxKime
            // 
            this.groupBoxKime.Controls.Add(this.lblKime);
            this.groupBoxKime.Controls.Add(this.radioBtnDepoyaAl);
            this.groupBoxKime.Controls.Add(this.radioBtnKisiyeAta);
            this.groupBoxKime.Controls.Add(this.btnKisiSecKime);
            this.groupBoxKime.Controls.Add(this.radioBtnAtigaAl);
            this.groupBoxKime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxKime.Location = new System.Drawing.Point(28, 290);
            this.groupBoxKime.Name = "groupBoxKime";
            this.groupBoxKime.Size = new System.Drawing.Size(274, 154);
            this.groupBoxKime.TabIndex = 38;
            this.groupBoxKime.TabStop = false;
            this.groupBoxKime.Text = "Kime Verilecek";
            // 
            // lblKime
            // 
            this.lblKime.AutoSize = true;
            this.lblKime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKime.ForeColor = System.Drawing.Color.Red;
            this.lblKime.Location = new System.Drawing.Point(9, 130);
            this.lblKime.Name = "lblKime";
            this.lblKime.Size = new System.Drawing.Size(109, 18);
            this.lblKime.TabIndex = 38;
            this.lblKime.Text = "Kişi seçiniz...";
            // 
            // btnZimmetAta
            // 
            this.btnZimmetAta.BackgroundImage = global::OdevTeslim.Properties.Resources.greenArrow;
            this.btnZimmetAta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZimmetAta.FlatAppearance.BorderSize = 3;
            this.btnZimmetAta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnZimmetAta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZimmetAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetAta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZimmetAta.Location = new System.Drawing.Point(122, 205);
            this.btnZimmetAta.Name = "btnZimmetAta";
            this.btnZimmetAta.Size = new System.Drawing.Size(76, 64);
            this.btnZimmetAta.TabIndex = 34;
            this.btnZimmetAta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnZimmetAta.UseVisualStyleBackColor = true;
            this.btnZimmetAta.Click += new System.EventHandler(this.btnZimmetAta_Click);
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRaporAl.Location = new System.Drawing.Point(809, 373);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(165, 64);
            this.btnRaporAl.TabIndex = 45;
            this.btnRaporAl.Text = "Zimmet Tutanağı";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // zimmetliStockViewTableAdapter
            // 
            this.zimmetliStockViewTableAdapter.ClearBeforeFill = true;
            // 
            // dgVZimmetSonucu
            // 
            this.dgVZimmetSonucu.AllowUserToAddRows = false;
            this.dgVZimmetSonucu.AllowUserToDeleteRows = false;
            this.dgVZimmetSonucu.AutoGenerateColumns = false;
            this.dgVZimmetSonucu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVZimmetSonucu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.fadDataGridViewTextBoxColumn,
            this.fsoyadDataGridViewTextBoxColumn,
            this.stokHareketTipDataGridViewTextBoxColumn,
            this.tadDataGridViewTextBoxColumn,
            this.tsoyadDataGridViewTextBoxColumn,
            this.stokIDDataGridViewTextBoxColumn1,
            this.stokHareketIDDataGridViewTextBoxColumn,
            this.perIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.stokHareketTipiIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9});
            this.dgVZimmetSonucu.DataSource = this.zimmetViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVZimmetSonucu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgVZimmetSonucu.Location = new System.Drawing.Point(308, 310);
            this.dgVZimmetSonucu.Name = "dgVZimmetSonucu";
            this.dgVZimmetSonucu.ReadOnly = true;
            this.dgVZimmetSonucu.RowHeadersVisible = false;
            this.dgVZimmetSonucu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVZimmetSonucu.Size = new System.Drawing.Size(666, 47);
            this.dgVZimmetSonucu.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tarih";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 65;
            // 
            // fadDataGridViewTextBoxColumn
            // 
            this.fadDataGridViewTextBoxColumn.DataPropertyName = "Fad";
            this.fadDataGridViewTextBoxColumn.HeaderText = "Teslim";
            this.fadDataGridViewTextBoxColumn.Name = "fadDataGridViewTextBoxColumn";
            this.fadDataGridViewTextBoxColumn.ReadOnly = true;
            this.fadDataGridViewTextBoxColumn.Width = 75;
            // 
            // fsoyadDataGridViewTextBoxColumn
            // 
            this.fsoyadDataGridViewTextBoxColumn.DataPropertyName = "Fsoyad";
            this.fsoyadDataGridViewTextBoxColumn.HeaderText = "Eden";
            this.fsoyadDataGridViewTextBoxColumn.Name = "fsoyadDataGridViewTextBoxColumn";
            this.fsoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.fsoyadDataGridViewTextBoxColumn.Width = 75;
            // 
            // stokHareketTipDataGridViewTextBoxColumn
            // 
            this.stokHareketTipDataGridViewTextBoxColumn.DataPropertyName = "StokHareketTip";
            this.stokHareketTipDataGridViewTextBoxColumn.HeaderText = "StokHareketTip";
            this.stokHareketTipDataGridViewTextBoxColumn.Name = "stokHareketTipDataGridViewTextBoxColumn";
            this.stokHareketTipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tadDataGridViewTextBoxColumn
            // 
            this.tadDataGridViewTextBoxColumn.DataPropertyName = "Tad";
            this.tadDataGridViewTextBoxColumn.HeaderText = "Teslim";
            this.tadDataGridViewTextBoxColumn.Name = "tadDataGridViewTextBoxColumn";
            this.tadDataGridViewTextBoxColumn.ReadOnly = true;
            this.tadDataGridViewTextBoxColumn.Width = 75;
            // 
            // tsoyadDataGridViewTextBoxColumn
            // 
            this.tsoyadDataGridViewTextBoxColumn.DataPropertyName = "Tsoyad";
            this.tsoyadDataGridViewTextBoxColumn.HeaderText = "Alan";
            this.tsoyadDataGridViewTextBoxColumn.Name = "tsoyadDataGridViewTextBoxColumn";
            this.tsoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.tsoyadDataGridViewTextBoxColumn.Width = 75;
            // 
            // stokIDDataGridViewTextBoxColumn1
            // 
            this.stokIDDataGridViewTextBoxColumn1.DataPropertyName = "StokID";
            this.stokIDDataGridViewTextBoxColumn1.HeaderText = "StokID";
            this.stokIDDataGridViewTextBoxColumn1.Name = "stokIDDataGridViewTextBoxColumn1";
            this.stokIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stokIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // stokHareketIDDataGridViewTextBoxColumn
            // 
            this.stokHareketIDDataGridViewTextBoxColumn.DataPropertyName = "StokHareketID";
            this.stokHareketIDDataGridViewTextBoxColumn.HeaderText = "StokHareketID";
            this.stokHareketIDDataGridViewTextBoxColumn.Name = "stokHareketIDDataGridViewTextBoxColumn";
            this.stokHareketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokHareketIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PerIsim";
            this.dataGridViewTextBoxColumn7.HeaderText = "PerIsim";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PerSoyisim";
            this.dataGridViewTextBoxColumn8.HeaderText = "PerSoyisim";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // stokHareketTipiIDDataGridViewTextBoxColumn
            // 
            this.stokHareketTipiIDDataGridViewTextBoxColumn.DataPropertyName = "StokHareketTipiID";
            this.stokHareketTipiIDDataGridViewTextBoxColumn.HeaderText = "StokHareketTipiID";
            this.stokHareketTipiIDDataGridViewTextBoxColumn.Name = "stokHareketTipiIDDataGridViewTextBoxColumn";
            this.stokHareketTipiIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokHareketTipiIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UrunIsim";
            this.dataGridViewTextBoxColumn9.HeaderText = "UrunIsim";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 175;
            // 
            // zimmetViewBindingSource
            // 
            this.zimmetViewBindingSource.DataMember = "ZimmetView";
            this.zimmetViewBindingSource.DataSource = this.zimmetTutanagiDataSet;
            // 
            // zimmetTutanagiDataSet
            // 
            this.zimmetTutanagiDataSet.DataSetName = "ZimmetTutanagiDataSet";
            this.zimmetTutanagiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zimmetViewTableAdapter
            // 
            this.zimmetViewTableAdapter.ClearBeforeFill = true;
            // 
            // ZimmetDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(994, 472);
            this.Controls.Add(this.dgVZimmetSonucu);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.groupBoxKime);
            this.Controls.Add(this.groupBoxKimden);
            this.Controls.Add(this.lblZimmetSonuc);
            this.Controls.Add(this.btnZimmetAta);
            this.Controls.Add(this.dgVZimmetliUrunler);
            this.Controls.Add(this.lblForZimmetAtamaFormu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZimmetDuzenleForm";
            this.Text = "ZimmetDuzenleForm";
            this.Load += new System.EventHandler(this.ZimmetDuzenleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVZimmetliUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetliStockViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            this.groupBoxKimden.ResumeLayout(false);
            this.groupBoxKimden.PerformLayout();
            this.groupBoxKime.ResumeLayout(false);
            this.groupBoxKime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVZimmetSonucu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetTutanagiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblForZimmetAtamaFormu;
        private System.Windows.Forms.RadioButton radioBtnKisiyeAta;
        private System.Windows.Forms.RadioButton radioBtnDepoyaAl;
        private System.Windows.Forms.RadioButton radioBtnAtigaAl;
        private System.Windows.Forms.Button btnKisiSecKime;
        private System.Windows.Forms.DataGridView dgVZimmetliUrunler;
        private System.Windows.Forms.Button btnZimmetAta;
        private System.Windows.Forms.Label lblZimmetSonuc;
        private System.Windows.Forms.GroupBox groupBoxKimden;
        private System.Windows.Forms.Button btnKisiSecKimden;
        private System.Windows.Forms.RadioButton radioBtnDepodanAl;
        private System.Windows.Forms.RadioButton radioBtnKisidenAl;
        private System.Windows.Forms.GroupBox groupBoxKime;
        private System.Windows.Forms.Label lblKimden;
        private System.Windows.Forms.Label lblKime;
        private System.Windows.Forms.DataGridViewTextBoxColumn zimmetliIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perDepIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private Datasets.ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource zimmetliStockViewBindingSource;
        private Datasets.ProjeDataSetiTableAdapters.ZimmetliStockViewTableAdapter zimmetliStockViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDurumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgVZimmetSonucu;
        private ZimmetTutanagiDataSet zimmetTutanagiDataSet;
        private System.Windows.Forms.BindingSource zimmetViewBindingSource;
        private Datasets.ZimmetTutanagiDataSetTableAdapters.ZimmetViewTableAdapter zimmetViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn fadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokHareketTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokHareketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokHareketTipiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}