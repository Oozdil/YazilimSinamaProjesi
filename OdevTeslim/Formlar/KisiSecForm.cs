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
    public partial class KisiSecForm : Form
    {
        
        public KisiSecForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            secilenPersonel = null;
            this.Close();
        }

        private void KisiSecForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSeti.PersonelView_1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelView_1TableAdapter1.Fill(this.projeDataSeti.PersonelView_1);
          


        }

        //Datagridviewdan personel seçiyoruz
        public Personel secilenPersonel;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKisiler.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvKisiler.SelectedRows[0];
                lblSecilenPersonel.Text = row.Cells[1].Value.ToString() +" "+ row.Cells[2].Value.ToString() +
                    " (" + row.Cells[12].Value.ToString() + " Departmanı)";
                secilenPersonel = new Personel() {
                     PerID=Convert.ToInt32(row.Cells[0].Value.ToString()),
                      PerIsim= row.Cells[1].Value.ToString(),
                       PerSoyisim= row.Cells[2].Value.ToString() ,
                        PerDepartmanAdi= row.Cells[12].Value.ToString()
                };

            }
        }

        private void KisiSecForm_Paint(object sender, PaintEventArgs e)
        {
            //formun etrafına beyaz çerçeve çizer
            Pen pen = new Pen(Color.White);
            pen.Width = 12.0F;
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, ((Form)sender).Width - 1,
                ((Form)sender).Height - 1));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
