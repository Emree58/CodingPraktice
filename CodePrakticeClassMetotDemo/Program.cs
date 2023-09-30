using System;

namespace CodePrakticeClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Johnny";

            Customer customer2 = new Customer();
            customer2.Name = "Pony";

            //Customer[] customer = new Customer[] {customer1,customer2};

            CustomerManager customerManager = new CustomerManager();

            customerManager.Update(customer1);
            customerManager.Update(customer2);
            customerManager.Update(customer1);
            customerManager.Update(customer2);
        }


    }
}
