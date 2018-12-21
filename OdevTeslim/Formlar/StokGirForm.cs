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
    public partial class StokGirForm : Form
    {
        public StokGirForm()
        {
            InitializeComponent();
        }
        public ZimmetApp zimmetApp;
        private void btnYeniUrun_Click(object sender, EventArgs e)
        {
            this.Hide();
            UrunTanımlaForm urunTanımlaForm = new UrunTanımlaForm();
            urunTanımlaForm.ShowDialog();
            this.Show();
            this.urunlerViewTableAdapter1.Fill(this.projeDataSeti.UrunlerView);
        }

        private void StokGirForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSeti.UrunlerView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunlerViewTableAdapter1.Fill(this.projeDataSeti.UrunlerView);
            // TODO: Bu kod satırı 'projeDataSeti.TedarikciTBL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tedarikciTBLTableAdapter1.Fill(this.projeDataSeti.TedarikciTBL);
         


        }

        private void GridviewSekillendir()
        {
            dgVUrunler.EnableHeadersVisualStyles = false;
            dgVUrunler.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dgVUrunler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgVUrunler.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            int rowCounter = 0;
            foreach (DataGridViewRow dgvr in dgVUrunler.Rows)
            {
                if (rowCounter % 2 == 0)
                { dgvr.DefaultCellStyle.BackColor = Color.LightBlue; }
                else
                { dgvr.DefaultCellStyle.BackColor = Color.LightGray; }
                rowCounter++;

            }
        }

        private void btnYeniTedarikci_Click(object sender, EventArgs e)
        {
            this.Hide();
            YeniTedarikciForm yeniTedarikciForm = new YeniTedarikciForm();
            yeniTedarikciForm.ShowDialog();
            this.tedarikciTBLTableAdapter1.Fill(this.projeDataSeti.TedarikciTBL);
            this.Show();

        }

        private void linkLblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void StokGirForm_Paint(object sender, PaintEventArgs e)
        {
            //formun etrafına kırmızı çerçeve çizer
            Pen pen = new Pen(Color.Red);
            pen.Width = 12.0F;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, ((Form)sender).Width - 1,
                ((Form)sender).Height - 1));
        }

        private void dgVUrunler_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridviewSekillendir();
        }


        Urun urun;
        private void dgVUrunler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgVUrunler.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgVUrunler.SelectedRows[0];
                string seciliUrun = (row.Cells[1].Value.ToString() + " / " +
                    row.Cells[2].Value.ToString() + " / " +
                    row.Cells[3].Value.ToString());
                if (seciliUrun.Length > 80)
                    seciliUrun = seciliUrun.Substring(0, 75) + ". . .";
                lblSeciliUrun.Text = seciliUrun;
                urun = new Urun()
                {
                    Isim = row.Cells[3].Value.ToString(),
                    UrunID = Convert.ToInt32(row.Cells[0].Value),
                };
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (txBxFatNo.Text.Trim() == "")
            {
                MessageBox.Show("Fatura numarısını giriniz...");
                return;
            }
            tarih = dTPickerFaturaTarih.Value.ToShortDateString();
            if (siparisAdet <= 0)
            {
                MessageBox.Show("Geçerli adet giriniz...");
                return;
            }
            if (siparisFiyat <= 0)
            {
                MessageBox.Show("Geçerli fiyat giriniz...");
                return;
            }
            StokEkle(siparisAdet);
        }

        Insert insertIslemi;
        private void StokEkle(int siparisAdet)
        {
            DialogResult result = MessageBox.Show(siparisAdet.ToString() + " adet" + urun.Isim + " eklenecek, emin misiniz?","Stok Ekleme",
                MessageBoxButtons.YesNo,MessageBoxIcon.Information);


            insertIslemi = new Insert(zimmetApp.appUser);
            Stock stock = new Stock()
            {
                UrunID = urun.UrunID,
                Fiyat = siparisFiyat.ToString(),
                FaturaNo = txBxFatNo.Text,
                FaturaTarihi = tarih.ToString(),
                TedarikciID = comboBxTedarikciler.SelectedIndex + 1,
                StokDurumID = 1

            };
            insertIslemi.Stock(stock,siparisAdet);
            MessageBox.Show("Ekleme işlemi başarılı");

        }

        int siparisAdet;
        private void txBxAdet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                siparisAdet = Convert.ToInt32(txBxAdet.Text);
            }
            catch (Exception)
            {
                siparisAdet = 0;
                txBxAdet.Text = "0";
            }
        }
        double siparisFiyat;
        private void txBxFiyat_TextChanged(object sender, EventArgs e)
        {

            try
            {
                siparisFiyat = Convert.ToDouble(txBxFiyat.Text.Replace(".", ","));
            }
            catch (Exception)
            {
                siparisFiyat = 0;
                txBxFiyat.Text = "";
            }

        }
        string tarih = "";
        private void dTPickerFaturaTarih_ValueChanged(object sender, EventArgs e)
        {
            if (dTPickerFaturaTarih.Value > DateTime.Now)
            {
                MessageBox.Show("İleri bir tarih giremezsiniz...");
                dTPickerFaturaTarih.Value = DateTime.Now;
                tarih = "";
                return;
            }

        }
    }
}
