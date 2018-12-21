using OdevTeslim.Siniflar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevTeslim.Veritabani
{
    public class Login : DbIslemler
    {
        
        public Login(string username, string password,ZimmetApp app)
        {
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("select * from UserView where UserName like @username and Password = @password and Aktif=1;");
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Connection = conn;
                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                conn.Close();

                bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                if (loginSuccessful)
                {
                    DataTable dt = ds.Tables[0];
                  
                    User user = new User()
                    {
                        PerIsim = dt.Rows[0][1].ToString(),
                        PerSoyisim = dt.Rows[0][2].ToString(),
                        UserName = dt.Rows[0][4].ToString(),
                        PassWord = dt.Rows[0][5].ToString(),                       
                        PerID = Convert.ToInt32(dt.Rows[0][0].ToString()),
                        UserID = Convert.ToInt32(dt.Rows[0][3].ToString()),
                        RoleID = Convert.ToInt32(dt.Rows[0][9].ToString()),
                        RoleName= dt.Rows[0][7].ToString(),
                        Aktif = 1,
                         PerDepID= Convert.ToInt32(dt.Rows[0][10].ToString()),
                          PerDepartmanAdi= dt.Rows[0][8].ToString()
                    };
                    app.appUser = user;
                }
               
            }
        }

    }
}
