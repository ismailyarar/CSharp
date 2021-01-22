using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        //new lerken ne verirsek onu alacak
        public void Add(T item)
        {
            //önceki değerleri korumak için oluşturduk
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                //tempArray deki elemanları itemsa geri aldık
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
