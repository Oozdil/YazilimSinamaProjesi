using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTeslim.Siniflar
{
    public class StokHareketi
    {
        public int StokID { get; set; }
        public int KimdenID { get; set; }
        public int KimeID { get; set; }
        public int UserID { get; set; }
        public int HareketTipi { get; set; }
        public int DurumID { get; set; }
        public string Tarih { get; set; }
       
    }
}
