using System;
using System.Collections.Generic;
using System.Text;

namespace HW8
{
    class Order
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string TypeProduct { get; set; }
        public List<Customer> ListCustomer { get; set; }

        public Order (string typeProduct, int amount, List<Customer> listCustomer)
        {
            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            Id = randomNumberGenerator.GetRndInt();
            TypeProduct = typeProduct;
            Amount = amount;
            ListCustomer = listCustomer;
        }

    }
}
