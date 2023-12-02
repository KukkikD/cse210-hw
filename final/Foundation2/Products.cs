using System;
using System.Collections.Generic;

// Product class to store information about products
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    // Property to get the computed price of the product
    public double GetTotalPrice => _price * _quantity;
    

    // Property to get the product ID
    public string GetProductId()
    {
        return _productId;
    }
}
