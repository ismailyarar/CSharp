using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -tip güvenli
            
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azaldı");
            }else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("arttı");
            }else
            Console.WriteLine("değişiklik yok");

           

            

        }
    }
}
