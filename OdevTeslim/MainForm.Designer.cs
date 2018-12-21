namespace OdevTeslim
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBxMiniLogo1 = new System.Windows.Forms.PictureBox();
            this.picBxMiniLogo3 = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblWriterInfo = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblAppInfo = new System.Windows.Forms.Label();
            this.picBxMiniLogo2 = new System.Windows.Forms.PictureBox();
            this.timerWelcome = new System.Windows.Forms.Timer(this.components);
            this.btnZimmetKisi = new System.Windows.Forms.Button();
            this.btnZimmetDepartman = new System.Windows.Forms.Button();
            this.btnSatinAlma = new System.Windows.Forms.Button();
            this.btnKullaniciIslemleri = new System.Windows.Forms.Button();
            this.btnManuelGirisler = new System.Windows.Forms.Button();
            this.btnZimmetIslemleri = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMiniLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMiniLogo3)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMiniLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.picBxMiniLogo1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(8, 10, 8, 6);
            this.pnlHeader.Size = new System.Drawing.Size(1200, 58);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(81, 21);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(52, 18);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(968, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 42);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1080, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Kapat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBxMiniLogo1
            // 
            this.picBxMiniLogo1.BackColor = System.Drawing.Color.Transparent;
            this.picBxMiniLogo1.BackgroundImage = global::OdevTeslim.Properties.Resources.uni_logo_sm;
            this.picBxMiniLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxMiniLogo1.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBxMiniLogo1.Location = new System.Drawing.Point(8, 10);
            this.picBxMiniLogo1.Margin = new System.Windows.Forms.Padding(4);
            this.picBxMiniLogo1.Name = "picBxMiniLogo1";
            this.picBxMiniLogo1.Size = new System.Drawing.Size(64, 42);
            this.picBxMiniLogo1.TabIndex = 3;
            this.picBxMiniLogo1.TabStop = false;
            // 
            // picBxMiniLogo3
            // 
            this.picBxMiniLogo3.BackColor = System.Drawing.Color.Transparent;
            this.picBxMiniLogo3.BackgroundImage = global::OdevTeslim.Properties.Resources.uni_logo_sm;
            this.picBxMiniLogo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxMiniLogo3.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBxMiniLogo3.Location = new System.Drawing.Point(1128, 6);
            this.picBxMiniLogo3.Margin = new System.Windows.Forms.Padding(4);
            this.picBxMiniLogo3.Name = "picBxMiniLogo3";
            this.picBxMiniLogo3.Size = new System.Drawing.Size(64, 42);
            this.picBxMiniLogo3.TabIndex = 6;
            this.picBxMiniLogo3.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFooter.Controls.Add(this.lblWriterInfo);
            this.pnlFooter.Controls.Add(this.btnAbout);
            this.pnlFooter.Controls.Add(this.lblAppInfo);
            this.pnlFooter.Controls.Add(this.picBxMiniLogo3);
            this.pnlFooter.Controls.Add(this.picBxMiniLogo2);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 642);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(8, 6, 8, 10);
            this.pnlFooter.Size = new System.Drawing.Size(1200, 58);
            this.pnlFooter.TabIndex = 5;
            // 
            // lblWriterInfo
            // 
            this.lblWriterInfo.AutoSize = true;
            this.lblWriterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWriterInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWriterInfo.Location = new System.Drawing.Point(82, 31);
            this.lblWriterInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWriterInfo.Name = "lblWriterInfo";
            this.lblWriterInfo.Size = new System.Drawing.Size(47, 15);
            this.lblWriterInfo.TabIndex = 8;
            this.lblWriterInfo.Text = "label1";
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(1091, 6);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(37, 42);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "?";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblAppInfo
            // 
            this.lblAppInfo.AutoSize = true;
            this.lblAppInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppInfo.Location = new System.Drawing.Point(82, 9);
            this.lblAppInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppInfo.Name = "lblAppInfo";
            this.lblAppInfo.Size = new System.Drawing.Size(47, 15);
            this.lblAppInfo.TabIndex = 4;
            this.lblAppInfo.Text = "label1";
            // 
            // picBxMiniLogo2
            // 
            this.picBxMiniLogo2.BackColor = System.Drawing.Color.Transparent;
            this.picBxMiniLogo2.BackgroundImage = global::OdevTeslim.Properties.Resources.uni_logo_sm;
            this.picBxMiniLogo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxMiniLogo2.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBxMiniLogo2.Location = new System.Drawing.Point(8, 6);
            this.picBxMiniLogo2.Margin = new System.Windows.Forms.Padding(4);
            this.picBxMiniLogo2.Name = "picBxMiniLogo2";
            this.picBxMiniLogo2.Size = new System.Drawing.Size(64, 42);
            this.picBxMiniLogo2.TabIndex = 3;
            this.picBxMiniLogo2.TabStop = false;
            // 
            // timerWelcome
            // 
            this.timerWelcome.Enabled = true;
            this.timerWelcome.Interval = 1000;
            this.timerWelcome.Tick += new System.EventHandler(this.timerWelcome_Tick);
            // 
            // btnZimmetKisi
            // 
            this.btnZimmetKisi.BackColor = System.Drawing.Color.Transparent;
            this.btnZimmetKisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnZimmetKisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZimmetKisi.Location = new System.Drawing.Point(41, 134);
            this.btnZimmetKisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnZimmetKisi.Name = "btnZimmetKisi";
            this.btnZimmetKisi.Size = new System.Drawing.Size(141, 71);
            this.btnZimmetKisi.TabIndex = 6;
            this.btnZimmetKisi.Text = "Zimmet Görme Raporlama (Kişi)";
            this.btnZimmetKisi.UseVisualStyleBackColor = false;
            this.btnZimmetKisi.Click += new System.EventHandler(this.MenuSecim);
            // 
            // btnZimmetDepartman
            // 
            this.btnZimmetDepartman.BackColor = System.Drawing.Color.Transparent;
            this.btnZimmetDepartman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnZimmetDepartman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZimmetDepartman.Location = new System.Drawing.Point(41, 215);
            this.btnZimmetDepartman.Margin = new System.Windows.Forms.Padding(4);
            this.btnZimmetDepartman.Name = "btnZimmetDepartman";
            this.btnZimmetDepartman.Size = new System.Drawing.Size(141, 71);
            this.btnZimmetDepartman.TabIndex = 7;
            this.btnZimmetDepartman.Text = "Zimmet Görme  Raporlama (Departman)";
            this.btnZimmetDepartman.UseVisualStyleBackColor = false;
            this.btnZimmetDepartman.Click += new System.EventHandler(this.MenuSecim);
            // 
            // btnSatinAlma
            // 
            this.btnSatinAlma.BackColor = System.Drawing.Color.Transparent;
            this.btnSatinAlma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSatinAlma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatinAlma.Location = new System.Drawing.Point(41, 380);
            this.btnSatinAlma.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatinAlma.Name = "btnSatinAlma";
            this.btnSatinAlma.Size = new System.Drawing.Size(141, 71);
            this.btnSatinAlma.TabIndex = 8;
            this.btnSatinAlma.Text = "Satın Alma ve Stok Kontrol";
            this.btnSatinAlma.UseVisualStyleBackColor = false;
            this.btnSatinAlma.Click += new System.EventHandler(this.MenuSecim);
            // 
            // btnKullaniciIslemleri
            // 
            this.btnKullaniciIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.btnKullaniciIslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnKullaniciIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciIslemleri.Location = new System.Drawing.Point(41, 457);
            this.btnKullaniciIslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullaniciIslemleri.Name = "btnKullaniciIslemleri";
            this.btnKullaniciIslemleri.Size = new System.Drawing.Size(141, 71);
            this.btnKullaniciIslemleri.TabIndex = 9;
            this.btnKullaniciIslemleri.Text = "Kullanıcı Ekleme   Düzenleme";
            this.btnKullaniciIslemleri.UseVisualStyleBackColor = false;
            this.btnKullaniciIslemleri.Click += new System.EventHandler(this.MenuSecim);
            // 
            // btnManuelGirisler
            // 
            this.btnManuelGirisler.BackColor = System.Drawing.Color.Transparent;
            this.btnManuelGirisler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnManuelGirisler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManuelGirisler.Location = new System.Drawing.Point(41, 535);
            this.btnManuelGirisler.Margin = new System.Windows.Forms.Padding(4);
            this.btnManuelGirisler.Name = "btnManuelGirisler";
            this.btnManuelGirisler.Size = new System.Drawing.Size(141, 71);
            this.btnManuelGirisler.TabIndex = 10;
            this.btnManuelGirisler.Text = "Manuel Girişler***";
            this.btnManuelGirisler.UseVisualStyleBackColor = false;
            this.btnManuelGirisler.Click += new System.EventHandler(this.MenuSecim);
            // 
            // btnZimmetIslemleri
            // 
            this.btnZimmetIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.btnZimmetIslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnZimmetIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZimmetIslemleri.Location = new System.Drawing.Point(41, 301);
            this.btnZimmetIslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnZimmetIslemleri.Name = "btnZimmetIslemleri";
            this.btnZimmetIslemleri.Size = new System.Drawing.Size(141, 71);
            this.btnZimmetIslemleri.TabIndex = 11;
            this.btnZimmetIslemleri.Text = "Zimmet Atama Değiştirme";
            this.btnZimmetIslemleri.UseVisualStyleBackColor = false;
            this.btnZimmetIslemleri.Click += new System.EventHandler(this.MenuSecim);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(81, 94);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(60, 20);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "MENU";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppName.ForeColor = System.Drawing.Color.Transparent;
            this.lblAppName.Location = new System.Drawing.Point(505, 94);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(362, 24);
            this.lblAppName.TabIndex = 14;
            this.lblAppName.Text = "BİLGİSAYAR ZİMMET TAKİP SİSTEMİ";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContainer.Location = new System.Drawing.Point(202, 134);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(990, 472);
            this.pnlContainer.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OdevTeslim.Properties.Resources.bg_tulip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnZimmetIslemleri);
            this.Controls.Add(this.btnManuelGirisler);
            this.Controls.Add(this.btnKullaniciIslemleri);
            this.Controls.Add(this.btnSatinAlma);
            this.Controls.Add(this.btnZimmetDepartman);
            this.Controls.Add(this.btnZimmetKisi);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMiniLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMiniLogo3)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMiniLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picBxMiniLogo1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picBxMiniLogo3;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblAppInfo;
        private System.Windows.Forms.PictureBox picBxMiniLogo2;
        private System.Windows.Forms.Timer timerWelcome;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblWriterInfo;
        private System.Windows.Forms.Button btnZimmetKisi;
        private System.Windows.Forms.Button btnZimmetDepartman;
        private System.Windows.Forms.Button btnSatinAlma;
        private System.Windows.Forms.Button btnKullaniciIslemleri;
        private System.Windows.Forms.Button btnManuelGirisler;
        private System.Windows.Forms.Button btnZimmetIslemleri;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel pnlContainer;
    }
}

