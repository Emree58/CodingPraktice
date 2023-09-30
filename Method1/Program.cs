using System;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Bmw 740Ld";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Mercedes S Klasse";
            product2.StokCount = 5;

            Product[] products = new Product[] { product1, product2 };

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product1);
           

            sepetManager.Ekle2("Sandalye", 37.50, 8);

        }
        
    }
}
