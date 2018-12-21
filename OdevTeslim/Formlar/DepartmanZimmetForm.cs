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
    public partial class DepartmanZimmetForm : Form
    {
        public DepartmanZimmetForm()
        {        
            InitializeComponent();
        }
        public ZimmetApp zimmetApp;
        private void DepartmanZimmetForm_Load(object sender, EventArgs e)
        {
           
            this.departmanTBLTableAdapter1.Fill(this.projeDataSeti.DepartmanTBL);


            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
            this.ForeColor = DepartmanZimmetForm.DefaultForeColor;
            this.Font = DepartmanZimmetForm.DefaultFont;

            comBxDepartmanlar.Visible = true;
            if (zimmetApp.appUser.RoleID == 3)
            {
                
                this.departmanTBLTableAdapter1.FillByDepID(this.projeDataSeti.DepartmanTBL, zimmetApp.appUser.PerDepID);
                lblSeciliDepartman.Text = zimmetApp.appUser.PerDepartmanAdi+" DEPARTMANI";
                lblForDepartmanlar.Visible = false;
                this.zimmetliStockViewTableAdapter.FillByDepID(this.projeDataSeti.ZimmetliStockView, zimmetApp.appUser.PerDepID);
            }
            else
            {
               
                DepartmanSecimi();
            }

           
                              
        }

        public ReportDataSource rs = new ReportDataSource();
        public class DepartmanStok
        {
            public string StokID { get; set; }
            public string UrunIsim { get; set; }
            public string Kategori { get; set; }
            public string Marka { get; set; }
            public string FullIsim { get; set; }
        }
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            List<DepartmanStok> lst = new List<DepartmanStok>();

            for (int i = 0; i < dgVDepartmanStok.RowCount; i++)
            {
                lst.Add(new DepartmanStok()
                {
                     StokID= dgVDepartmanStok.Rows[i].Cells[0].Value.ToString(),
                     UrunIsim = dgVDepartmanStok.Rows[i].Cells[2].Value.ToString(),
                     Kategori = dgVDepartmanStok.Rows[i].Cells[3].Value.ToString(),
                     Marka= dgVDepartmanStok.Rows[i].Cells[4].Value.ToString(),
                     FullIsim = dgVDepartmanStok.Rows[i].Cells[5].Value.ToString()+ " "+
                     dgVDepartmanStok.Rows[i].Cells[6].Value.ToString()+ " ("+
                     dgVDepartmanStok.Rows[i].Cells[7].Value.ToString()+")"
                });
            }

            rs.Name = "DataSetDepartmanStok";
            rs.Value = lst;
            RaporForm raporform = new RaporForm(2);
            raporform.zimmetApp = zimmetApp;
            raporform.DepAdi = lblSeciliDepartman.Text;
            raporform.repVwDepartmanZimmet.LocalReport.DataSources.Clear();
            raporform.repVwDepartmanZimmet.LocalReport.DataSources.Add(rs);
            raporform.repVwDepartmanZimmet.LocalReport.ReportEmbeddedResource = "OdevTeslim.Raporlamalar.ReportDepartmanStok.rdlc";

            raporform.ShowDialog();
        }

        private void comBxDepartmanlar_SelectedIndexChanged(object sender, EventArgs e)
        {           
            DepartmanSecimi();
        }

        private void DepartmanSecimi()
        {
            try
            {
                DataRow selectedDataRow = ((DataRowView)comBxDepartmanlar.SelectedItem).Row;
                string DepartmanIsmi = selectedDataRow["DepIsim"].ToString();
                int DepartmanID = Convert.ToInt32(selectedDataRow["DepID"]);
                lblSeciliDepartman.Text = DepartmanIsmi + " DEPARTMANI";
                this.zimmetliStockViewTableAdapter.FillByDepID(this.projeDataSeti.ZimmetliStockView, DepartmanID);
            }
            catch
            {

            }


        }

        private void dgVDepartmanStok_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgVDepartmanStok.EnableHeadersVisualStyles = false;
            dgVDepartmanStok.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dgVDepartmanStok.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgVDepartmanStok.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int rowCounter = 0;
            foreach (DataGridViewRow dgvr in dgVDepartmanStok.Rows)
            {
                if (rowCounter % 2 == 0)
                { dgvr.DefaultCellStyle.BackColor = Color.LightBlue; }
                else
                { dgvr.DefaultCellStyle.BackColor = Color.LightGray; }
                rowCounter++;
            }
        }

        private void btnHareketDetay_Click(object sender, EventArgs e)
        {
            
            if (dgVDepartmanStok.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgVDepartmanStok.SelectedRows[0];
                UrunStokHareketForm urunStokHareketForm = new UrunStokHareketForm(Convert.ToInt32(dr.Cells[0].Value.ToString()), dr.Cells[2].Value.ToString());
                urunStokHareketForm.zimmetApp = zimmetApp;
                urunStokHareketForm.ShowDialog();      

            }
        }
    }
}
