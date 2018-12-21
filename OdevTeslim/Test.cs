using NUnit.Framework;
using OdevTeslim.Siniflar;
using OdevTeslim.Veritabani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTeslim
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void KullaniciGirisTesti()
        {
            ZimmetApp zimmetApp;
            zimmetApp = new ZimmetApp();
            Login login = new Login("oozdil", "123", zimmetApp);

            if (zimmetApp.appUser != null)
            {
                Assert.Pass("Giriş Başarılı");
            }
            else
            {
                Assert.Fail("Giriş Başarısız");
            }
        }

        [Test]
        public void KullaniciEklemeTesti()
        {
                ZimmetApp zimmetApp;
                zimmetApp = new ZimmetApp();
                zimmetApp.appUser = new User() { UserID = 1 };
                User newUser = new User()
                {
                    PerID = 6,
                    UserName = "test",
                    PassWord = "123",
                    RoleID = 3
                };
                Insert insertIslemi;
                insertIslemi = new Insert(zimmetApp.appUser);
                insertIslemi.User(newUser);
                Assert.Pass("Kullanıcı Ekleme Başarılı");
       
        }

        [Test]
        public void UrunEklemeTesti()
        {
            Insert insertIslemi;
            Urun urun = new Urun()
            {
                Isim = "Test İle Eklenen",
                KategoriID = 1,
                MarkaID = 1
            };
            insertIslemi = new Insert();
            insertIslemi.Urun(urun);
            Assert.Pass("Ürün Ekleme Başarılı");
        }

        [Test]
        public void StokEklemeTesti()
        {
            Insert insertIslemi;
            User user = new User() { UserID=1};
            insertIslemi = new Insert(user);
            Stock stock = new Stock()
            {
                UrunID = 12,
                Fiyat = "1000",
                FaturaNo = "Test Fatura",
                FaturaTarihi = "19.12.2018",
                TedarikciID = 1,
                StokDurumID = 1

            };
            insertIslemi.Stock(stock, 1);
            Assert.Pass("Stok Ekleme Başarılı");
        }

        [Test]
        public void ZimmetAtamaTesti()
        {
            StokHareketi stokHareketi = new StokHareketi()
            {
                DurumID = 2,
                HareketTipi = 2,
                KimdenID = 0,
                KimeID = 1,
                StokID = 1022,
                Tarih = "19.12.2018",
                UserID = 1
            };
            Update update = new Update();
            int sonKayit = update.Stock(stokHareketi);
            Assert.Pass(sonKayit.ToString()+" Numaralı Stok Ekleme Başarılı");
        }
    }
}
