using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Başvuran bilgilerini değerlendir
            //Krediyi hesapla
            //Böyle yazarsak Tüm başvurular konutkredisine göre hesaplanır
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //doğrusu
            //istediğimiz kredi tipini gönderebiliriz
            krediManager.Hesapla();

        }

        public void KrediOnBilgilendirmesi(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
