using OdevTeslim.Siniflar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevTeslim.Veritabani
{
    public class Insert : DbIslemler
    {
        public User AppUser { get; set; }
        public Insert()
        {

        }
        public Insert(User _u)
        {
            this.AppUser = _u;
        }

        public void Department(string DepName)
        {
            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT into DepartmanTBL (DepIsim) VALUES (@depName)";
                    command.Parameters.AddWithValue("@depName", DepName);

                    try
                    {
                        conn.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException EX)
                    {
                        MessageBox.Show(EX.ToString(), "HATA!");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }
        public void Personel(Personel p)
        {
            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT into PersonelTBL (PerIsim,PerSoyisim,PerTelefon,PerAdres,PerDepID) VALUES " +
                        "(@PerIsim,@PerSoyisim,@PerTelefon,@PerAdres,@PerDepID)";
                    command.Parameters.AddWithValue("@PerIsim", p.PerIsim);
                    command.Parameters.AddWithValue("@PerSoyisim", p.PerSoyisim);
                    command.Parameters.AddWithValue("@PerTelefon", p.PerTelefon);
                    command.Parameters.AddWithValue("@PerAdres", p.PerAdres);
                    command.Parameters.AddWithValue("@PerDepID", p.PerDepID);
                    try
                    {
                        conn.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException EX)
                    {
                        MessageBox.Show(EX.ToString(), "HATA!");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }
        public void User(User u)
        {
            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT into UserTBL (PerID,UserName,PassWord,RoleID,Aktif) VALUES" +
                        "(@PerID,@UserName,@PassWord,@RoleID,@Aktif)";
                    command.Parameters.AddWithValue("@PerID", u.PerID);
                    command.Parameters.AddWithValue("@UserName", u.UserName);
                    command.Parameters.AddWithValue("@PassWord", u.PassWord);
                    command.Parameters.AddWithValue("@RoleID", u.RoleID);
                    command.Parameters.AddWithValue("@Aktif", u.Aktif);
                    int recordsAffected = 0;
                    try
                    {
                        conn.Open();
                        recordsAffected = command.ExecuteNonQuery();

                    }
                    catch (SqlException EX)
                    {
                        MessageBox.Show(EX.ToString(), "HATA!");
                    }
                    finally
                    {
                        conn.Close();
                        if (recordsAffected > 0)
                            UserLog(u);
                    }
                }
            }

        }
        public void UserLog(User u)
        {
            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT into UserHareketTBL (PerID,UserID,Tarih,IslemLog) VALUES" +
                        "(@PerID,@UserID,@Tarih,@IslemLog)";
                    //"((SELECT TOP (1) UserID FROM UserTBL ORDER BY UserID DESC ),@UserID,@Tarih,@IslemLog)";
                    command.Parameters.AddWithValue("@PerID", u.PerID);
                    command.Parameters.AddWithValue("@UserID", AppUser.UserID);
                    command.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());
                    command.Parameters.AddWithValue("@IslemLog", "Yeni Kayıt");
                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException EX)
                    {
                        MessageBox.Show(EX.ToString(), "HATA!");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        public void Stock(Stock s, int adet)
        {
            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT into StokTBL (UrunID,AlisFiyati,TedarikciID,FaturaTarihi,FaturaNo,StokDurumID) " +
                        "VALUES (@UrunID,@AlisFiyati,@TedarikciID,@FaturaTarihi,@FaturaNo,@StokDurumID);" +
                        "INSERT into StokHareketleriTBL (StokID,StokHareketTipiID,Tarih,UserID) " +
                        "VALUES ((SELECT TOP (1) StokID FROM StokTBL  order by StokID desc),@StokHareketTipiID,@Tarih,@UserID)";
                    command.Parameters.AddWithValue("@UrunID", s.UrunID);
                    command.Parameters.AddWithValue("@AlisFiyati", s.Fiyat);
                    command.Parameters.AddWithValue("@TedarikciID", s.TedarikciID);
                    command.Parameters.AddWithValue("@FaturaTarihi", s.FaturaTarihi);
                    command.Parameters.AddWithValue("@FaturaNo", s.FaturaNo);
                    command.Parameters.AddWithValue("@StokDurumID", s.StokDurumID);
                    command.Parameters.AddWithValue("@StokHareketTipiID", 1);
                    command.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());
                    command.Parameters.AddWithValue("@UserID", this.AppUser.UserID);
                    try
                    {
                        conn.Open();
                        for (int i = 0; i < adet; i++)
                            command.ExecuteNonQuery();
                    }
                    catch (SqlException EX)
                    {
                        MessageBox.Show(EX.ToString(), "HATA!");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        public void Tedarikci(Tedarikci t)
        {
           
            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT into TedarikciTBL (TedarikciIsim,TedarikciAdres) " +
                        "VALUES (@TedarikciIsim,@TedarikciAdres)";
                    command.Parameters.AddWithValue("@TedarikciIsim", t.TedarikciAdi);
                    command.Parameters.AddWithValue("@TedarikciAdres", t.Adres);

                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException EX)
                    {
                        MessageBox.Show(EX.ToString(), "HATA!");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }
        public void Urun(Urun u)
        {
            
            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT into UrunTBL (UrunIsim,UrunMarkaID,UrunKategoriID) " +
                        "VALUES (@UrunIsim,@UrunMarkaID,@UrunKategoriID)";
                    command.Parameters.AddWithValue("@UrunIsim", u.Isim);
                    command.Parameters.AddWithValue("@UrunMarkaID", u.MarkaID);
                    command.Parameters.AddWithValue("@UrunKategoriID", u.KategoriID);
                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException EX)
                    {
                        MessageBox.Show(EX.ToString(), "HATA!");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }
        public void Marka(string markaAdi)
        {

            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT into MarkaTBL (Marka) " +
                        "VALUES (@Marka)";
                    command.Parameters.AddWithValue("@Marka",markaAdi );
                    
                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException EX)
                    {
                        MessageBox.Show(EX.ToString(), "HATA!");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }
        public void Kategori(string kategoriAdi)
        {

            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT into KategoriTBL (Kategori) " +
                        "VALUES (@Kategori)";
                    command.Parameters.AddWithValue("@Kategori", kategoriAdi);

                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException EX)
                    {
                        MessageBox.Show(EX.ToString(), "HATA!");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

        }
        
    }
}
