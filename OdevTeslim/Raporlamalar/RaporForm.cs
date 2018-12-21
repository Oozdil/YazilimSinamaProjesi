using Microsoft.Reporting.WinForms;
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
using static OdevTeslim.Formlar.ZimmetDuzenleForm;

namespace OdevTeslim.Raporlamalar
{
    public partial class RaporForm : MetroFramework.Forms.MetroForm
    {
        public int raporTipi;
        public ZimmetApp zimmetApp;
        public ZimmetTutanagi zimmetTutanagi;
        public string DepAdi;

        public RaporForm(int _raporTipi)
        {
            this.raporTipi = _raporTipi;
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            this.userViewTableAdapter.FillByUserID(this.projeDataSeti.UserView,zimmetApp.appUser.UserID);
            foreach (Control c in this.Controls)
                c.Visible = false;
            RaporuAlanBilgileri();
            
            switch (raporTipi)
            {
                case 1:
                    this.Text = "Kişi Zimmet Raporu";
                    repVwKisiZimmet.Visible = true;
                    repVwKisiZimmet.Dock = DockStyle.Fill;
                    this.repVwKisiZimmet.LocalReport.SetParameters(rpTarih);
                    this.repVwKisiZimmet.LocalReport.SetParameters(rpTitle);
                    this.repVwKisiZimmet.LocalReport.SetParameters(rpIsim);
                    break;
                case 2:
                    this.Text = "Departman Zimmet Raporu";
                    repVwDepartmanZimmet.Visible = true;
                    repVwDepartmanZimmet.Dock = DockStyle.Fill;
                    this.repVwDepartmanZimmet.LocalReport.SetParameters(rpTarih);
                    this.repVwDepartmanZimmet.LocalReport.SetParameters(rpTitle);
                    this.repVwDepartmanZimmet.LocalReport.SetParameters(rpIsim);
                    ReportParameter rpDepartmanAdi = new ReportParameter("DepartmanIsimParameter", DepAdi);
                    this.repVwDepartmanZimmet.LocalReport.SetParameters(rpDepartmanAdi);
                    break;
                case 3:
                    this.Text = "Zimmet Tutanağı";
                    repVwZimmetTutanagi.Visible = true;
                    repVwZimmetTutanagi.Dock = DockStyle.Fill;                  
                    this.repVwZimmetTutanagi.LocalReport.SetParameters(rpTarih);
                    this.repVwZimmetTutanagi.LocalReport.SetParameters(rpTitle);
                    this.repVwZimmetTutanagi.LocalReport.SetParameters(rpIsim);
                    ReportParameter rpmesaj = new ReportParameter("MesajParametresi",zimmetTutanagi.Mesaj);
                    ReportParameter rpteslimeden = new ReportParameter("TeslimEdenParametresi",zimmetTutanagi.TeslimEden);
                    ReportParameter rpteslimalan = new ReportParameter("TeslimAlanParametresi",zimmetTutanagi.TeslimAlan);
                    this.repVwZimmetTutanagi.LocalReport.SetParameters(rpmesaj);
                    this.repVwZimmetTutanagi.LocalReport.SetParameters(rpteslimeden);
                    this.repVwZimmetTutanagi.LocalReport.SetParameters(rpteslimalan);
                    break;
                case 4:
                    this.Text = "Stok Raporu";
                    repVwStokRaporu.Visible = true;
                    repVwStokRaporu.Dock = DockStyle.Fill;
                    this.repVwStokRaporu.LocalReport.SetParameters(rpTarih);
                    this.repVwStokRaporu.LocalReport.SetParameters(rpTitle);
                    this.repVwStokRaporu.LocalReport.SetParameters(rpIsim);                   
                    break;
                case 5:
                    this.Text = "Ürün Hareket Raporu";
                    repVwStokHareket.Visible = true;
                    repVwStokHareket.Dock = DockStyle.Fill;
                    this.repVwStokHareket.LocalReport.SetParameters(rpTarih);
                    this.repVwStokHareket.LocalReport.SetParameters(rpTitle);
                    this.repVwStokHareket.LocalReport.SetParameters(rpIsim);
                    break;
            }
                      
            this.repVwKisiZimmet.RefreshReport();
            this.repVwDepartmanZimmet.RefreshReport();
            this.repVwZimmetTutanagi.RefreshReport();
            this.repVwStokRaporu.RefreshReport();
            this.repVwStokHareket.RefreshReport();
        }
        ReportParameter rpTarih;
        ReportParameter rpTitle;
        ReportParameter rpIsim;
        private void RaporuAlanBilgileri()
        {

            rpTarih = new ReportParameter("TarihParametresi", DateTime.Now.ToShortDateString());
            rpTitle = new ReportParameter("TitleParametresi", dgVUser.SelectedRows[0].Cells[2].Value.ToString() +
               "-" + dgVUser.SelectedRows[0].Cells[3].Value.ToString());
            rpIsim = new ReportParameter("IsimParametresi", dgVUser.SelectedRows[0].Cells[0].Value.ToString() + " " +
               dgVUser.SelectedRows[0].Cells[1].Value.ToString());

        }

        private void repVwKisiZimmet_Load(object sender, EventArgs e)
        {

        }
    }
}
