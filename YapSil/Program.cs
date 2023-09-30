using System;

namespace YapSil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cars car1 = new Cars();
            //Cars car2 = new Cars();
            //Cars[] cars = new Cars[] { car1,car2};
            //car1.Id = 1;
            //car1.CarName = "5 Serie";
            //car1.CarBrand = "Bmw";
            //car1.CarPrice = 60000.00;

            //car2.Id = 2;
            //car2.CarName = "S Classe";
            //car2.CarBrand = "Mercedes";
            //car2.CarPrice = 90000.00;



            //foreach (Cars item in cars)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.CarName);
            //    Console.WriteLine(item.CarBrand);
            //    Console.WriteLine(item.CarPrice);
            //    Console.WriteLine("-----------");
            //}

            //Product product1 = new Product();
            //Product product2 = new Product();
            //product1.ProductId = 1;
            //product1.ProductCategory = "Phone";
            //product1.ProductName = "Galaxy S22 Ultra";
            //product1.PriceProduct = 1250;

            //product2.ProductId = 2;
            //product2.ProductCategory = "Computer";
            //product2.ProductName = "The best new pc";
            //product2.PriceProduct = 3499.50;

            //Product[] product = new Product[] { product1, product2 };

            //for (int i = 0; i < product.Length; i++)
            //{
            //    Console.WriteLine(product[i].ProductName);
            //    Console.WriteLine(product[i].PriceProduct);
            //    Console.WriteLine(product[i].ProductCategory);
            //    Console.WriteLine("------------");
            //}

            //Console.WriteLine("----------New------------");

            //foreach (Product products in product)
            //{
            //    Console.WriteLine(products.ProductName);
            //    Console.WriteLine(products.PriceProduct);
            //    Console.WriteLine(products.ProductCategory);
            //    Console.WriteLine("------------");
            //}

            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Bmw 740Ld";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Mercedes S Klasse";

            Product[] products = new Product[]{product1 , product2};


            foreach (Product productler in products)
            {
                Console.WriteLine(productler.ProductId);
                Console.WriteLine("-----------");
                Console.WriteLine(productler.ProductName);
            }

            Console.WriteLine("-----------------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductId);
                Console.WriteLine("----");
                Console.WriteLine(products[i].ProductName);
                Console.WriteLine("----------");
            }





        }
    }

    //class Cars
    //{
    //    public int Id { get; set; }
    //    public string CarName { get; set; }
    //    public string CarBrand { get; set; }
    //    public double CarPrice { get; set; }
    //}

    class Product
    {
        public int ProductId { get; set; }
        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public double PriceProduct { get; set; }
    }
}
