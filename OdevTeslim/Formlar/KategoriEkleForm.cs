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
    public partial class KategoriEkleForm : Form
    {
        public KategoriEkleForm()
        {
            InitializeComponent();
        }

        private void KategoriEkleForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSeti.KategoriTBL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kategoriTBLTableAdapter1.Fill(this.projeDataSeti.KategoriTBL);
            
        }

        private void linkLblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string kategori = txBxKategori.Text.Trim().ToUpper();
            
            if (kategori == "")
            {
                MessageBox.Show("Kategori bilgisi boş olamaz");
                return;
            }
            bool zatenVar = false;

            for (int i = 0; i < dgVKategoriler.RowCount; i++)
            {
                if (dgVKategoriler.Rows[i].Cells[1].Value.ToString() == kategori)
                    zatenVar = true;
            }

            if (zatenVar)
                MessageBox.Show("Kategori zaten mevcut!");
            else
            {
                KategoriEkle();
            }
        }



        //Ketegoriyi ekliyoruz
        Insert insertIslemi;
        private void KategoriEkle()
        {
            insertIslemi = new Insert();
            insertIslemi.Kategori(txBxKategori.Text.Trim().ToUpper());
            MessageBox.Show("Kategori eklendi!");
            this.kategoriTBLTableAdapter1.Fill(this.projeDataSeti.KategoriTBL);
        }

        private void KategoriEkleForm_Paint(object sender, PaintEventArgs e)
        {
            //formun etrafına kırmızı çerçeve çizer
            Pen pen = new Pen(Color.Red);
            pen.Width = 12.0F;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, ((Form)sender).Width - 1,
                ((Form)sender).Height - 1));
        }
    }
}
