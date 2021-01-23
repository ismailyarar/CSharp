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

            IKrediManager esnafKrediManager = new KonutKrediManager();
            //esnafKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { smsLoggerService, fileLoggerService };

            Console.WriteLine("Başvuru yapılıyor");
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager,new DatabaseLoggerService());
            //basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);
            basvuruManager.BasvuruYap(esnafKrediManager,loggers);

            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //istediğimiz kadar değer gönderebiliriz
            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager,ihtiyacKrediManager ,konutKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesi(krediler);

        }
    }
}
