using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;

namespace HW8.File
{
    public class WorkWithDB
    {
        public const string PathCustomers = @"..\\..\\..\\..\\customers.json";
        public const string PathOrders = @"..\\..\\..\\..\\orders.json";
        public const string PathShipments = @"..\\..\\..\\..\\shipments.json";
        public static void WriteCustomers(List<Customer> customers)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Customer>));
            using (FileStream fs = new FileStream(PathCustomers, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, customers);
            }
        }
        public static void WriteOrders(List<Order> orders)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(PathOrders, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, orders);
            }
        }
        public static void WriteShipments(List<Shipment> shipments)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Shipment>));
            using (FileStream fs = new FileStream(PathShipments, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, shipments);
            }
        }
        public static List<Customer> ReadCustomers()
        {
            using (FileStream fs = new FileStream(PathCustomers, FileMode.Open))
            {
                List<Customer> readCustomersFromDB;

                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Customer>));
                readCustomersFromDB = (List<Customer>)jsonFormatter.ReadObject(fs);
                return readCustomersFromDB;

                //string str = JsonConvert.SerializeObject(readCustomersFromDB);
                //List<Customer> readCustomersFromDB2 = JsonConvert.DeserializeObject<List<Customer>>(str);
            }

        }
        public static List<Order> ReadOrders()
        {
            using (FileStream fs = new FileStream(PathOrders, FileMode.Open))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Order>));
                List<Order> readOrdersFromDB = (List<Order>)jsonFormatter.ReadObject(fs);
                return readOrdersFromDB;
            }
        }
        public static List<Shipment> ReadShipments()
        {
            using (FileStream fs = new FileStream(PathShipments, FileMode.Open))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Shipment>));
                List<Shipment> readShipmentsFromDB = (List<Shipment>)jsonFormatter.ReadObject(fs);
                return readShipmentsFromDB;
            }
        }
    }
}
