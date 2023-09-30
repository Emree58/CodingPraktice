using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrakticeClassMetotDemo
{
    class CustomerManager
    {
        public void Update(Customer customer)
        {
            Console.WriteLine($"The following customer is updated:{customer.Name}");
        }
    }
}
