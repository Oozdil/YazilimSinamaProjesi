namespace OdevTeslim
{
    partial class LoginForm
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
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.lblUniName = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.txBxuserName = new System.Windows.Forms.TextBox();
            this.txBxPassWord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLblClose = new System.Windows.Forms.LinkLabel();
            this.lblUserNamePlaceholder = new System.Windows.Forms.Label();
            this.lblPasswordPlaceholder = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxLogo
            // 
            this.picBxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBxLogo.BackgroundImage = global::OdevTeslim.Properties.Resources.tulip2;
            this.picBxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxLogo.Location = new System.Drawing.Point(12, 12);
            this.picBxLogo.Name = "picBxLogo";
            this.picBxLogo.Size = new System.Drawing.Size(149, 263);
            this.picBxLogo.TabIndex = 0;
            this.picBxLogo.TabStop = false;
            // 
            // timerAnimation
            // 
            this.timerAnimation.Enabled = true;
            this.timerAnimation.Interval = 10;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // lblUniName
            // 
            this.lblUniName.AutoSize = true;
            this.lblUniName.BackColor = System.Drawing.Color.Transparent;
            this.lblUniName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUniName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUniName.Location = new System.Drawing.Point(220, 32);
            this.lblUniName.Name = "lblUniName";
            this.lblUniName.Size = new System.Drawing.Size(377, 24);
            this.lblUniName.TabIndex = 0;
            this.lblUniName.Text = "MANİSA CELAL BAYAR ÜNİVERSİTESİ";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAppName.ForeColor = System.Drawing.Color.Transparent;
            this.lblAppName.Location = new System.Drawing.Point(227, 71);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(362, 24);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "BİLGİSAYAR ZİMMET TAKİP SİSTEMİ";
            // 
            // txBxuserName
            // 
            this.txBxuserName.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxuserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxuserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txBxuserName.Location = new System.Drawing.Point(220, 114);
            this.txBxuserName.Name = "txBxuserName";
            this.txBxuserName.Size = new System.Drawing.Size(377, 30);
            this.txBxuserName.TabIndex = 2;
            this.txBxuserName.TextChanged += new System.EventHandler(this.txBxuserName_TextChanged);
            // 
            // txBxPassWord
            // 
            this.txBxPassWord.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txBxPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxPassWord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txBxPassWord.Location = new System.Drawing.Point(220, 159);
            this.txBxPassWord.Name = "txBxPassWord";
            this.txBxPassWord.PasswordChar = '*';
            this.txBxPassWord.Size = new System.Drawing.Size(377, 30);
            this.txBxPassWord.TabIndex = 3;
            this.txBxPassWord.TextChanged += new System.EventHandler(this.txBxPassWord_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.Location = new System.Drawing.Point(220, 209);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(377, 39);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLblClose
            // 
            this.linkLblClose.AutoSize = true;
            this.linkLblClose.BackColor = System.Drawing.Color.Transparent;
            this.linkLblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLblClose.LinkColor = System.Drawing.Color.Red;
            this.linkLblClose.Location = new System.Drawing.Point(550, 281);
            this.linkLblClose.Name = "linkLblClose";
            this.linkLblClose.Size = new System.Drawing.Size(47, 20);
            this.linkLblClose.TabIndex = 5;
            this.linkLblClose.TabStop = true;
            this.linkLblClose.Text = "Çıkış";
            this.linkLblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblClose_LinkClicked);
            // 
            // lblUserNamePlaceholder
            // 
            this.lblUserNamePlaceholder.AutoSize = true;
            this.lblUserNamePlaceholder.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblUserNamePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserNamePlaceholder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUserNamePlaceholder.Location = new System.Drawing.Point(231, 117);
            this.lblUserNamePlaceholder.Name = "lblUserNamePlaceholder";
            this.lblUserNamePlaceholder.Size = new System.Drawing.Size(247, 24);
            this.lblUserNamePlaceholder.TabIndex = 6;
            this.lblUserNamePlaceholder.Text = "Lütfen kullanıcı adını giriniz...";
            this.lblUserNamePlaceholder.Click += new System.EventHandler(this.lblUserNamePlaceholder_Click);
            // 
            // lblPasswordPlaceholder
            // 
            this.lblPasswordPlaceholder.AutoSize = true;
            this.lblPasswordPlaceholder.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblPasswordPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordPlaceholder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPasswordPlaceholder.Location = new System.Drawing.Point(231, 163);
            this.lblPasswordPlaceholder.Name = "lblPasswordPlaceholder";
            this.lblPasswordPlaceholder.Size = new System.Drawing.Size(197, 24);
            this.lblPasswordPlaceholder.TabIndex = 7;
            this.lblPasswordPlaceholder.Text = "Lütfen şifrenizi giriniz...";
            this.lblPasswordPlaceholder.Click += new System.EventHandler(this.lblPasswordPlaceholder_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(221, 255);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(376, 23);
            this.lblErrorMessage.TabIndex = 8;
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OdevTeslim.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 310);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblPasswordPlaceholder);
            this.Controls.Add(this.lblUserNamePlaceholder);
            this.Controls.Add(this.linkLblClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txBxPassWord);
            this.Controls.Add(this.txBxuserName);
            this.Controls.Add(this.picBxLogo);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblUniName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxLogo;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txBxPassWord;
        private System.Windows.Forms.TextBox txBxuserName;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblUniName;
        private System.Windows.Forms.LinkLabel linkLblClose;
        private System.Windows.Forms.Label lblUserNamePlaceholder;
        private System.Windows.Forms.Label lblPasswordPlaceholder;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}