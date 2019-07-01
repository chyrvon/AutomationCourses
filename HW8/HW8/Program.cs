using System;
using System.Collections.Generic;
using HW8.File;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Order> orders = new List<Order>();
            List<Shipment> shipments = new List<Shipment>();
            customers = WorkWithDB.ReadCustomers();
            orders = WorkWithDB.ReadOrders();
            shipments = WorkWithDB.ReadShipments();
            UserMenu userMenu = new UserMenu(customers, orders, shipments);
        }
    }
}