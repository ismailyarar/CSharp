using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Telefon";
            product1.Price = 15;
            product1.Description = "Akıllı Telefon";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Buzdolabı";
            product2.Price = 19;
            product2.Description = "No Frost";

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Televizyon";
            product3.Price = 12.4;
            product3.Description = "Philips Smart TV";

            Product product4 = new Product();
            product4.Id = 4;
            product4.Name = "Laptop";
            product4.Price = 126;
            product4.Description = "Ipad";

            Product[] products = new Product[] { product1,product2,product3,product4};

            foreach (Product product in products)
            {
                //Console.WriteLine("Id: " + product.Id +" "+ "Name:" + product.Name +" "+ "Price:" + product.Price +" " +"Description:" + product.Description);
                Console.WriteLine("Id: "+product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("Description: " + product.Description);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("-----------Metotlar--------------");
            //örneğini oluşturduk
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);
            sepetManager.Ekle(product4);

            sepetManager.Ekle2(1, "Tv Ünitesi", 52, "Tv");
        }
    }
}
//DRY,Clean Code-Best Practice
