using System;

class Customer
{
    public string Name;
    private Address address;

    public Customer(string name, Address address)
    {
        Name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public override string ToString()
    {
        return $"Address: {address}";
    }
}
