using System;
using System.Collections.Generic;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Order> orders = new List<Order>();
            string nameCustomer;
            string typeProduct;
            int amount;
            bool withOrder;

            Shipment.Statuses status;

            Console.Write("Enter Name of customer: ");
            nameCustomer = Console.ReadLine();
            customers.Add(new Customer(nameCustomer));
                        
            Console.Write("Enter type of product: ");
            typeProduct = Console.ReadLine();


            Console.Write($"Enter amount of {typeProduct}: ");
            Int32.TryParse(Console.ReadLine(), out amount);
            
            orders.Add(new Order(typeProduct, amount, customers));

            List<Shipment> shipments = new List<Shipment>();
            
            Console.Write("Enter address to ship: ");
            string address = Console.ReadLine();

            Console.Write("Set status ship (shipped - 1, delivered - 2): ");

            string valueStatus = Console.ReadLine();
            Enum.TryParse(valueStatus, true, out status);
            switch (status)
            {
                case Shipment.Statuses.shipped:
                    valueStatus = Shipment.Statuses.shipped.ToString();
                    break;
                case Shipment.Statuses.delivered:
                    valueStatus = Shipment.Statuses.delivered.ToString();
                    break;
                default:
                    valueStatus = Shipment.Statuses.shipped.ToString();
                    break;
            }

            shipments.Add(new Shipment(address, orders, valueStatus));

            Console.WriteLine("Do you want Shipments print with Order? (Yes - 1, No - 0): ");
            Int32.TryParse(Console.ReadLine(), out int value);
            
            if (value == 1)
                withOrder = true;
            else withOrder = false;

            OrderPrint ordersPrint = new OrderPrint(withOrder, shipments);
            Console.ReadLine();
        }
    }
}