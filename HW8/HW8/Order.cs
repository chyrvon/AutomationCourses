using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
namespace HW8
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public List<Product> Product;

        public Order ()
        {
            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            OrderID = randomNumberGenerator.GetRndInt();
            Product = new List<Product>() { new Product() };
    }

    }
}
