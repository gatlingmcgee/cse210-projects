using System;

class Program
{
    static void Main(string[] args)
    {
        // Address's
        Address usaAddress = new Address("28111 E 161st St S", "Coweta", "OK", "USA");
        Address nonUsaAddress = new Address("1007 Blind Bay Road", "Blue River", "BC", "CAN");
        Address secondUsaAddress = new Address("28006 E. 61st", "Broken Arrow", "OK", "USA");

        // Costumer's
        Customer usaCustomer = new Customer("Bruce Gibson", usaAddress);
        Customer nonUsaCustomer = new Customer("David Petterson", nonUsaAddress);
        Customer secondUsaCustomer = new Customer("Sean Sonderegger", secondUsaAddress);

        // Product's
        Product TV = new Product("TV", "T5V67886", 100, 1);
        Product soundBar = new Product("Soundbar", "S8B8774", 30, 1);
        Product projector = new Product("Projector", "P0873562", 150, 1);
        Product wiringHarness = new Product("Wire Harness", "WH654125", 50, 1);

        // Order's
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(TV);
        order1.AddProduct(soundBar);
        order1.AddProduct(wiringHarness);        

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(TV);
        order2.AddProduct(projector);
        order2.AddProduct(wiringHarness); 

        Order order3 = new Order(secondUsaCustomer);
        order3.AddProduct(TV);
        order3.AddProduct(TV);
        order3.AddProduct(projector);
        order3.AddProduct(soundBar);
        order3.AddProduct(wiringHarness); 

        // Display orders
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
        Console.WriteLine();       

        Console.WriteLine("Order 3:");
        Console.WriteLine($"Packing Label:\n{order3.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order3.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order3.GetTotalPrice():F2}");
        Console.WriteLine();     
    }
}
