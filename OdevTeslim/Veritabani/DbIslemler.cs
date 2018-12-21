using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTeslim.Veritabani
{
    public class DbIslemler
    {
        public string ConnectionString;
        public SqlConnection conn;

        public DbIslemler()
        {
            /***************************************
             * DİKKAT
             * ConnectionString'i makine 
             * konfigurasyonunuza göre değiştiriniz
             ****************************************/
            ConnectionString = "Server= .\\SQL2014EXPRESS; " +//Server Adı
                "Database= YzmSnmProje; " +//Db adını değiştirmeyiniz
                "Integrated Security=True;";//Güvenlik seçeneği
            conn = new SqlConnection(ConnectionString);
        }
    }
}
