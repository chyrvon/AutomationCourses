using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using HW8.Helper;

namespace HW8
{
    [DataContract]
    public class Product
    {
        private int _sumPrice;
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int SumPrice
        {
            get
            {
                return _sumPrice = Price * Amount;
            }
            set
            {
                if (value > 0)
                {
                    _sumPrice = value;
                }
                else
                {
                    _sumPrice = 1;
                }
            }
        }
        public Product()
        {
            ProductName = GetValue.ReadValueFromConsole("Enter name of Product: ");
            Amount = GetValue.ReadIntValueFromConsole("Enter Amount: ");
            Price = GetValue.ReadIntValueFromConsole("Enter Price: ");
        }
    }

}
