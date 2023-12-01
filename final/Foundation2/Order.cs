using System;

public class Order
{
    private List<Product> _productsList = new List<Product>();
    private List<Customer> _customerList = new List<Customer>();
    private bool _isInUS = false;

    public void AddToProductsList(Product product)
    {
        _productsList.Add(product);
    }
    
    public void AddToCustomerList(Customer customer)
    {
        _customerList.Add(customer);
        _isInUS = customer.IsInUnitedStates();
    }

    public int CalculateCost()
    {
        int totalCost = 0;
        foreach (Product p in _productsList)
        {
            totalCost += p.ComputePrice();
        }
        if (_isInUS == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        Console.WriteLine($"Total Cost: \n{totalCost}\n");
        return totalCost;
    }

    public List<string> ReturnPackingLabel()
    {
        Console.WriteLine("Packing Label: ");
        List<string> label = new List<string>();
        foreach (Product p in _productsList)
        {
            label.Add(p.ProductLabel());
            Console.WriteLine(p.ProductLabel());
        }
        Console.WriteLine();
        return label;
    }

    public string ReturnShippingLabel()
    {
        string customerLabel = "Shipping Label: \n";
        foreach (Customer c in _customerList)
        {
            customerLabel += c.ReturnCustomerLabel();
            customerLabel += "\n";
            // Console.Writeline(c.ReturnCustomerLabel());
        }
        Console.WriteLine(customerLabel);
        return customerLabel;
    }
}