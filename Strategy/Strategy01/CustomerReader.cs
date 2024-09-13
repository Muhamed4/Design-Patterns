using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy01
{
    public class CustomerReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new []
            {
                new Customer
                {
                    Id = 1,
                    Name = "Mohamed Ahmed Elmahdy",
                    Category = CustomerCategory.Gold
                },
                new Customer
                {
                    Id = 2,
                    Name = "Ibrahim Khalid Elnaggar",
                    Category = CustomerCategory.Silver
                }
            };
        }
    }
}