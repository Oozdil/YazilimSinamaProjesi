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
    public partial class HakkindaForm : Form
    {
        public HakkindaForm()
        {
            InitializeComponent();
        }
        string mesaj;
        private void HakkindaForm_Load(object sender, EventArgs e)
        {
            richtxBxMessage.Clear();
            mesaj = "Bu proje Orçun ÖZDİL (172803065) ve Ergen Altıparmak (162803058) tarafından, " +
                "Dr. Emin BORANDAĞ danışmanlığında YZM SINAMA dersi kapsamında hazırlanmıştır. Tüm hakları saklıdır 2018.";
            btnClose.Visible = false;
            this.Focus();
        }
        int counter = 0;
        private void timerMessage_Tick(object sender, EventArgs e)
        {
            if (richtxBxMessage.Text.Length < mesaj.Length)
            {
                if (counter % 5 == 0)
                    richtxBxMessage.Text = mesaj.Substring(0, (richtxBxMessage.Text.Length + 1));
            }
            else
            {
                btnClose.Visible = true;
                picBxLogo.Visible = true;
                timerMessage.Enabled = false;
                this.Focus();
            }
            counter++;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
