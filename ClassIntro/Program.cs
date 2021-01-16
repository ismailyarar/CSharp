using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "ismail yarar";
            kurs1.IzlenmeOrani = "yüksek";
            kurs1.KursAdi = "Java Programlama Dili";

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "mesut yarar";
            kurs2.IzlenmeOrani = "orta";
            kurs2.KursAdi = "JavaScript Programlama Dili";

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "ahmet yarar";
            kurs3.IzlenmeOrani = "düşük";
            kurs3.KursAdi = "Dart  Dili";

            //Console.WriteLine(kurs1.KursAdi + " -- " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] 
            {
                kurs1,kurs2,kurs3
            };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+"-"+kurs.Egitmen+"-" +kurs.IzlenmeOrani);
            }

        }
    }
    class Kurs
    {
        //özellikleri
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public string IzlenmeOrani { get; set; }
    }
}
