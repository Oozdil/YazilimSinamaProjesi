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
    public partial class MetroFrameWorkDemoForm : MetroFramework.Forms.MetroForm
    {
        /*
         * Bu form MetroFrameWork kontrollerini
         * örneklemek için eklenmiştir
         */
        public MetroFrameWorkDemoForm()
        {
            InitializeComponent();
        }

        private void MetroFrameWorkDemoForm_Load(object sender, EventArgs e)
        {

        }      

        private void metroBtnDemo_Click(object sender, EventArgs e)
        {

            htmlLabel.Text = "<table width='%100'>";
            foreach (Control c in this.Controls)
            {
                htmlLabel.Text += "<tr><td>" + c.GetType().ToString() + "</td><td>" + c.Name + "</td></tr>";
            }
            htmlLabel.Text += "<table>";
        }
    }
}
