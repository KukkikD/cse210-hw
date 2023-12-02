
using System;
using System.Collections.Generic;

// Customer class to store information about customers
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    // Method to check if the customer is in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Property to get the customer's name
    public string GetName
    {
        get { return _name; }
    }

    // Property to get the customer's address
    public Address GetAddress
    {
        get { return _address; }
    }
}

