using Microsoft.Reporting.WinForms;
using OdevTeslim.Raporlamalar;
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
    public partial class ZimmetDuzenleForm : Form
    {
        public ZimmetApp zimmetApp;
        public ZimmetDuzenleForm(ZimmetApp za)
        {
            this.zimmetApp = za;
            InitializeComponent();
        }
        Personel kimdenPersonel;
        Personel kimePersonel;

        private void ZimmetDuzenleForm_Load(object sender, EventArgs e)
        {
            this.zimmetViewTableAdapter.FillByShId(this.zimmetTutanagiDataSet.ZimmetView, 0);
            this.zimmetliStockViewTableAdapter.FillByDepartmandan(this.projeDataSeti.ZimmetliStockView);
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
            this.ForeColor = ZimmetDuzenleForm.DefaultForeColor;
            this.Font = ZimmetDuzenleForm.DefaultFont;
            kimdenPersonel = new Personel() { PerID = 0 };

        }

        //Kimden alınacak radio buton değişimi
        private void KimdenSecimi(object sender, EventArgs e)
        {
            this.zimmetViewTableAdapter.FillByShId(this.zimmetTutanagiDataSet.ZimmetView, 0);
            if (radioBtnDepodanAl.Checked)
            {
                btnKisiSecKimden.Visible = false;
                lblKimden.Text = "Depodan";
                dgVZimmetliUrunler.Visible = true;
                kimdenPersonel = new Personel() { PerID = 0 };
                this.zimmetliStockViewTableAdapter.FillByDepartmandan(this.projeDataSeti.ZimmetliStockView);
            }
            else
            {
                btnKisiSecKimden.Visible = true;
                lblKimden.Text = "Kişi seçiniz...";
                this.zimmetliStockViewTableAdapter.FillByBos(this.projeDataSeti.ZimmetliStockView);

            }
        }

        //Kime verilecek radio buton değişimi
        private void KimeSecimi(object sender, EventArgs e)
        {
            this.zimmetViewTableAdapter.FillByShId(this.zimmetTutanagiDataSet.ZimmetView, 0);
            if (radioBtnKisiyeAta.Checked)
            {
                btnKisiSecKime.Visible = true;
            }
            else
            {
                btnKisiSecKime.Visible = false;
            }


            if (radioBtnDepoyaAl.Checked || radioBtnAtigaAl.Checked)
                kimePersonel = new Personel() { PerID = 0 };


        }
        
        private void btnKisiSecKimden_Click(object sender, EventArgs e)
        {
            KisiSecForm kisiSecForm = new KisiSecForm();
            kisiSecForm.ShowDialog();

            if (kisiSecForm.secilenPersonel != null)
            {
                kimdenPersonel = kisiSecForm.secilenPersonel;
                lblKimden.Text = kimdenPersonel.PerIsim + " " + kimdenPersonel.PerSoyisim + "-" + kimdenPersonel.PerDepartmanAdi;
                this.zimmetliStockViewTableAdapter.FillByPerID1(this.projeDataSeti.ZimmetliStockView, kimdenPersonel.PerID);
            }
            else
            {
                lblKimden.Text = "Kişi seçiniz...";
            }
        }

        private void btnKisiSecKime_Click(object sender, EventArgs e)
        {
            KisiSecForm kisiSecForm = new KisiSecForm();
            kisiSecForm.ShowDialog();

            if (kisiSecForm.secilenPersonel != null)
            {
                kimePersonel = kisiSecForm.secilenPersonel;
                lblKime.Text = kimePersonel.PerIsim + " " + kimePersonel.PerSoyisim + "-" + kimePersonel.PerDepartmanAdi;
            }
            else
            {
                lblKime.Text = "Kişi seçiniz...";
            }
        }


        //Raporlama araçları
        public ReportDataSource rs = new ReportDataSource();
        public class ZimmetTutanagi
        {
            public string Mesaj { get; set; }
            public string TeslimEden { get; set; }
            public string TeslimAlan { get; set; }
        }
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            if (dgVZimmetSonucu.Rows.Count > 0)
            {
                ZimmetTutanagi zt = new ZimmetTutanagi()
                {
                    Mesaj = dgVZimmetSonucu.Rows[0].Cells[0].Value.ToString() + " tarihinde, " +
                           dgVZimmetSonucu.Rows[0].Cells[6].Value.ToString() + " stok numaralı, " +
                           dgVZimmetSonucu.Rows[0].Cells[12].Value.ToString() + " ürünün teslim aldım.",
                    TeslimEden = dgVZimmetSonucu.Rows[0].Cells[1].Value.ToString() + " " + dgVZimmetSonucu.Rows[0].Cells[2].Value.ToString(),
                    TeslimAlan = dgVZimmetSonucu.Rows[0].Cells[4].Value.ToString() + " " + dgVZimmetSonucu.Rows[0].Cells[5].Value.ToString(),
                };

                RaporForm raporform = new RaporForm(3);
                raporform.zimmetTutanagi = zt;
                raporform.zimmetApp = zimmetApp;
                raporform.repVwZimmetTutanagi.LocalReport.DataSources.Clear();
                raporform.repVwZimmetTutanagi.LocalReport.DataSources.Add(rs);
                raporform.repVwZimmetTutanagi.LocalReport.ReportEmbeddedResource = "OdevTeslim.Raporlamalar.ReportZimmetTutanagi.rdlc";
                raporform.ShowDialog();
            }
        }

        //zimmetleme validassyonları
        Stock seciliurun;
        private void btnZimmetAta_Click(object sender, EventArgs e)
        {
            seciliurun = null;
            if (dgVZimmetliUrunler.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgVZimmetliUrunler.SelectedRows[0];
                seciliurun = new Stock()
                {
                    StokID = Convert.ToInt32(dr.Cells[0].Value.ToString()),
                    Isim = dr.Cells[2].Value.ToString()
                };
            }
            else
            {
                MessageBox.Show("Ürün seçimi yapmadınız!");
                return;
            }

            if (radioBtnDepodanAl.Checked && radioBtnDepoyaAl.Checked)
            {
                MessageBox.Show("Depodan depoya zimmetleme yapamazsınız!");
                return;
            }
            if (radioBtnDepodanAl.Checked && radioBtnAtigaAl.Checked)
            {
                MessageBox.Show("Depodan atığa zimmetleme yapamazsınız!");
                return;
            }

            if (kimePersonel == null)
            {
                MessageBox.Show("Kime zimmet yapacağınızı seçmediniz!");
                return;
            }
            if (kimdenPersonel.PerID == kimePersonel.PerID)
            {
                MessageBox.Show("Aynı kişiye atama yapılmaz!");
                return;
            }
            if (seciliurun != null)
            {
                AtamaYap();
            }
        }


        //zimmetleme işlemi
        private void AtamaYap()
        {


            int StokID, KimdenID, KimeID, UserID, HareketTipi, DurumID;
            string Tarih;

            StokID = seciliurun.StokID;
            Tarih = DateTime.Now.ToShortDateString();
            KimeID = kimePersonel.PerID;
            KimdenID = kimdenPersonel.PerID;
            DurumID = 2;
            UserID = zimmetApp.appUser.UserID;
            HareketTipi = 2;

            string kime = kimePersonel.PerIsim + " " + kimePersonel.PerSoyisim + " (" + kimePersonel.PerDepartmanAdi + ")";
            string kimden = kimdenPersonel.PerIsim + " " + kimdenPersonel.PerSoyisim + " (" + kimdenPersonel.PerDepartmanAdi + ")"; ;


            if (kimden.Trim() == "()")
                kimden = "Depo";
            if (kime.Trim() == "()" && radioBtnDepoyaAl.Checked)
            {
                kime = "Depo";
                DurumID = 1;
            }
            if (kime.Trim() == "()" && radioBtnAtigaAl.Checked)
            {
                kime = "Atık";
                DurumID = 3;
                HareketTipi = 4;
            }
            if (KimeID == 0)
                HareketTipi = 3;

            StokHareketi stokHareketi = new StokHareketi()
            {
                DurumID = DurumID,
                HareketTipi = HareketTipi,
                KimdenID = KimdenID,
                KimeID = KimeID,
                StokID = StokID,
                Tarih = Tarih,
                UserID = UserID
            };

            DialogResult result = MessageBox.Show(kimden + "---->" + kime + " \n " + seciliurun.Isim +
                "\n ataması yapılacak, emin misiniz?", "Atama İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                AtamaUpdate(stokHareketi);
                this.zimmetViewTableAdapter.FillByShId(this.zimmetTutanagiDataSet.ZimmetView, sonKayit);
            }
        }

        private string ZimmetSonucuOlustur(string kimden, string kime, User user)
        {
            return (kimden + " 'den " + kime + " 'e " + seciliurun.Isim + " zimmet ataması yapıldı");
        }
        int sonKayit;

        //veritabanında zimmet güncellemesi
        private void AtamaUpdate(StokHareketi sh)
        {
            Update update = new Update();
            sonKayit = update.Stock(sh);
            if (radioBtnDepodanAl.Checked)
                this.zimmetliStockViewTableAdapter.FillByDepartmandan(this.projeDataSeti.ZimmetliStockView);
            else
                this.zimmetliStockViewTableAdapter.FillByPerID1(this.projeDataSeti.ZimmetliStockView, kimdenPersonel.PerID);
        }

       
    }
}
