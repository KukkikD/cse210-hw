using System;

class Program
{
    static void Main(string[] args)
    {
    // Create addresses
        Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address internationalAddress = new Address("456 High St", "Foreign City", "Province", "Canada");

        // Create customers
        Customer usaCustomer = new Customer("John Deb", usaAddress);
        Customer internationalCustomer = new Customer("Jane Sweet", internationalAddress);

        // Create products
        Product product1 = new Product("Laptop", "LPT001", 1200.00, 2);
        Product product2 = new Product("Mouse", "MS001", 25.00, 3);
        Product product3 = new Product("Headphones", "HP001", 50.00, 1);

        // Create orders
        List<Product> order1Products = new List<Product> { product1, product2 };
        Order order1 = new Order(usaCustomer, order1Products);

        List<Product> order2Products = new List<Product> { product2, product3 };
        Order order2 = new Order(internationalCustomer, order2Products);

        // Display information about the orders
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine($"Total Price for {order.GeneratePackingLabel()}: {order.CalculateTotalCost():C}");
        Console.WriteLine($"{order.GenerateShippingLabel()}\n");
    }
}