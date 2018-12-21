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
    public partial class StokForm : Form
    {
        public StokForm()
        {
            InitializeComponent();
        }
        public ZimmetApp zimmetApp;
        private void StokForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSeti.StockView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stockViewTableAdapter1.Fill(this.projeDataSeti.StockView);

            GridviewSekillendir();

            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
            this.ForeColor = StokForm.DefaultForeColor;
            this.Font = StokForm.DefaultFont;


        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {

            StokGirForm stokGirForm = new StokGirForm();
            stokGirForm.zimmetApp = zimmetApp;
            stokGirForm.ShowDialog();
            GridviewSekillendir();


        }
        private void GridviewSekillendir()
        {
            this.stockViewTableAdapter1.Fill(this.projeDataSeti.StockView);
        }



        private void dgVStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgVStock.EnableHeadersVisualStyles = false;
            dgVStock.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dgVStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgVStock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            int rowCounter = 0;
            foreach (DataGridViewRow dgvr in dgVStock.Rows)
            {
                if (rowCounter % 2 == 0)
                { dgvr.DefaultCellStyle.BackColor = Color.LightBlue; }
                else
                { dgvr.DefaultCellStyle.BackColor = Color.LightGray; }
                rowCounter++;
                dgvr.Cells[4].Style.BackColor = Color.LightGreen;
                dgvr.Cells[5].Style.BackColor = Color.AliceBlue;
                dgvr.Cells[6].Style.BackColor = Color.LightPink;
            }

            foreach (DataGridViewRow dgvr in dgVStock.Rows)
            {
                int depo = Convert.ToInt32(dgvr.Cells[4].Value.ToString());
                int zimmet = Convert.ToInt32(dgvr.Cells[5].Value.ToString());
                int atik = Convert.ToInt32(dgvr.Cells[6].Value.ToString());
                if (depo + atik + zimmet <= 0)
                    dgvr.Visible = false;

            }
        }
        public ReportDataSource rs = new ReportDataSource();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            List<FirmaStok> lst = new List<FirmaStok>();

            for (int i = 0; i < dgVStock.RowCount; i++)
            {

                int depo = Convert.ToInt32(dgVStock.Rows[i].Cells[4].Value.ToString());
                int zimmet = Convert.ToInt32(dgVStock.Rows[i].Cells[5].Value.ToString());
                int atik = Convert.ToInt32(dgVStock.Rows[i].Cells[6].Value.ToString());
                if (depo + atik + zimmet > 0)

                    lst.Add(new FirmaStok()
                {
                    ID = Convert.ToInt32(dgVStock.Rows[i].Cells[0].Value.ToString()),
                    Kategori = dgVStock.Rows[i].Cells[1].Value.ToString(),
                    Marka = dgVStock.Rows[i].Cells[2].Value.ToString(),
                    UrunAdi = dgVStock.Rows[i].Cells[3].Value.ToString(),
                    Depo = Convert.ToInt32(dgVStock.Rows[i].Cells[4].Value.ToString()),
                    Zimmet = Convert.ToInt32(dgVStock.Rows[i].Cells[5].Value.ToString()),
                    Atik = Convert.ToInt32(dgVStock.Rows[i].Cells[6].Value.ToString())

                });
            }

            rs.Name = "DataSetStok";
            rs.Value = lst;
            RaporForm raporform = new RaporForm(4);
            raporform.zimmetApp = zimmetApp;
            raporform.repVwStokRaporu.LocalReport.DataSources.Clear();
            raporform.repVwStokRaporu.LocalReport.DataSources.Add(rs);
            raporform.repVwStokRaporu.LocalReport.ReportEmbeddedResource = "OdevTeslim.Raporlamalar.ReportStok.rdlc";
           
            raporform.ShowDialog();
        }
        public class FirmaStok
        {
            public int ID { get; set; }
            public string Kategori { get; set; }
            public string Marka { get; set; }
            public string UrunAdi { get; set; }
            public int Depo { get; set; }
            public int Zimmet { get; set; }
            public int Atik { get; set; }
        }

        private void StokForm_VisibleChanged(object sender, EventArgs e)
        {
            this.stockViewTableAdapter1.Fill(this.projeDataSeti.StockView);
        }
    }
}
