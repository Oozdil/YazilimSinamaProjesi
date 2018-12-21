namespace OdevTeslim.Formlar
{
    partial class HakkindaForm
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
            this.richtxBxMessage = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.timerMessage = new System.Windows.Forms.Timer(this.components);
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // richtxBxMessage
            // 
            this.richtxBxMessage.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richtxBxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtxBxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richtxBxMessage.ForeColor = System.Drawing.Color.Green;
            this.richtxBxMessage.Location = new System.Drawing.Point(5, 5);
            this.richtxBxMessage.Name = "richtxBxMessage";
            this.richtxBxMessage.ReadOnly = true;
            this.richtxBxMessage.Size = new System.Drawing.Size(367, 329);
            this.richtxBxMessage.TabIndex = 0;
            this.richtxBxMessage.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.Green;
            this.btnClose.Location = new System.Drawing.Point(12, 289);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(352, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerMessage
            // 
            this.timerMessage.Enabled = true;
            this.timerMessage.Interval = 10;
            this.timerMessage.Tick += new System.EventHandler(this.timerMessage_Tick);
            // 
            // picBxLogo
            // 
            this.picBxLogo.BackgroundImage = global::OdevTeslim.Properties.Resources.uni_logo_sm;
            this.picBxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxLogo.Location = new System.Drawing.Point(144, 179);
            this.picBxLogo.Name = "picBxLogo";
            this.picBxLogo.Size = new System.Drawing.Size(100, 86);
            this.picBxLogo.TabIndex = 2;
            this.picBxLogo.TabStop = false;
            this.picBxLogo.Visible = false;
            // 
            // HakkindaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(377, 339);
            this.Controls.Add(this.picBxLogo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.richtxBxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HakkindaForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HakkindaForm";
            this.Load += new System.EventHandler(this.HakkindaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxBxMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timerMessage;
        private System.Windows.Forms.PictureBox picBxLogo;
    }
}