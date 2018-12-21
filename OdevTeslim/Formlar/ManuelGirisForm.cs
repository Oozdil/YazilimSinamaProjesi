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

namespace OdevTeslim.Formlar
{
    public partial class ManuelGirisForm : Form
    {
        public ZimmetApp zimmetApp;
        public ManuelGirisForm(ZimmetApp za)
        {
            this.zimmetApp = za;
            InitializeComponent();
        }
        
        private void ManuelGirisForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSeti.DepartmanTBL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTBLTableAdapter1.Fill(this.projeDataSeti.DepartmanTBL);
          
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
            this.ForeColor = ManuelGirisForm.DefaultForeColor;
            this.Font = ManuelGirisForm.DefaultFont;
            comBxDepartman.Visible = true;

        }

        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            if (txBxDepartmanAd.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show("Departmanı eklemek istediğinize emin misiniz?", "KAYIT EKLEME", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                    DepartmanEkle();

            }
            else
            {
                MessageBox.Show("Departman adı boş olamaz!", "HATA!");
            }
        }
        Insert insertIslemi;
        private void DepartmanEkle()
        {
            insertIslemi= new Insert(zimmetApp.appUser);
            insertIslemi.Department(txBxDepartmanAd.Text);
            this.departmanTBLTableAdapter1.Fill(this.projeDataSeti.DepartmanTBL);
            txBxDepartmanAd.Clear();
        }

        private void PersonelEkle()
        {
            Personel personel = new Personel() {
                PerIsim = txBxAd.Text,
                PerSoyisim = txBxSoyad.Text,
                PerTelefon = txBxTelefon.Text,
                PerAdres = txBxAdres.Text,
                PerDepID = Convert.ToInt32(comBxDepartman.SelectedValue)

            };
            insertIslemi = new Insert(zimmetApp.appUser);
            insertIslemi.Personel(personel);
            txBxAd.Clear();
            txBxSoyad.Clear();
            txBxTelefon.Clear();
            txBxAdres.Clear();
            comBxDepartman.SelectedIndex = -1;
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (txBxAd.Text.Trim() != "" && txBxSoyad.Text.Trim() != "" && txBxTelefon.Text.Trim() != "" && txBxAdres.Text.Trim() != "" && comBxDepartman.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Personeli eklemek istediğinize emin misiniz?", "KAYIT EKLEME", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                    PersonelEkle();

            }
            else
            {
                MessageBox.Show("Boş alanlar var!", "HATA!");
            }
        }

        private void btnMetroFrameWork_Click(object sender, EventArgs e)
        {
            MetroFrameWorkDemoForm metroFrameWorkDemoForm = new MetroFrameWorkDemoForm();
            metroFrameWorkDemoForm.ShowDialog();
        }
    }
}
