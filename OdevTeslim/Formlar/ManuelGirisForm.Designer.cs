using OdevTeslim.Datasets;

namespace OdevTeslim.Formlar
{
    partial class ManuelGirisForm
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
            this.lblForManuelGirisForm = new System.Windows.Forms.Label();
            this.lblForDepartmaEkleme = new System.Windows.Forms.Label();
            this.lblForPersonelEkleme = new System.Windows.Forms.Label();
            this.btnDepartmanEkle = new System.Windows.Forms.Button();
            this.lblDepartmanEkleme = new System.Windows.Forms.Label();
            this.txBxDepartmanAd = new System.Windows.Forms.TextBox();
            this.txBxAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txBxTelefon = new System.Windows.Forms.TextBox();
            this.txBxSoyad = new System.Windows.Forms.TextBox();
            this.txBxAdres = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.comBxDepartman = new System.Windows.Forms.ComboBox();
            this.btnMetroFrameWork = new System.Windows.Forms.Button();
            this.projeDataSeti = new OdevTeslim.Datasets.ProjeDataSeti();
            this.departmanTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmanTBLTableAdapter1 = new OdevTeslim.Datasets.ProjeDataSetiTableAdapters.DepartmanTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanTBLBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForManuelGirisForm
            // 
            this.lblForManuelGirisForm.AutoSize = true;
            this.lblForManuelGirisForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForManuelGirisForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForManuelGirisForm.Location = new System.Drawing.Point(25, 25);
            this.lblForManuelGirisForm.Name = "lblForManuelGirisForm";
            this.lblForManuelGirisForm.Size = new System.Drawing.Size(129, 20);
            this.lblForManuelGirisForm.TabIndex = 6;
            this.lblForManuelGirisForm.Text = "Manuel Girişler";
            // 
            // lblForDepartmaEkleme
            // 
            this.lblForDepartmaEkleme.AutoSize = true;
            this.lblForDepartmaEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForDepartmaEkleme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForDepartmaEkleme.Location = new System.Drawing.Point(159, 79);
            this.lblForDepartmaEkleme.Name = "lblForDepartmaEkleme";
            this.lblForDepartmaEkleme.Size = new System.Drawing.Size(151, 18);
            this.lblForDepartmaEkleme.TabIndex = 7;
            this.lblForDepartmaEkleme.Text = "Departman Ekleme";
            // 
            // lblForPersonelEkleme
            // 
            this.lblForPersonelEkleme.AutoSize = true;
            this.lblForPersonelEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForPersonelEkleme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForPersonelEkleme.Location = new System.Drawing.Point(612, 79);
            this.lblForPersonelEkleme.Name = "lblForPersonelEkleme";
            this.lblForPersonelEkleme.Size = new System.Drawing.Size(206, 18);
            this.lblForPersonelEkleme.TabIndex = 10;
            this.lblForPersonelEkleme.Text = "Personel bilgilerini giriniz :";
            // 
            // btnDepartmanEkle
            // 
            this.btnDepartmanEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDepartmanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnDepartmanEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDepartmanEkle.Location = new System.Drawing.Point(116, 203);
            this.btnDepartmanEkle.Name = "btnDepartmanEkle";
            this.btnDepartmanEkle.Size = new System.Drawing.Size(236, 46);
            this.btnDepartmanEkle.TabIndex = 5;
            this.btnDepartmanEkle.Text = "Departman Ekle";
            this.btnDepartmanEkle.UseVisualStyleBackColor = true;
            this.btnDepartmanEkle.Click += new System.EventHandler(this.btnDepartmanEkle_Click);
            // 
            // lblDepartmanEkleme
            // 
            this.lblDepartmanEkleme.AutoSize = true;
            this.lblDepartmanEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmanEkleme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartmanEkleme.Location = new System.Drawing.Point(146, 123);
            this.lblDepartmanEkleme.Name = "lblDepartmanEkleme";
            this.lblDepartmanEkleme.Size = new System.Drawing.Size(177, 18);
            this.lblDepartmanEkleme.TabIndex = 8;
            this.lblDepartmanEkleme.Text = "Departman adı giriniz :";
            // 
            // txBxDepartmanAd
            // 
            this.txBxDepartmanAd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxDepartmanAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxDepartmanAd.Location = new System.Drawing.Point(116, 159);
            this.txBxDepartmanAd.Name = "txBxDepartmanAd";
            this.txBxDepartmanAd.Size = new System.Drawing.Size(236, 24);
            this.txBxDepartmanAd.TabIndex = 9;
            // 
            // txBxAd
            // 
            this.txBxAd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxAd.Location = new System.Drawing.Point(613, 123);
            this.txBxAd.Name = "txBxAd";
            this.txBxAd.Size = new System.Drawing.Size(236, 24);
            this.txBxAd.TabIndex = 11;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAd.Location = new System.Drawing.Point(573, 126);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(37, 18);
            this.lblAd.TabIndex = 17;
            this.lblAd.Text = "Ad :";
            // 
            // txBxTelefon
            // 
            this.txBxTelefon.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxTelefon.Location = new System.Drawing.Point(613, 200);
            this.txBxTelefon.Name = "txBxTelefon";
            this.txBxTelefon.Size = new System.Drawing.Size(236, 24);
            this.txBxTelefon.TabIndex = 13;
            // 
            // txBxSoyad
            // 
            this.txBxSoyad.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxSoyad.Location = new System.Drawing.Point(613, 159);
            this.txBxSoyad.Name = "txBxSoyad";
            this.txBxSoyad.Size = new System.Drawing.Size(236, 24);
            this.txBxSoyad.TabIndex = 12;
            // 
            // txBxAdres
            // 
            this.txBxAdres.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxAdres.Location = new System.Drawing.Point(613, 245);
            this.txBxAdres.Name = "txBxAdres";
            this.txBxAdres.Size = new System.Drawing.Size(236, 24);
            this.txBxAdres.TabIndex = 14;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSoyad.Location = new System.Drawing.Point(545, 167);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(65, 18);
            this.lblSoyad.TabIndex = 18;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefon.Location = new System.Drawing.Point(536, 203);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(74, 18);
            this.lblTelefon.TabIndex = 20;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdres.Location = new System.Drawing.Point(549, 248);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(61, 18);
            this.lblAdres.TabIndex = 21;
            this.lblAdres.Text = "Adres :";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPersonelEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonelEkle.Location = new System.Drawing.Point(613, 329);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(236, 47);
            this.btnPersonelEkle.TabIndex = 16;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartman.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepartman.Location = new System.Drawing.Point(510, 287);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(100, 18);
            this.lblDepartman.TabIndex = 19;
            this.lblDepartman.Text = "Departman :";
            // 
            // comBxDepartman
            // 
            this.comBxDepartman.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.comBxDepartman.DataSource = this.departmanTBLBindingSource1;
            this.comBxDepartman.DisplayMember = "DepIsim";
            this.comBxDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBxDepartman.FormattingEnabled = true;
            this.comBxDepartman.Location = new System.Drawing.Point(613, 286);
            this.comBxDepartman.Name = "comBxDepartman";
            this.comBxDepartman.Size = new System.Drawing.Size(236, 26);
            this.comBxDepartman.TabIndex = 15;
            this.comBxDepartman.ValueMember = "DepID";
            this.comBxDepartman.Visible = false;
            // 
            // btnMetroFrameWork
            // 
            this.btnMetroFrameWork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMetroFrameWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetroFrameWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnMetroFrameWork.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMetroFrameWork.Location = new System.Drawing.Point(116, 329);
            this.btnMetroFrameWork.Name = "btnMetroFrameWork";
            this.btnMetroFrameWork.Size = new System.Drawing.Size(236, 46);
            this.btnMetroFrameWork.TabIndex = 22;
            this.btnMetroFrameWork.Text = " Demo MetroFrameWork Formu Aç";
            this.btnMetroFrameWork.UseVisualStyleBackColor = true;
            this.btnMetroFrameWork.Click += new System.EventHandler(this.btnMetroFrameWork_Click);
            // 
            // projeDataSeti
            // 
            this.projeDataSeti.DataSetName = "ProjeDataSeti";
            this.projeDataSeti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmanTBLBindingSource1
            // 
            this.departmanTBLBindingSource1.DataMember = "DepartmanTBL";
            this.departmanTBLBindingSource1.DataSource = this.projeDataSeti;
            // 
            // departmanTBLTableAdapter1
            // 
            this.departmanTBLTableAdapter1.ClearBeforeFill = true;
            // 
            // ManuelGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(986, 472);
            this.Controls.Add(this.btnMetroFrameWork);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblDepartman);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.comBxDepartman);
            this.Controls.Add(this.txBxAdres);
            this.Controls.Add(this.txBxSoyad);
            this.Controls.Add(this.txBxTelefon);
            this.Controls.Add(this.txBxAd);
            this.Controls.Add(this.lblForPersonelEkleme);
            this.Controls.Add(this.txBxDepartmanAd);
            this.Controls.Add(this.lblDepartmanEkleme);
            this.Controls.Add(this.lblForDepartmaEkleme);
            this.Controls.Add(this.lblForManuelGirisForm);
            this.Controls.Add(this.btnDepartmanEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManuelGirisForm";
            this.Text = "ManuelGirisForm";
            this.Load += new System.EventHandler(this.ManuelGirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanTBLBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblForManuelGirisForm;
        private System.Windows.Forms.Label lblForDepartmaEkleme;
        private System.Windows.Forms.Label lblForPersonelEkleme;
        private System.Windows.Forms.Button btnDepartmanEkle;
        private System.Windows.Forms.Label lblDepartmanEkleme;
        private System.Windows.Forms.TextBox txBxDepartmanAd;
        private System.Windows.Forms.TextBox txBxAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txBxTelefon;
        private System.Windows.Forms.TextBox txBxSoyad;
        private System.Windows.Forms.TextBox txBxAdres;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.ComboBox comBxDepartman;
        private System.Windows.Forms.Button btnMetroFrameWork;
        private ProjeDataSeti projeDataSeti;
        private System.Windows.Forms.BindingSource departmanTBLBindingSource1;
        private Datasets.ProjeDataSetiTableAdapters.DepartmanTBLTableAdapter departmanTBLTableAdapter1;
    }
}