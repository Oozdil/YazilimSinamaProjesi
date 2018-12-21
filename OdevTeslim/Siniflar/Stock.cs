using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTeslim.Siniflar
{
    public class Stock:Urun
    {
        public int StokID { get; set; }
        public int UrunID { get; set; }
        public string Fiyat { get; set; }
        public int TedarikciID { get; set; }
        public string FaturaTarihi { get; set; }
        public string FaturaNo { get; set; }
        public int StokDurumID { get; set; }
        public int ZimmetliID { get; set; }
    }
}
