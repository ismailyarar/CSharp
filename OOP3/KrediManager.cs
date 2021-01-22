using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //I harfi interface olduğunu belli etmek için yazılır
        //interface i kullanan içerisinde ki metodu da içermek zorunda
        //imza aynı ama içerikler farklıysa ebeveyni interface olarak tanımlarız
        void Hesapla();
        //void HarcHesapla();
        //birden fazla metod içerebilir
        //interface şablondur
    }
}
