using System;

public class Product
{
    private string _name = "";
    private string _productID = "";
    private int _price = 0;
    private int _quantity = 0;

    public Product(string name, string id, int price, int quantity)
    {
        _name = name;
        _productID = id;
        _price = price;
        _quantity = quantity;

    }
    
    public int ComputePrice()
    {
        return _price *_quantity;
    }

    public string ProductLabel()
    {
        return $"{_name}; {_productID}";
    }
}