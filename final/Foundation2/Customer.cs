using System;

public class Customer
{
    private string _name = "";
    private Address _address {get; set;}

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUnitedStates()
    {
        return _address.IsInUSA();
    }

    public string ReturnCustomerLabel()
    {
        return $"{_name} \n{_address.ReturnAddress()}";
    }
}