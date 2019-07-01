using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HW8;

namespace HW8.Helper
{
    public class ShowListToConsole
    {
        public static void Customer(List<Customer> customers, int numberCustomer = 0)
        {
            Console.WriteLine("FirstName    \t\t LastName \t\t Phone \t\t CustomerID");
            if (numberCustomer == 0)
            {
                foreach (var element in customers)
                {
                    Console.WriteLine($"{element.FirstName,-15} \t {element.LastName,-15} " +
                        $"\t {element.Phone,-10} \t {element.CustomerID,-16}");
                }
            }
            else
            {
                var item = customers[numberCustomer];
                Console.WriteLine($"{item.FirstName,-15} \t {item.LastName,-15} " +
                    $"\t {item.Phone,-10} \t {item.CustomerID,-16}");
            }
        }

        public static void Order(List<Order> orders, int numberOrder = 0)
        {
            Console.WriteLine("OrderID \t ProductName     \t Amount \t Price      \t SumPrice");
            if (numberOrder == 0)
            {
                foreach (var element in orders)
                {
                    var item = element.Product[0];
                    Console.WriteLine($"{element.OrderID,-7} \t {item.ProductName,-15} " +
                        $"\t {item.Amount,-10} \t {item.Price,-10} \t {item.SumPrice,-10}");
                }
            }
            else
            {
                var item = orders[numberOrder].Product[0];
                Console.WriteLine($"{orders[numberOrder].OrderID,-7} \t {item.ProductName,-15} " +
                    $"\t {item.Amount,-10} \t {item.Price,-10} \t {item.SumPrice,-10}");
            }
        }
        public static void Shipment(List<Customer> customers, List<Order> orders, List<Shipment> shipments, bool isDisplayOrderInfo = false)
        {
            
            Console.Clear();
            Console.WriteLine("Display Shipments");
            int i = 1;
            if (!isDisplayOrderInfo)
            {
                Console.WriteLine("N   Adress \t\t\t ShipmentID \t\t CustomerID \t\t\t\t Status \t OrderID \t SumPrice");
                foreach (var element in shipments)
                {
                    List<Order> orderSelected = new List<Order>();
                    orderSelected = orders.Where(x => x.OrderID.Equals(element.OrderID)).ToList();
                    Console.WriteLine($"{i++}   {element.Address,-20} \t {element.ShipmentID,-20} " +
                        $"\t {element.CustomerID,-35} \t {element.Status,-12} \t {element.OrderID,-10} " +
                        $"\t {orderSelected[0].Product[0].SumPrice,-10}");
                }
            }
            else
            {
                foreach (var element in shipments)
                {
                    Console.WriteLine($"Number: {i++}");
                    Console.WriteLine($"Adress: {element.Address}");
                    Console.WriteLine($"ShipmentID: {element.ShipmentID}");
                    Console.WriteLine($"Status: {element.Status}");
                    ShowCustomerInfo(element.CustomerID, customers);
                    ShowOrderInfo(element.OrderID, orders);
                    Console.WriteLine("---------------------------------");
                }
            }
        }

        public static void ShowCustomerInfo(Guid customerID, List<Customer> customers)
        {
            List<Customer> customerSelected = new List<Customer>();
            customerSelected = customers.Where(x => x.CustomerID.Equals(customerID)).ToList();
            Console.WriteLine($"CustomerID: {customerSelected[0].CustomerID}");
            Console.WriteLine($"First Name: {customerSelected[0].FirstName}");
            Console.WriteLine($"Last Name: {customerSelected[0].LastName}");
            Console.WriteLine($"Phone: {customerSelected[0].Phone}");
        }
        public static void ShowOrderInfo(int orderID, List<Order> orders)
        {
            List<Order> orderSelected = new List<Order>();
            orderSelected = orders.Where(x => x.OrderID.Equals(orderID)).ToList();
            var productSelected = orderSelected[0].Product[0];
            Console.WriteLine($"OrderID: {orderSelected[0].OrderID}");
            Console.WriteLine($"Product: {productSelected.ProductName}");
            Console.WriteLine($"Amount: {productSelected.Amount}");
            Console.WriteLine($"Price: {productSelected.Price}");
            Console.WriteLine($"SumPrice: {productSelected.SumPrice}");
        }
    }
}
