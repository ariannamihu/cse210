using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Product product1 = new Product("Black Shoes", "105679", 75, 1);
        Product product2 = new Product("Red T-shirt", "109364", 20, 2);
        Address customer1Address = new Address("Cherry Lane", "Provo", "Utah", "USA");
        Customer customer1 = new Customer("Muffin Man", customer1Address);

        order1.AddToProductsList(product1);
        order1.AddToProductsList(product2);
        order1.AddToCustomerList(customer1);

        order1.CalculateCost();
        order1.ReturnPackingLabel();
        order1.ReturnShippingLabel();



        Order order2 = new Order();
        Product product3 = new Product("Earrings", "128364", 25, 1);
        Product product4 = new Product("Hairspray", "158394", 5, 3);
        Address customer2Address = new Address("1294 Boulder Circle", "London", "England", "United Kingdom");
        Customer customer2 = new Customer("Gerald Smith", customer2Address);

        order2.AddToProductsList(product3);
        order2.AddToProductsList(product4);
        order2.AddToCustomerList(customer2);

        order2.CalculateCost();
        order2.ReturnPackingLabel();
        order2.ReturnShippingLabel();
    }
}