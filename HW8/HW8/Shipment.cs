using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using HW8.Enums;
using HW8.Helper;
using Newtonsoft.Json;

namespace HW8
{
    [DataContract]
    public class Shipment
    {
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string ShipmentID { get; set; }
        [DataMember]
        public Guid CustomerID { get; set; }

        [JsonIgnore]
        [JsonProperty(PropertyName = "aksdasd")]
        public Customer Customer { get; set; }

        [DataMember]
        public string Status;
        [DataMember]
        public int OrderID { get; set; }

        public Shipment(Guid currentCustomerID, int currentOrderID)
        {
            ShipmentID = new RandomNumberGenerator().GetRndString();
            Address = GetValue.ReadValueFromConsole("Enter shipment address: ");
            Status = GetValue.ReadValueFromConsole("Set status 'Delivered, InProgress, " +
                "Cancelled' for current shipment (press Enter for set InProgress): ", false, true);
            CustomerID = currentCustomerID;
            OrderID = currentOrderID;


            
        }
    }
}
