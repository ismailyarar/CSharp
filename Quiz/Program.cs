using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Samsung Akıllı Telefon";
            product1.Price = 1250;
            product1.Score = "*****";

            Product product2 = new Product();
            product2.Name = "General Mobile Akıllı Telefon";
            product2.Price = 1400;
            product2.Score = "**";

            Product product3 = new Product();
            product3.Name = "Oppo A73 Akıllı Telefon";
            product3.Price = 1500;
            product3.Score = "****";


            Product[] products = new Product[]{
                     product1,product2,product3
                };

            int x = 0;
            while (x<products.Length)
            {
                Console.WriteLine(products[x].Name + "-" + products[x].Price + "-" + products[x].Score);
                x++;
            }

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name + "-" + products[i].Price + "-" + products[i].Score);
            }

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + "-" + product.Price + "-" + product.Score);
            }
        }
    }
    class Product
    {
        //özellikleri
        //score ürün puanlaması
        public string Name { get; set; }
        public int Price { get; set; }
        public string Score { get; set; }
    }
}
