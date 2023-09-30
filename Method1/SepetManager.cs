using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Eklendi: " + product.ProductName);
            Console.WriteLine("Stok: " + product.StokCount);
            Console.WriteLine("--------------");
        }

        public void Ekle2(string urunAdi, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Eklendi2: " + urunAdi + " : " + fiyat);
        }
    }
}

// 1.32.55
