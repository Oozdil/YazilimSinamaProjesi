using OdevTeslim.Siniflar;
using OdevTeslim.Veritabani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevTeslim
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        ZimmetApp zimmetApp;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnLogin.Location = new Point(btnLogin.Location.X + 500, 209);
            txBxuserName.Location = new Point(txBxuserName.Location.X + 500, 114);
            txBxPassWord.Location = new Point(txBxPassWord.Location.X + 500, 159);
            lblUniName.Location = new Point(lblUniName.Location.X + 500, 32);
            lblAppName.Location = new Point(lblAppName.Location.X + 500, 71);


            picBxLogo.Width = 0;
            picBxLogo.Height = 0;
            linkLblClose.Visible = false;
            lblUserNamePlaceholder.Visible = false;
            lblPasswordPlaceholder.Visible = false;
            this.Focus();


            zimmetApp = new ZimmetApp(); 
        }
        protected override CreateParams CreateParams
        {
            // Background image kullandık, ekranın flickering yapmasını engeller
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }

        }


        private void linkLblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "ÇIKIŞ İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            //formun etrafına beyaz çerçeve çizer
            Pen pen = new Pen(Color.White);
            pen.Width = 12.0F;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, ((Form)sender).Width - 1,
                ((Form)sender).Height - 1));
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if (btnLogin.Location.X == 220)
            {
                timerAnimation.Enabled = false;
                linkLblClose.Visible = true;
                if (txBxuserName.Text.Trim() == "")
                    lblUserNamePlaceholder.Visible = true;

                if (txBxPassWord.Text.Trim() == "")
                    lblPasswordPlaceholder.Visible = true;
            }


            btnLogin.Location = new Point(btnLogin.Location.X - 10, 209);
            txBxuserName.Location = new Point(txBxuserName.Location.X - 10, 114);
            txBxPassWord.Location = new Point(txBxPassWord.Location.X - 10, 159);
            lblUniName.Location = new Point(lblUniName.Location.X - 10, 32);
            lblAppName.Location = new Point(lblAppName.Location.X - 10, 71);


            picBxLogo.Width += 4;
            picBxLogo.Height += 6;
        }

        private void txBxuserName_TextChanged(object sender, EventArgs e)
        {
            if (txBxuserName.Text.Trim().Length > 0)
                lblUserNamePlaceholder.Visible = false;
            else
                lblUserNamePlaceholder.Visible = true;
        }

        private void txBxPassWord_TextChanged(object sender, EventArgs e)
        {
            if (txBxPassWord.Text.Trim().Length > 0)
                lblPasswordPlaceholder.Visible = false;
            else
                lblPasswordPlaceholder.Visible = true;
        }

        private void lblUserNamePlaceholder_Click(object sender, EventArgs e)
        {
            txBxuserName.Focus();
        }

        private void lblPasswordPlaceholder_Click(object sender, EventArgs e)
        {
            txBxPassWord.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txBxPassWord.Text.Trim() == "" || txBxuserName.Text.Trim() == "")
            {
                lblErrorMessage.Text = "Kullanıcı adı veya şifre boş olamaz";
            }
            else
            {
                LoginOl();
            }
        }

        private void LoginOl()
        {
            Login login = new Login(txBxuserName.Text, txBxPassWord.Text, zimmetApp);

            if (zimmetApp.appUser != null)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.zimmetApp = zimmetApp;
                mainForm.Show();
            }
            else
            {
                lblErrorMessage.Text = "Lütfen giriş bilgilerinizi kontrol ediniz";
                    
            }
        }
    }
}
