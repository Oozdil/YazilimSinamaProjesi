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
    public partial class UrunTanımlaForm : Form
    {
        public UrunTanımlaForm()
        {
            InitializeComponent();
        }

        //yeni marka ekleme
        private void btnyeniMarka_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarkaEkleForm markaEkleForm = new MarkaEkleForm();
            markaEkleForm.ShowDialog();
            this.Show();
            this.markaTBLTableAdapter1.Fill(this.projeDataSeti.MarkaTBL);
        }
        //yani kategori ekleme
        private void btnYeniKategori_Click(object sender, EventArgs e)
        {
            this.Hide();
            KategoriEkleForm kategoriEkleForm = new KategoriEkleForm();
            kategoriEkleForm.ShowDialog();
            this.Show();
            this.kategoriTBLTableAdapter1.Fill(this.projeDataSeti.KategoriTBL);
        }

        private void linkLblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void UrunTanımlaForm_Paint(object sender, PaintEventArgs e)
        {
            //formun etrafına kırmızı çerçeve çizer
            Pen pen = new Pen(Color.Red);
            pen.Width = 12.0F;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, ((Form)sender).Width - 1,
                ((Form)sender).Height - 1));
        }

        private void UrunTanımlaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSeti.KategoriTBL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kategoriTBLTableAdapter1.Fill(this.projeDataSeti.KategoriTBL);
            // TODO: Bu kod satırı 'projeDataSeti.MarkaTBL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.markaTBLTableAdapter1.Fill(this.projeDataSeti.MarkaTBL);

        }
        int katId;
        int markaId;
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            DataRow selectedDataRow = ((DataRowView)comboBxKategori.SelectedItem).Row;
             katId = Convert.ToInt32(selectedDataRow["KategoriID"]);
            selectedDataRow = ((DataRowView)comBxMarka.SelectedItem).Row;
             markaId = Convert.ToInt32(selectedDataRow["MarkaID"]);

           //Eğer ürün adı giriliyse ekleme yap
            if (txBxUrunAdi.Text.Trim() != "")
            {
                UrunEkle();
            }
            else
            {
                MessageBox.Show("Lütfen ürün adını giriniz");
            }
        }

        //ürün ekleme işlemi
        Insert insertIslemi;
        private void UrunEkle()
        {
            Urun urun = new Urun()
            {
                Isim = txBxUrunAdi.Text.Trim(),
                KategoriID = katId,
                 MarkaID=markaId
            };
            insertIslemi = new Insert();
            insertIslemi.Urun(urun);
            MessageBox.Show("Urun tanımlandı");
        }
    }
}
