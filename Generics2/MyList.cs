using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Amac: List<T> generics olmasa manuel nasil yazilirdi.
namespace Generics2
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length +1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}

// ders 4 sonu , constructor istersen bir daha izle veya farkli kaynak ara? OK
// odev 1 izle. iki izlendi ODEV 3 çok karisik generics!! OK
