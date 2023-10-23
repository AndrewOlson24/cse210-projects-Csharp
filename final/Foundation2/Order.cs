using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Order
{
    public List<Product> _product = new List<Product>();
    public List<Customer> _customer = new List<Customer>();
    private static Random random = new Random();

    public void listProduct()
    {
        Product product1 = new Product("Wii", "8989", "899", "1");
        Product product2 = new Product("XBox 1", "7889", "699", "2");
        Product product3 = new Product("IPhone", "3337", "299", "1");

        _product.Add(product1);
        _product.Add(product2);
        _product.Add(product3);
    }

    public void listCustomer()
    {
        Customer customer1 = new Customer("Andy");
        Customer customer2 = new Customer("Thor");
        Customer customer3 = new Customer("Groot");

        _customer.Add(customer1);
        _customer.Add(customer2);
        _customer.Add(customer3);
    }

    public void ListCustomer()
    {
        foreach (Customer customer in _customer)
        {
            Console.WriteLine(customer);
        }


    }    
    
    public void Menu()
    {
        Console.WriteLine("Welcome, here is your order");



    }
    
    static string GetPackingLabelCustomer(List<Customer> _customer)
    {
        if (_customer == null || _customer.Count == 0)
        {
            throw new ArgumentException("The list is empty.");
        }
        int randomIndex = random.Next(_customer.Count);
        return _customer[randomIndex];
       

    }
    public string GetPackingLabelProduct()
    {

        int randomIndex = random.Next(_product.Count);
        string cheese = $"{_product[randomIndex]}";
        return cheese;

    }

}