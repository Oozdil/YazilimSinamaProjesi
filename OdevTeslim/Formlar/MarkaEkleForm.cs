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
    public partial class MarkaEkleForm : Form
    {
        public MarkaEkleForm()
        {
            InitializeComponent();
        }

        private void MarkaEkleForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSeti.MarkaTBL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.markaTBLTableAdapter1.Fill(this.projeDataSeti.MarkaTBL);
           

        }

        private void linkLblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            string marka = txBxMarka.Text.Trim().ToUpper();

            if (marka == "")
            {
                MessageBox.Show("Marka bilgisi boş olamaz");
                return;
            }
            bool zatenVar = false;

           for(int i=0;i<dgVMarkalar.RowCount;i++)
            {
                if (dgVMarkalar.Rows[i].Cells[1].Value.ToString() == marka)
                    zatenVar = true;
            }

            if(zatenVar)
            MessageBox.Show("Marka zaten mevcut!");
            else
            {
                MarkaEkle();
            }
        }
        Insert insertIslemi;
        private void MarkaEkle()
        {
            insertIslemi = new Insert();
            insertIslemi.Marka(txBxMarka.Text.Trim().ToUpper());
            MessageBox.Show("Marka eklendi!");
            this.markaTBLTableAdapter1.Fill(this.projeDataSeti.MarkaTBL);
        }

        private void MarkaEkleForm_Paint(object sender, PaintEventArgs e)
        {
            //formun etrafına kırmızı çerçeve çizer
            Pen pen = new Pen(Color.Red);
            pen.Width = 12.0F;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, ((Form)sender).Width - 1,
                ((Form)sender).Height - 1));
        }
    }
}
