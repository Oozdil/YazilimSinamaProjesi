using Microsoft.Reporting.WinForms;
using OdevTeslim.Raporlamalar;
using OdevTeslim.Siniflar;
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
    public partial class UrunStokHareketForm : Form
    {
        int stokID;
        string urunAdi;
        public ZimmetApp zimmetApp;
        public UrunStokHareketForm(int _stokID, string _urunAdi)
        {
            stokID = _stokID;
            urunAdi = _urunAdi;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UrunStokHareketForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokHareketleriDataSet.StokHareketView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.stokHareketViewTableAdapter.Fill(this.stokHareketleriDataSet.StokHareketView);
            this.stokHareketViewTableAdapter.FillByStokID(this.stokHareketleriDataSet.StokHareketView, stokID);
            lblForStokFormu.Text = "(Stok ID: " + stokID.ToString() + ") " + urunAdi.ToString() + " Hareketleri";
        }

        private void UrunStokHareketForm_Paint(object sender, PaintEventArgs e)
        {
            //formun etrafına beyaz çerçeve çizer
            Pen pen = new Pen(Color.White);
            pen.Width = 12.0F;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, ((Form)sender).Width - 1,
                ((Form)sender).Height - 1));
        }

        //Raporlama araçları
        public ReportDataSource rs = new ReportDataSource();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            List<UrunStokHareket> lst = new List<UrunStokHareket>();
            for (int i = 0; i < dgVHareketler.RowCount; i++)
            {
                lst.Add(new UrunStokHareket()
                {
                    Tarih = dgVHareketler.Rows[i].Cells[0].Value.ToString(),
                    Kimden = dgVHareketler.Rows[i].Cells[1].Value.ToString()+" "+ dgVHareketler.Rows[i].Cells[2].Value.ToString(),
                    Hareket = dgVHareketler.Rows[i].Cells[3].Value.ToString(),
                    Kime = dgVHareketler.Rows[i].Cells[4].Value.ToString()+" "+ dgVHareketler.Rows[i].Cells[5].Value.ToString(),                   
                    IslemYapan = dgVHareketler.Rows[i].Cells[9].Value.ToString() + " " + dgVHareketler.Rows[i].Cells[10].Value.ToString(),
                });
            }

            rs.Name = "DataSetStokHareket";
            rs.Value = lst;
            RaporForm raporform = new RaporForm(5);
            raporform.repVwStokHareket.LocalReport.DataSources.Clear();
            raporform.repVwStokHareket.LocalReport.DataSources.Add(rs);
            raporform.repVwStokHareket.LocalReport.ReportEmbeddedResource = "OdevTeslim.Raporlamalar.ReportStokHareket.rdlc";
            raporform.zimmetApp = zimmetApp;
            raporform.ShowDialog();
        }
        public class UrunStokHareket
        {
            public string Tarih { get; set; }
            public string Kimden { get; set; }
            public string Hareket { get; set; }
            public string Kime { get; set; }
            public string IslemYapan { get; set; }

        }
    }
}
