using System;

public class Customer
{
    private Address _address;
    private string _name;

    public Customer(string name, Address address)
    {
        _address = address;
        _name = name;
    }

    public bool IsLiveInUSA()
    {
        return _address.IsInUSA();
    }
    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress(); 
    }

}