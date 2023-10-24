using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

public class Order
{
    public List<Product> _products = new List<Product>();
    public Customer _customer;
    private static Random random = new Random();

    public Order (string name, string addressName, string city, string state, string country) {
        Address address = new Address(addressName, city, state, country);
        _customer = new Customer(name, address);
    }

    public void AddProduct(string pName, string pID, int price, int quantity) {
        Product product = new Product(pName, pID, price, quantity);
        _products.Add(product);
    }

    public void BuildProductList()
    {
        Product product1 = new Product("Wii", "8989", 899, 1);
        Product product2 = new Product("XBox 1", "7889", 699, 2);
        Product product3 = new Product("IPhone", "3337", 299, 1);

        _products.Add(product1);
        _products.Add(product2);
        _products.Add(product3);
    }

    // Display the name and address of the customer for this order.
    public void DisplayCustomer()
    {
        Console.WriteLine(_customer.GetCustomerInfo());
        Console.WriteLine("========================================================================");
    }    
    
    public void DisplayPreface()
    {
        Console.WriteLine("========================================================================");
        Console.WriteLine("Thank you for shopping with us. Here is a list of what you've purchased: ");
        Console.WriteLine("========================================================================");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("========================================================================");
    }
    
    // static string GetPackingLabelCustomer(List<Customer> _customer)
    // {
    //     if (_customer == null || _customer.Count == 0)
    //     {
    //         throw new ArgumentException("The list is empty.");
    //     }
    //     int randomIndex = random.Next(_customer.Count);
    //     return _customer[randomIndex];
    // }
    public string GetPackingLabelProduct()
    {

        int randomIndex = random.Next(_products.Count);
        string cheese = $"{_products[randomIndex]}";
        return cheese;

    }
    public void DisplayProducts() {
        foreach (Product product in _products) {
            Console.WriteLine(product.GetProductString());
        }
    }

    public string TheDisplayProductsTotalPrices() {
        int totalSum = 0;
        foreach (Product product in _products) {
            Console.WriteLine(product.GetTotalPriceString());
            int result = product.GetTotalPrice();
            totalSum += result;

        }
        string bigcheese = $"The Total Price for Everything Today is: ${totalSum + 35}";
        Console.WriteLine("========================================================================");
        Console.WriteLine("");
        Console.WriteLine("One time $35 fee");
        Console.WriteLine(bigcheese);
        Console.WriteLine("");
        Console.WriteLine("========================================================================");
        return bigcheese;
    }
        public void DisplayProductsTotalPrices() {
        int totalSum = 0;
        foreach (Product product in _products) {
            Console.WriteLine(product.GetTotalPriceString());
            int result = product.GetTotalPrice();
            totalSum += result;

        }
    }
    public void TotalMathPRice()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.TotalSumPrice());
        }
    }
}