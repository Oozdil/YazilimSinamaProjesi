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

namespace OdevTeslim
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokHareketi stokHareketi = new StokHareketi()
            {
                DurumID = 1,
                HareketTipi = 1,
                KimdenID = 1,
                 KimeID=2,
                StokID = 12,
                Tarih = "test",
                UserID = 1
            };

            Update update = new Update();
            update.Stock(stokHareketi);
        }
    }
}
