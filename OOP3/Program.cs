using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface lerde o interface i implemente eden clasın referansını tutabiliyor

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            Console.WriteLine("Başvuru yapılıyor");
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //istediğimiz kadar değer gönderebiliriz
            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager,ihtiyacKrediManager ,konutKrediManager,tasitKrediManager};
            basvuruManager.KrediOnBilgilendirmesi(krediler);


        }
    }
}
