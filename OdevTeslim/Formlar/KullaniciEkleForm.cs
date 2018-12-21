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
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm(ZimmetApp za)
        {
            this.zimmetApp = za;
            InitializeComponent();
        }
        public ZimmetApp zimmetApp;
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'userHareketleriDataSet.UserHareketleriView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.userHareketleriViewTableAdapter.Fill(this.userHareketleriDataSet.UserHareketleriView);
            // TODO: Bu kod satırı 'projeDataSeti.UserView' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.userViewTableAdapter1.Fill(this.projeDataSeti.UserView);
            // TODO: Bu kod satırı 'projeDataSeti.RoleTBL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.roleTBLTableAdapter1.Fill(this.projeDataSeti.RoleTBL);
            

            GridviewSekillendir();
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
            this.ForeColor = KullaniciEkleForm.DefaultForeColor;
            this.Font = KullaniciEkleForm.DefaultFont;
            comBxRole.Visible = true;
        }

        /*Kullanıcı listesinden bir personel seçiliyor
         * Eğer zaten kullanıcı ise güncelleme
         * Yeni kullanıcı olacaksa ekleme yapılır
         */
        User OldUser;
        private void dgVPersonel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgVPersonel.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgVPersonel.SelectedRows[0];
                OldUser = new User()
                {
                    PerID = Convert.ToInt32(row.Cells[0].Value.ToString()),
                    UserID = Convert.ToInt32(row.Cells[1].Value.ToString()),
                    UserName = row.Cells[4].Value.ToString(),
                    PassWord = row.Cells[5].Value.ToString(),
                    Aktif = Convert.ToInt32(row.Cells[6].Value.ToString()),
                    RoleName = row.Cells[7].Value.ToString()
                };


                txBxUserName.Text = OldUser.UserName;
                txBxPass.Text = OldUser.PassWord;
                txBxPassRepeat.Text = OldUser.PassWord;
                if (OldUser.Aktif == 1)
                    chBxAktif.Checked = true;
                else
                    chBxAktif.Checked = false;

                comBxRole.SelectedIndex = -1;
                for (int i = 0; i < comBxRole.Items.Count; i++)
                {
                    if (comBxRole.GetItemText(comBxRole.Items[i]) == OldUser.RoleName)
                    {
                        comBxRole.SelectedIndex = i;
                        OldUser.RoleID = i + 1;
                    }
                }


                lblForSeciliPersonel.Text = row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString();
                lblRole.Text = "(" + row.Cells[8].Value.ToString() + " Departmanı)";

                HareketleriDoldur(OldUser.PerID);
            }

        }

        private void HareketleriDoldur(int perID)
        {
            this.userHareketleriViewTableAdapter.FillByPerID(this.userHareketleriDataSet.UserHareketleriView,perID);
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            int selectedRow = 0;
            selectedRow = dgVPersonel.SelectedRows[0].Index;

            if (OldUser.UserID == 0)
            {
                if (txBxPass.Text == txBxPassRepeat.Text && txBxPass.Text.Trim() != "")
                {
                    if (txBxUserName.Text.Trim() != "")
                    {
                        DialogResult result = MessageBox.Show("Kullanıcıyı kaydetmek istediğinize emin misiniz?", "YENİ KAYIT",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            chBxAktif.Checked = true;
                            OldUser.Aktif = 1;
                            OldUser.RoleID = comBxRole.SelectedIndex + 1;
                            OldUser.UserName = txBxUserName.Text;
                            OldUser.PassWord = txBxPass.Text;
                            UserEkle();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı boş olamaz");
                    }
                }
                else
                {
                    MessageBox.Show("Tekrar şifreler uyuşmuyor veya boş");
                }
            }
            else
            {
                UserGuncelle();
            }

            GridviewSekillendir();
            dgVPersonel.Rows[selectedRow].Selected = true;
        }
        //Mevcut kullanıcı güncelleniyor
        Update updateIslemi;
        private void UserGuncelle()
        {
            updateIslemi = new Update(zimmetApp.appUser);

            if (OldUser.UserID > 2)
            {
                if (txBxPass.Text == txBxPassRepeat.Text && txBxPass.Text.Trim() != "")
                {
                    if (txBxUserName.Text.Trim() != "")
                    {
                        DialogResult result = MessageBox.Show("Kullanıcıyı güncellemek istediğinize emin misiniz?", "GÜNCELLEME",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            User newUser = new User()
                            {
                                PerID = OldUser.PerID,
                                UserName = txBxUserName.Text,
                                PassWord = txBxPass.Text,
                                RoleID = comBxRole.SelectedIndex + 1,
                                Aktif = Convert.ToInt32(chBxAktif.Checked)
                            };
                            updateIslemi.User(OldUser, newUser);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı boş olamaz");
                    }
                }
                else
                {
                    MessageBox.Show("Tekrar şifreler uyuşmuyor veya boş");
                }                         
            }
            else
            {
                MessageBox.Show("Sistem admin bilgilerine müdahale edilemez");
            }
        }



        //YEni kullanıcı ekleniyor
        Insert insertIslemi;
        private void UserEkle()
        {
            insertIslemi = new Insert(zimmetApp.appUser);
            insertIslemi.User(OldUser);
        }

        private void GridviewSekillendir()
        {
            this.userViewTableAdapter1.Fill(this.projeDataSeti.UserView);
            dgVPersonel.EnableHeadersVisualStyles = false;
            dgVPersonel.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dgVPersonel.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgVPersonel.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            int rowCounter = 0;
            foreach (DataGridViewRow dgvr in dgVPersonel.Rows)
            {
                if (rowCounter % 2 == 0)
                { dgvr.DefaultCellStyle.BackColor = Color.LightBlue; }
                else
                { dgvr.DefaultCellStyle.BackColor = Color.LightGray; }
                rowCounter++;
            }
        }

      
    }
}
