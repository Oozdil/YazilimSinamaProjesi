namespace OdevTeslim.Formlar
{
    partial class UrunTanımlaForm
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
            this.comBxMarka = new System.Windows.Forms.ComboBox();
            this.markaTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.lblMarka = new System.Windows.Forms.Label();
            this.comboBxKategori = new System.Windows.Forms.ComboBox();
            this.kategoriTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnyeniMarka = new System.Windows.Forms.Button();
            this.btnYeniKategori = new System.Windows.Forms.Button();
            this.linkLblClose = new System.Windows.Forms.LinkLabel();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txBxUrunAdi = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.markaTBLTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.MarkaTBLTableAdapter();
            this.kategoriTBLTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.KategoriTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.markaTBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTBLBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comBxMarka
            // 
            this.comBxMarka.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.comBxMarka.DataSource = this.markaTBLBindingSource1;
            this.comBxMarka.DisplayMember = "Marka";
            this.comBxMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBxMarka.FormattingEnabled = true;
            this.comBxMarka.Location = new System.Drawing.Point(34, 68);
            this.comBxMarka.Name = "comBxMarka";
            this.comBxMarka.Size = new System.Drawing.Size(244, 26);
            this.comBxMarka.TabIndex = 34;
            this.comBxMarka.ValueMember = "MarkaID";
            // 
            // markaTBLBindingSource1
            // 
            this.markaTBLBindingSource1.DataMember = "MarkaTBL";
            this.markaTBLBindingSource1.DataSource = this.projeDataSeti;
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarka.Location = new System.Drawing.Point(35, 44);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(65, 18);
            this.lblMarka.TabIndex = 35;
            this.lblMarka.Text = "Marka :";
            // 
            // comboBxKategori
            // 
            this.comboBxKategori.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.comboBxKategori.DataSource = this.kategoriTBLBindingSource1;
            this.comboBxKategori.DisplayMember = "Kategori";
            this.comboBxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBxKategori.FormattingEnabled = true;
            this.comboBxKategori.Location = new System.Drawing.Point(34, 140);
            this.comboBxKategori.Name = "comboBxKategori";
            this.comboBxKategori.Size = new System.Drawing.Size(244, 26);
            this.comboBxKategori.TabIndex = 36;
            this.comboBxKategori.ValueMember = "KategoriID";
            // 
            // kategoriTBLBindingSource1
            // 
            this.kategoriTBLBindingSource1.DataMember = "KategoriTBL";
            this.kategoriTBLBindingSource1.DataSource = this.projeDataSeti;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKategori.Location = new System.Drawing.Point(35, 116);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(81, 18);
            this.lblKategori.TabIndex = 37;
            this.lblKategori.Text = "Kategori :";
            // 
            // btnyeniMarka
            // 
            this.btnyeniMarka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnyeniMarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyeniMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyeniMarka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnyeniMarka.Location = new System.Drawing.Point(319, 57);
            this.btnyeniMarka.Name = "btnyeniMarka";
            this.btnyeniMarka.Size = new System.Drawing.Size(101, 49);
            this.btnyeniMarka.TabIndex = 38;
            this.btnyeniMarka.Text = "Yeni Marka";
            this.btnyeniMarka.UseVisualStyleBackColor = true;
            this.btnyeniMarka.Click += new System.EventHandler(this.btnyeniMarka_Click);
            // 
            // btnYeniKategori
            // 
            this.btnYeniKategori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnYeniKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYeniKategori.Location = new System.Drawing.Point(319, 129);
            this.btnYeniKategori.Name = "btnYeniKategori";
            this.btnYeniKategori.Size = new System.Drawing.Size(101, 49);
            this.btnYeniKategori.TabIndex = 39;
            this.btnYeniKategori.Text = "Yeni Kategori";
            this.btnYeniKategori.UseVisualStyleBackColor = true;
            this.btnYeniKategori.Click += new System.EventHandler(this.btnYeniKategori_Click);
            // 
            // linkLblClose
            // 
            this.linkLblClose.AutoSize = true;
            this.linkLblClose.BackColor = System.Drawing.Color.Transparent;
            this.linkLblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblClose.LinkColor = System.Drawing.Color.Red;
            this.linkLblClose.Location = new System.Drawing.Point(351, 330);
            this.linkLblClose.Name = "linkLblClose";
            this.linkLblClose.Size = new System.Drawing.Size(69, 20);
            this.linkLblClose.TabIndex = 44;
            this.linkLblClose.TabStop = true;
            this.linkLblClose.Text = "Vazgeç";
            this.linkLblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblClose_LinkClicked);
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUrunAdi.Location = new System.Drawing.Point(35, 199);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(81, 18);
            this.lblUrunAdi.TabIndex = 43;
            this.lblUrunAdi.Text = "Ürün adı :";
            // 
            // txBxUrunAdi
            // 
            this.txBxUrunAdi.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxUrunAdi.Location = new System.Drawing.Point(35, 223);
            this.txBxUrunAdi.Multiline = true;
            this.txBxUrunAdi.Name = "txBxUrunAdi";
            this.txBxUrunAdi.Size = new System.Drawing.Size(385, 86);
            this.txBxUrunAdi.TabIndex = 42;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunEkle.Location = new System.Drawing.Point(35, 324);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(243, 33);
            this.btnUrunEkle.TabIndex = 45;
            this.btnUrunEkle.Text = "Yeni Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // markaTBLTableAdapter1
            // 
            this.markaTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // kategoriTBLTableAdapter1
            // 
            this.kategoriTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // UrunTanımlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(450, 390);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.linkLblClose);
            this.Controls.Add(this.txBxUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.btnYeniKategori);
            this.Controls.Add(this.btnyeniMarka);
            this.Controls.Add(this.comboBxKategori);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.comBxMarka);
            this.Controls.Add(this.lblMarka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunTanımlaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunTanımlaForm";
            this.Load += new System.EventHandler(this.UrunTanımlaForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UrunTanımlaForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.markaTBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriTBLBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBxMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.ComboBox comboBxKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnyeniMarka;
        private System.Windows.Forms.Button btnYeniKategori;
        private System.Windows.Forms.LinkLabel linkLblClose;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txBxUrunAdi;
        private System.Windows.Forms.Button btnUrunEkle;
        private Datasets.ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource markaTBLBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.MarkaTBLTableAdapter markaTBLTableAdapter1;
        private System.Windows.Forms.BindingSource kategoriTBLBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.KategoriTBLTableAdapter kategoriTBLTableAdapter1;
    }
}