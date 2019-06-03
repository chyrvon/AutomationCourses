using System;
using System.Collections.Generic;
using System.Text;

namespace HW8
{
    class Shipment
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public string Status;
        public List<Order> ListOrder { get; set; }
        
        public enum Statuses
        {
            shipped = 1,
            delivered
        }

        public Shipment()
        {
        }

        public Shipment (string address, List<Order> listOrder, string status)
        {
            Id = new RandomNumberGenerator().GetRndString();
            Address = address;
            ListOrder = listOrder;
            Status = status.ToString();
        }
    }
}
