using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTeslim.Siniflar
{
    public class User:Personel
    {          
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int Aktif { get; set; }
        public string Detay()
        {
            string detay = this.UserName+" "+this.PassWord+" "+this.RoleID.ToString()+" "+this.Aktif.ToString();
            return detay;

        }
    }
}
