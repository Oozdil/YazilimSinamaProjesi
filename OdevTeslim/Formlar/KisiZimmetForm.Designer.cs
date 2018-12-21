namespace OdevTeslim.Formlar
{
    partial class KisiZimmetForm
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
            this.lblKisiler = new System.Windows.Forms.Label();
            this.lblSeciliPersonel = new System.Windows.Forms.Label();
            this.dgVPersonelStok = new System.Windows.Forms.DataGridView();
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
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.lblForKisiZimmetForm = new System.Windows.Forms.Label();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.comBxDepartmanlar = new System.Windows.Forms.ComboBox();
            this.departmanTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDepartmanlar = new System.Windows.Forms.Label();
            this.dgVPersoneller = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perIsimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyisimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDepIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmanTBLTableAdapter = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.DepartmanTBLTableAdapter();
            this.personelTBLTableAdapter = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.PersonelTBLTableAdapter();
            this.zimmetliStockViewTableAdapter = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.ZimmetliStockViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgVPersonelStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetliStockViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKisiler
            // 
            this.lblKisiler.AutoSize = true;
            this.lblKisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisiler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKisiler.Location = new System.Drawing.Point(662, 71);
            this.lblKisiler.Name = "lblKisiler";
            this.lblKisiler.Size = new System.Drawing.Size(58, 20);
            this.lblKisiler.TabIndex = 35;
            this.lblKisiler.Text = "Kişiler :";
            // 
            // lblSeciliPersonel
            // 
            this.lblSeciliPersonel.AutoSize = true;
            this.lblSeciliPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeciliPersonel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeciliPersonel.Location = new System.Drawing.Point(24, 81);
            this.lblSeciliPersonel.Name = "lblSeciliPersonel";
            this.lblSeciliPersonel.Size = new System.Drawing.Size(196, 20);
            this.lblSeciliPersonel.TabIndex = 34;
            this.lblSeciliPersonel.Text = "Lürfen personel seçiniz. . . ";
            // 
            // dgVPersonelStok
            // 
            this.dgVPersonelStok.AllowUserToAddRows = false;
            this.dgVPersonelStok.AllowUserToDeleteRows = false;
            this.dgVPersonelStok.AutoGenerateColumns = false;
            this.dgVPersonelStok.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgVPersonelStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVPersonelStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokIDDataGridViewTextBoxColumn,
            this.stokDurumIDDataGridViewTextBoxColumn,
            this.urunIsimDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.perIsimDataGridViewTextBoxColumn,
            this.perSoyisimDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn,
            this.depIDDataGridViewTextBoxColumn});
            this.dgVPersonelStok.DataSource = this.zimmetliStockViewBindingSource;
            this.dgVPersonelStok.Location = new System.Drawing.Point(25, 116);
            this.dgVPersonelStok.Name = "dgVPersonelStok";
            this.dgVPersonelStok.ReadOnly = true;
            this.dgVPersonelStok.RowHeadersVisible = false;
            this.dgVPersonelStok.Size = new System.Drawing.Size(713, 344);
            this.dgVPersonelStok.TabIndex = 33;
            // 
            // stokIDDataGridViewTextBoxColumn
            // 
            this.stokIDDataGridViewTextBoxColumn.DataPropertyName = "StokID";
            this.stokIDDataGridViewTextBoxColumn.HeaderText = "StokID";
            this.stokIDDataGridViewTextBoxColumn.Name = "stokIDDataGridViewTextBoxColumn";
            this.stokIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.urunIsimDataGridViewTextBoxColumn.HeaderText = "UrunIsim";
            this.urunIsimDataGridViewTextBoxColumn.Name = "urunIsimDataGridViewTextBoxColumn";
            this.urunIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIsimDataGridViewTextBoxColumn.Width = 400;
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
            this.perIsimDataGridViewTextBoxColumn.HeaderText = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn.Name = "perIsimDataGridViewTextBoxColumn";
            this.perIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIsimDataGridViewTextBoxColumn.Visible = false;
            // 
            // perSoyisimDataGridViewTextBoxColumn
            // 
            this.perSoyisimDataGridViewTextBoxColumn.DataPropertyName = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn.HeaderText = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn.Name = "perSoyisimDataGridViewTextBoxColumn";
            this.perSoyisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.perSoyisimDataGridViewTextBoxColumn.Visible = false;
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
            // lblForKisiZimmetForm
            // 
            this.lblForKisiZimmetForm.AutoSize = true;
            this.lblForKisiZimmetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForKisiZimmetForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForKisiZimmetForm.Location = new System.Drawing.Point(25, 25);
            this.lblForKisiZimmetForm.Name = "lblForKisiZimmetForm";
            this.lblForKisiZimmetForm.Size = new System.Drawing.Size(196, 18);
            this.lblForKisiZimmetForm.TabIndex = 32;
            this.lblForKisiZimmetForm.Text = "Kişi Bazlı Zimmet Görme";
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRaporAl.Location = new System.Drawing.Point(471, 21);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(114, 81);
            this.btnRaporAl.TabIndex = 38;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // comBxDepartmanlar
            // 
            this.comBxDepartmanlar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.comBxDepartmanlar.DataSource = this.departmanTBLBindingSource;
            this.comBxDepartmanlar.DisplayMember = "DepIsim";
            this.comBxDepartmanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBxDepartmanlar.FormattingEnabled = true;
            this.comBxDepartmanlar.Location = new System.Drawing.Point(744, 21);
            this.comBxDepartmanlar.Name = "comBxDepartmanlar";
            this.comBxDepartmanlar.Size = new System.Drawing.Size(233, 26);
            this.comBxDepartmanlar.TabIndex = 40;
            this.comBxDepartmanlar.ValueMember = "DepID";
            this.comBxDepartmanlar.Visible = false;
            this.comBxDepartmanlar.SelectedIndexChanged += new System.EventHandler(this.comBxDepartmanlar_SelectedIndexChanged);
            // 
            // departmanTBLBindingSource
            // 
            this.departmanTBLBindingSource.DataMember = "DepartmanTBL";
            this.departmanTBLBindingSource.DataSource = this.projeDataSeti;
            // 
            // lblDepartmanlar
            // 
            this.lblDepartmanlar.AutoSize = true;
            this.lblDepartmanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmanlar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmanlar.Location = new System.Drawing.Point(606, 22);
            this.lblDepartmanlar.Name = "lblDepartmanlar";
            this.lblDepartmanlar.Size = new System.Drawing.Size(114, 20);
            this.lblDepartmanlar.TabIndex = 41;
            this.lblDepartmanlar.Text = "Departmanlar :";
            // 
            // dgVPersoneller
            // 
            this.dgVPersoneller.AllowUserToAddRows = false;
            this.dgVPersoneller.AllowUserToDeleteRows = false;
            this.dgVPersoneller.AutoGenerateColumns = false;
            this.dgVPersoneller.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgVPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVPersoneller.ColumnHeadersVisible = false;
            this.dgVPersoneller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perIsimDataGridViewTextBoxColumn1,
            this.perSoyisimDataGridViewTextBoxColumn1,
            this.perTelefonDataGridViewTextBoxColumn,
            this.perAdresDataGridViewTextBoxColumn,
            this.perDepIDDataGridViewTextBoxColumn1});
            this.dgVPersoneller.DataSource = this.personelTBLBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVPersoneller.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgVPersoneller.Location = new System.Drawing.Point(744, 53);
            this.dgVPersoneller.Name = "dgVPersoneller";
            this.dgVPersoneller.ReadOnly = true;
            this.dgVPersoneller.RowHeadersVisible = false;
            this.dgVPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVPersoneller.Size = new System.Drawing.Size(233, 407);
            this.dgVPersoneller.TabIndex = 42;
            this.dgVPersoneller.SelectionChanged += new System.EventHandler(this.dgVPersoneller_SelectionChanged);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIDDataGridViewTextBoxColumn.Width = 25;
            // 
            // perIsimDataGridViewTextBoxColumn1
            // 
            this.perIsimDataGridViewTextBoxColumn1.DataPropertyName = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn1.HeaderText = "PerIsim";
            this.perIsimDataGridViewTextBoxColumn1.Name = "perIsimDataGridViewTextBoxColumn1";
            this.perIsimDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // perSoyisimDataGridViewTextBoxColumn1
            // 
            this.perSoyisimDataGridViewTextBoxColumn1.DataPropertyName = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn1.HeaderText = "PerSoyisim";
            this.perSoyisimDataGridViewTextBoxColumn1.Name = "perSoyisimDataGridViewTextBoxColumn1";
            this.perSoyisimDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // perTelefonDataGridViewTextBoxColumn
            // 
            this.perTelefonDataGridViewTextBoxColumn.DataPropertyName = "PerTelefon";
            this.perTelefonDataGridViewTextBoxColumn.HeaderText = "PerTelefon";
            this.perTelefonDataGridViewTextBoxColumn.Name = "perTelefonDataGridViewTextBoxColumn";
            this.perTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.perTelefonDataGridViewTextBoxColumn.Visible = false;
            // 
            // perAdresDataGridViewTextBoxColumn
            // 
            this.perAdresDataGridViewTextBoxColumn.DataPropertyName = "PerAdres";
            this.perAdresDataGridViewTextBoxColumn.HeaderText = "PerAdres";
            this.perAdresDataGridViewTextBoxColumn.Name = "perAdresDataGridViewTextBoxColumn";
            this.perAdresDataGridViewTextBoxColumn.ReadOnly = true;
            this.perAdresDataGridViewTextBoxColumn.Visible = false;
            // 
            // perDepIDDataGridViewTextBoxColumn1
            // 
            this.perDepIDDataGridViewTextBoxColumn1.DataPropertyName = "PerDepID";
            this.perDepIDDataGridViewTextBoxColumn1.HeaderText = "PerDepID";
            this.perDepIDDataGridViewTextBoxColumn1.Name = "perDepIDDataGridViewTextBoxColumn1";
            this.perDepIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.perDepIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // personelTBLBindingSource
            // 
            this.personelTBLBindingSource.DataMember = "PersonelTBL";
            this.personelTBLBindingSource.DataSource = this.projeDataSeti;
            // 
            // departmanTBLTableAdapter
            // 
            this.departmanTBLTableAdapter.ClearBeforeFill = true;
            // 
            // personelTBLTableAdapter
            // 
            this.personelTBLTableAdapter.ClearBeforeFill = true;
            // 
            // zimmetliStockViewTableAdapter
            // 
            this.zimmetliStockViewTableAdapter.ClearBeforeFill = true;
            // 
            // KisiZimmetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(997, 480);
            this.Controls.Add(this.dgVPersoneller);
            this.Controls.Add(this.lblDepartmanlar);
            this.Controls.Add(this.comBxDepartmanlar);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.lblKisiler);
            this.Controls.Add(this.lblSeciliPersonel);
            this.Controls.Add(this.dgVPersonelStok);
            this.Controls.Add(this.lblForKisiZimmetForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KisiZimmetForm";
            this.Text = "KisiZimmetForm";
            this.Load += new System.EventHandler(this.KisiZimmetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVPersonelStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zimmetliStockViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKisiler;
        private System.Windows.Forms.Label lblSeciliPersonel;
        private System.Windows.Forms.DataGridView dgVPersonelStok;
        private System.Windows.Forms.Label lblForKisiZimmetForm;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.ComboBox comBxDepartmanlar;
        private System.Windows.Forms.Label lblDepartmanlar;
        private Datasets.ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource departmanTBLBindingSource;
        private Datasets.ProjeDataSetiTableAdapters.DepartmanTBLTableAdapter departmanTBLTableAdapter;
        private System.Windows.Forms.DataGridView dgVPersoneller;
        private System.Windows.Forms.BindingSource personelTBLBindingSource;
        private Datasets.ProjeDataSetiTableAdapters.PersonelTBLTableAdapter personelTBLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIsimDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyisimDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perDepIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zimmetliIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perDepIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
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
    }
}