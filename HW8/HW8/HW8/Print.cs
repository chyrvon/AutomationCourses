using System;
using System.Collections.Generic;
using System.Text;

namespace HW8
{
    class OrderPrint
    {
        public OrderPrint(bool printOrder, List<Shipment> shipments)
        {
            switch (printOrder)
            {
                case true:
                    // withOrder
                    shipments.ForEach(x => Console.WriteLine($"Shipment ID: {x.Id}"));
                    shipments.ForEach(x => Console.WriteLine($"Shipment address: {x.Address}"));
                    shipments.ForEach(x => Console.WriteLine($"Shipment status: {x.Status}"));
                    foreach (var x in shipments)
                    {
                        x.ListOrder.ForEach(y => Console.WriteLine($"Order ID: {y.Id}"));
                        x.ListOrder.ForEach(y => Console.WriteLine($"Order Product Type: {y.TypeProduct}"));
                        x.ListOrder.ForEach(y => Console.WriteLine($"Product of {y.TypeProduct} amount: {y.Amount}"));
                        foreach (var y in x.ListOrder)
                        {
                            y.ListCustomer.ForEach(z => Console.WriteLine($"Customer ID: {z.Id}"));
                            y.ListCustomer.ForEach(z => Console.WriteLine($"Customer Name: {z.Name}"));
                        }
                    }
                    break;
                default:
                    // withoutOrder
                    shipments.ForEach(x => Console.WriteLine($"Shipment ID: {x.Id}\n Shipment address: {x.Address}"));
                    shipments.ForEach(x => Console.WriteLine($"Shipment status: {x.Status}"));
                    Console.WriteLine($"Order missing");
                    break;
            }
        }

    }
}
