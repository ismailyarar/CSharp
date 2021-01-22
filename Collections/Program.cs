using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"murat","ismail" };
            //Console.WriteLine(isimler[0]);

            //isimler[2] = "mehmet";

            //hata verdi

            //Collections
            //List<string> isimler2 = new List<string>();
            List<string> isimler2 = new List<string> { "ismail","mehmet"};
            //isimler2.Add("ismail");
            Console.WriteLine( isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine("Ekleme yaptıktan sonra");
            isimler2.Add("musa");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            

        }
    }
}
