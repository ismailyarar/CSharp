using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine(" sepete eklendi :" +product.Name);
        }

        public void Ekle2(int Id, string Name,double Price,string Description)
        {
            Console.WriteLine("sepete eklendi:" + Name);
        }
    }
}
