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
    public class Update: DbIslemler
    {
        public User AppUser { get; set; }
        public Update()
        {

        }
        public Update(User _u)
        {
            this.AppUser = _u;
        }

        public void User(User oldUser,User newUser)
        {            
            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "UPDATE UserTBL SET UserName=@UserName, PassWord=@PassWord, RoleID=@RoleID, Aktif=@Aktif" +
                        " WHERE PerID=@PerID";
                    command.Parameters.AddWithValue("@UserName", newUser.UserName);
                    command.Parameters.AddWithValue("@PassWord", newUser.PassWord);
                    command.Parameters.AddWithValue("@RoleID", newUser.RoleID);
                    command.Parameters.AddWithValue("@Aktif", newUser.Aktif);
                    command.Parameters.AddWithValue("@PerID", oldUser.PerID);
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
                            UserLog(oldUser,newUser);
                    }
                }
            }

        }
        public void UserLog(User u_old,User u_new)
        {
            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT into UserHareketTBL (PerID,UserID,Tarih,IslemLog) VALUES" +
                        "(@PerID,@UserID,@Tarih,@IslemLog)";
                    command.Parameters.AddWithValue("@PerID", u_new.PerID);
                    command.Parameters.AddWithValue("@UserID", AppUser.UserID);
                    command.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());                
                    command.Parameters.AddWithValue("@IslemLog", u_old.Detay()+"-->"+u_new.Detay());
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

        public int Stock(StokHareketi sh)
        {
            using (conn)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    if(sh.KimeID==0)
                    {
                        command.CommandText = "UPDATE StokTBL SET StokDurumID=@StokDurumID,ZimmetliID=NULL WHERE StokID=@StokID;";
                        if(sh.KimdenID==0)
                        {
                            command.CommandText += "INSERT into StokHareketleriTBL (StokID,StokHareketTipiID,Tarih,UserID ,KimdenID,KimeID) " +
                        "VALUES (@StokID,@StokHareketTipiID,@Tarih,@UserID ,NULL,NULL)";
                        }
                        else
                        {
                            command.CommandText += "INSERT into StokHareketleriTBL (StokID,StokHareketTipiID,Tarih,UserID ,KimdenID,KimeID) " +
                       "VALUES (@StokID,@StokHareketTipiID,@Tarih,@UserID ,@KimdenID,NULL)";
                        }
                    }                    
                    else
                    {
                        command.CommandText = "UPDATE StokTBL SET StokDurumID=@StokDurumID,ZimmetliID=@ZimmetliID  WHERE StokID=@StokID;";
                        if (sh.KimdenID == 0)
                        {
                            command.CommandText += "INSERT into StokHareketleriTBL (StokID,StokHareketTipiID,Tarih,UserID ,KimdenID,KimeID) " +
                        "VALUES (@StokID,@StokHareketTipiID,@Tarih,@UserID ,NULL,@KimeID)";
                        }
                        else
                        {
                            command.CommandText += "INSERT into StokHareketleriTBL (StokID,StokHareketTipiID,Tarih,UserID ,KimdenID,KimeID) " +
                       "VALUES (@StokID,@StokHareketTipiID,@Tarih,@UserID ,@KimdenID,@KimeID)";
                        }
                    }
                    command.CommandText += ";SELECT SCOPE_IDENTITY()";
                    command.Parameters.AddWithValue("@StokDurumID", sh.DurumID);
                    command.Parameters.AddWithValue("@ZimmetliID", sh.KimeID);
                    command.Parameters.AddWithValue("@StokID", sh.StokID);
                    command.Parameters.AddWithValue("@StokHareketTipiID", sh.HareketTipi);
                    command.Parameters.AddWithValue("@Tarih", sh.Tarih);
                    command.Parameters.AddWithValue("@UserID", sh.UserID);
                    command.Parameters.AddWithValue("@KimdenID", sh.KimdenID);
                    command.Parameters.AddWithValue("@KimeID", sh.KimeID);

                    int sonKayit = 0;
                    try
                    {
                        conn.Open();
                        sonKayit = Convert.ToInt32(command.ExecuteScalar()) ;
                      
                    }
                    catch (SqlException EX)
                    {
                        MessageBox.Show(EX.ToString(), "HATA!");
                    }
                    finally
                    {
                        conn.Close();                        
                    }
                    return sonKayit;
                }
            }

        }

    }
}
