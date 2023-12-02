
// Order class to store information about orders
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer _customer, List<Product> _products)
    {
        this._customer = _customer;
        this._products = _products;
    }

    // Method to calculate the total cost of the order
    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.GetTotalPrice;
        }


        // Add one-time shipping cost based on customer location
        totalCost += _customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    // Method to generate a packing label
    public string GeneratePackingLabel()
    {
        string packingLabel = $"Packing Label for {_customer.GetName}:\n";

        foreach (var product in _products)
        {
            packingLabel += $"- {product.GetProductId}: {product.GetTotalPrice:C}\n";
        }

        return packingLabel;
    }

    // Method to generate a shipping label
    public string GenerateShippingLabel()
    {
        return $"Shipping Label for {_customer.GetName}:\n{_customer.GetAddress.GetFullAddress()}";
    }
}