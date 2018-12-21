using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OdevTeslim.Formlar;
using OdevTeslim.Siniflar;

namespace OdevTeslim
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public ZimmetApp zimmetApp;
        private void MainForm_Load(object sender, EventArgs e)
        {
            FillWelcomeMessage();
            FillAppInfoMessage();
            SetToolTips();
            LoadForms();
            LoadButtons();
        }

        private void LoadButtons()
        {
            btnManuelGirisler.Visible = true;
            btnKullaniciIslemleri.Visible = true;
            btnZimmetIslemleri.Visible = true;
            btnSatinAlma.Visible = true;
            if (zimmetApp.appUser.RoleID > 1)
            {
                btnManuelGirisler.Visible = false;
                btnKullaniciIslemleri.Visible = false;
            }
            if (zimmetApp.appUser.RoleID > 2)
            {
                btnZimmetIslemleri.Visible = false;
                btnSatinAlma.Visible = false;
                btnManuelGirisler.Visible = false;
                btnKullaniciIslemleri.Visible = false;
            }
        }

        KisiZimmetForm kisiZimmetForm;
        DepartmanZimmetForm departmanZimmetForm;
        ZimmetDuzenleForm zimmetDuzenleForm;
        StokForm stokForm;
        KullaniciEkleForm kullaniciEkleForm;
        ManuelGirisForm manuelGirisForm;
        private void LoadForms()
        {
            kisiZimmetForm = new KisiZimmetForm();
            kisiZimmetForm.zimmetApp = this.zimmetApp;
            departmanZimmetForm = new DepartmanZimmetForm();
            departmanZimmetForm.zimmetApp = this.zimmetApp;
            zimmetDuzenleForm = new ZimmetDuzenleForm(zimmetApp);
            stokForm = new StokForm();
            stokForm.zimmetApp = this.zimmetApp;
            kullaniciEkleForm = new KullaniciEkleForm(zimmetApp);
            manuelGirisForm = new ManuelGirisForm(zimmetApp);
        }

        private void SetToolTips()
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(btnExit, "Programı Kapat");
            ToolTip ToolTip2 = new ToolTip();
            ToolTip2.SetToolTip(btnLogout, "Kullanıcı çıkışı yap");
            ToolTip ToolTip3 = new ToolTip();
            ToolTip3.SetToolTip(btnAbout, "Proje Ödevi Hakkında");
        }

        private void FillAppInfoMessage()
        {
            lblAppInfo.Text = "MCBU   Yazılım Mühendisliği   YZM3105 Yazılım Sınama Dersi Proje Ödevi - 2018";
            lblWriterInfo.Text = "Danışman :    Dr. Emin BORANDAĞ  Hazırlayanlar:   Orçun ÖZDİL (172803065), Ergen Altıparmak   (162803058)";

        }

        private void FillWelcomeMessage()
        {
            lblWelcome.Text = "Hoşgeldiniz: " + zimmetApp.appUser.PerIsim + " " +
                zimmetApp.appUser.PerSoyisim + " (" + zimmetApp.appUser.RoleName + ") " + DateTime.Now.ToLongTimeString() + " - "
                + DateTime.Now.ToLongDateString();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            //formun etrafına beyaz çerçeve çizer
            Pen pen = new Pen(Color.White);
            pen.Width = 10.0F;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, ((Form)sender).Width - 1,
                ((Form)sender).Height - 1));
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
        protected override void WndProc(ref Message m)
        {
            //   Form borderstyle none yaptık formu tam ekran yapmaya, drag yapmaya yarar
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "ÇIKIŞ İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oturumu sonlandırmak istediğinze emin misiniz?",
             "Çıkış İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                System.Diagnostics.Process.Start(Application.ExecutablePath);
            }

        }

        private void timerWelcome_Tick(object sender, EventArgs e)
        {
            FillWelcomeMessage();
        }







        private void MenuSecim(object sender, EventArgs e)
        {
            Button tiklananMenu = sender as Button;
            pnlContainer.Controls.Clear();
            switch (tiklananMenu.Name)
            {
                case "btnZimmetKisi":
                    kisiZimmetForm.TopLevel = false;
                    pnlContainer.Controls.Add(kisiZimmetForm);
                    kisiZimmetForm.Dock = DockStyle.Fill;
                    kisiZimmetForm.Show();
                    break;
                case "btnZimmetDepartman":
                    departmanZimmetForm.TopLevel = false;
                    pnlContainer.Controls.Add(departmanZimmetForm);
                    departmanZimmetForm.Dock = DockStyle.Fill;
                    departmanZimmetForm.Show();
                    break;
                case "btnZimmetIslemleri":
                    zimmetDuzenleForm.TopLevel = false;
                    pnlContainer.Controls.Add(zimmetDuzenleForm);
                    zimmetDuzenleForm.Dock = DockStyle.Fill;
                    zimmetDuzenleForm.Show();
                    break;
                case "btnSatinAlma":
                    stokForm.TopLevel = false;
                    pnlContainer.Controls.Add(stokForm);
                    stokForm.Dock = DockStyle.Fill;
                    stokForm.Show();
                    break;
                case "btnKullaniciIslemleri":
                    kullaniciEkleForm.TopLevel = false;
                    pnlContainer.Controls.Add(kullaniciEkleForm);
                    kullaniciEkleForm.Dock = DockStyle.Fill;
                    kullaniciEkleForm.Show();
                    break;
                case "btnManuelGirisler":
                    manuelGirisForm.TopLevel = false;
                    pnlContainer.Controls.Add(manuelGirisForm);
                    manuelGirisForm.Dock = DockStyle.Fill;
                    manuelGirisForm.Show();
                    break;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            HakkindaForm hakkindaForm = new HakkindaForm();
            hakkindaForm.ShowDialog();
        }
    }
}
