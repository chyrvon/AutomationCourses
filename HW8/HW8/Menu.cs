using System;
using System.Collections.Generic;
using System.Text;
using HW8.Helper;
using HW8.File;

namespace HW8
{
    public class UserMenu
    {
        public const int ReTry = 5;
        private int _userСhoice;
        private int userСhoice
        {
            get
            {
                return _userСhoice;
            }
            set
            {
                if (1 > value || value > 4)
                {
                    Console.WriteLine($"Input value is incorrect. Exit");
                    _userСhoice = 4;
                }
                else
                {
                    _userСhoice = value;
                }
            }
        }

        public UserMenu(List<Customer> customers, List<Order> orders, List<Shipment> shipments)
        {
            Console.WriteLine("Customers from DB:");
            ShowListToConsole.Shipment(customers, orders, shipments, true);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
          returnToMenu:
            Console.Clear();
            Console.WriteLine("Menu: \n" +
                "1. Create new Shipment\n" +
                "2. Display all Shipments\n" +
                "3. Save and Exit\n\n" +
                "4. Exit\n");
            Console.Write("Select: ");
            userСhoice = GetValue.ReadIntValueFromConsole("", true, 4);
            ProcessingMenu(userСhoice, customers, orders, shipments);
            goto returnToMenu;
        }
        private void ProcessingMenu(int userСhoice, List<Customer> customers, List<Order> orders, List<Shipment> shipments)
        {
            switch (userСhoice)
            {
                case 1:
                    //1. Create new Shipment (customer -> Order -> Shipment)
                    Guid currentCustomerID = new Guid();
                    Console.Clear();
                    Console.WriteLine("Step 1. Add Customer");
                    Customer getCustomerFromConsole = new Customer();
                    Customer verifyCustomer = Customer.VerifyCustomerOnBase(getCustomerFromConsole, customers);

                    if (verifyCustomer != null)
                    {
                        currentCustomerID = verifyCustomer.CustomerID;
                    }
                    else
                    {
                        currentCustomerID = getCustomerFromConsole.CustomerID;
                        customers.Add(getCustomerFromConsole);
                    }
                    ShowListToConsole.Customer(customers);

                    Console.WriteLine("Step 2. Add Order: ");
                    Order getOrderFromConsole = new Order();
                    int currentOrderID = getOrderFromConsole.OrderID;
                    orders.Add(getOrderFromConsole);
                    //ShowListToConsole.Order(orders);

                    Console.WriteLine("Step 3. Create Shipment: ");
                    shipments.Add(new Shipment(currentCustomerID, currentOrderID));
                    break;
                case 2:
                    //2. Display all Shipments
                    Console.Clear();
                    bool isDisplayOrderInfo = false;
                    if (GetValue.ReadIntValueFromConsole("Is show Order info in Shipments? (Yes - 2, No - 1):", true, 2) == 2)
                    {
                        isDisplayOrderInfo = true;
                    }
                    ShowListToConsole.Shipment(customers, orders, shipments, isDisplayOrderInfo);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 3:
                    //3. Save and Exit
                    Console.Clear();
                    WorkWithDB.WriteCustomers(customers);
                    WorkWithDB.WriteOrders(orders);
                    WorkWithDB.WriteShipments(shipments);
                    Console.WriteLine("Data saved successfully. Press any key to exit");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 4:
                default:
                    //4. Exit
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
