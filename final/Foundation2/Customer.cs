using System;

class Customer
{
    private string Name;
    private Address Address;

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }

    public override string ToString()
    {
        return $"Address: {Address}";
    }

    public string GetName()
    {
        return Name;
    }
}

