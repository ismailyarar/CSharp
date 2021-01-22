using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 100;
            product1.UnitsInStock = 25;

            //bu şekilde de tanımlama yapabiliriz
            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Lamba", UnitPrice = 125,UnitsInStock=14 };
            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            //Referans tip olduğu için Kamera yazdırdı
            Console.WriteLine(product1.ProductName);

            //değer tip olduğu için 10 yazdırdı
            int sayi = 10;
            productManager.Test(sayi);
            Console.WriteLine(sayi);
            
        }
    }
}
