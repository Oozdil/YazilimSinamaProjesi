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
    public partial class KisiZimmetForm : Form
    {
        public KisiZimmetForm()
        {
            InitializeComponent();
        }
        public ZimmetApp zimmetApp;
        private void KisiZimmetForm_Load(object sender, EventArgs e)
        {


            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
            this.ForeColor = KisiZimmetForm.DefaultForeColor;
            this.Font = KisiZimmetForm.DefaultFont;
            comBxDepartmanlar.Visible = true;

            //Eğer kullanıcı bölüm şefi ise sadece kendi departmanını görebilir
            if (zimmetApp.appUser.RoleID == 3)
            {
                this.departmanTBLTableAdapter.FillByDepID(this.projeDataSeti.DepartmanTBL, zimmetApp.appUser.PerDepID);
                this.personelTBLTableAdapter.FillByDepID(this.projeDataSeti.PersonelTBL, zimmetApp.appUser.PerDepID);

            }
            else
            {
                this.departmanTBLTableAdapter.Fill(this.projeDataSeti.DepartmanTBL);
                DepartmanSecimi();
            }




            comBxDepartmanlar.Visible = true;
        }

        private void DepartmanSecimi()
        {
            try
            {
                DataRow selectedDataRow = ((DataRowView)comBxDepartmanlar.SelectedItem).Row;
                string DepartmanIsmi = selectedDataRow["DepIsim"].ToString();
                int DepartmanID = Convert.ToInt32(selectedDataRow["DepID"]);
                this.personelTBLTableAdapter.FillByDepID(this.projeDataSeti.PersonelTBL, DepartmanID);
            }
            catch
            {

            }
        }

        //Raporlama araçları
        public ReportDataSource rs = new ReportDataSource();
        public class KisiStok
        {
            public string StokID { get; set; }
            public string Kategori { get; set; }
            public string Marka { get; set; }
            public string UrunAdi { get; set; }
        }

        // Sorgu sonucumuz rapora aktarılıyor
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            List<KisiStok> lst = new List<KisiStok>();

            for (int i = 0; i < dgVPersonelStok.RowCount; i++)
            {
                lst.Add(new KisiStok()
                {
                    StokID = dgVPersonelStok.Rows[i].Cells[0].Value.ToString(),
                    Kategori = dgVPersonelStok.Rows[i].Cells[3].Value.ToString(),
                    Marka = dgVPersonelStok.Rows[i].Cells[4].Value.ToString(),
                    UrunAdi = dgVPersonelStok.Rows[i].Cells[2].Value.ToString()

                });
            }

            rs.Name = "DataSetKisiStok";
            rs.Value = lst;
            RaporForm raporform = new RaporForm(1);
            raporform.zimmetApp = zimmetApp;
            raporform.repVwKisiZimmet.LocalReport.DataSources.Clear();
            raporform.repVwKisiZimmet.LocalReport.DataSources.Add(rs);
            raporform.repVwKisiZimmet.LocalReport.ReportEmbeddedResource = "OdevTeslim.Raporlamalar.ReportKisiStok.rdlc";

            raporform.ShowDialog();
        }

        private void comBxDepartmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartmanSecimi();
        }


        //Seçilen personele göre zimmet listesi görüntüleniyor
        private void dgVPersoneller_SelectionChanged(object sender, EventArgs e)
        {
            if (dgVPersoneller.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgVPersoneller.SelectedRows[0];
                int PerID = Convert.ToInt32(row.Cells[0].Value.ToString());
                this.zimmetliStockViewTableAdapter.FillByPerID(this.projeDataSeti.ZimmetliStockView, PerID);
                lblSeciliPersonel.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
            }
        }


    }
}
