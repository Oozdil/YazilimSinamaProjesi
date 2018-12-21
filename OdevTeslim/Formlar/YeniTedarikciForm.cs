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
    public partial class YeniTedarikciForm : Form
    {
        public YeniTedarikciForm()
        {
            InitializeComponent();
        }

        private void YeniTedarikciForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSeti.TedarikciTBL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tedarikciTBLTableAdapter1.Fill(this.projeDataSeti.TedarikciTBL);
        }

        private void YeniTedarikciForm_Paint(object sender, PaintEventArgs e)
        {
            //formun etrafına kırmızı çerçeve çizer
            Pen pen = new Pen(Color.Red);
            pen.Width = 12.0F;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, ((Form)sender).Width - 1,
                ((Form)sender).Height - 1));
        }

        private void linkLblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            TedarikciEkleme();
            this.tedarikciTBLTableAdapter1.Fill(this.projeDataSeti.TedarikciTBL);
            MessageBox.Show("Tedarikci eklendi");
        }

        //Eklme yapılıyor
        Insert insertIslemi;
        private void TedarikciEkleme()
        {
            string tedarikciAdi = txBxTedarikci.Text.Trim().ToUpper();
            string adres = txBxTedarikciAdres.Text.Trim().ToUpper();

            if (tedarikciAdi == "" || adres == "")
            {
                MessageBox.Show("Boş bilgiler var");
                return;
            }
            Tedarikci tedarikci = new Tedarikci()
            {
                TedarikciAdi = tedarikciAdi,
                Adres = adres
            };
            insertIslemi = new Insert();
            insertIslemi.Tedarikci(tedarikci);
        }
    }
}
