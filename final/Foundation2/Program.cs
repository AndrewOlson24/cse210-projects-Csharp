using System;
using System.Xml.Schema;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order("Andy","10 Test1 Ct.", "testCity1", "testState1", "Test1 Country");
        order.AddProduct("iPad 3", "87687", 899, 10);
        order.AddProduct("xbox one", "84787", 399, 2);
        order.AddProduct("wii", "44", 299, 1);
        order.DisplayPreface();
        order.TheDisplayProductsTotalPrices();
        order.DisplayCustomer();
        //order.DisplayProducts();
        
        
        //order.TotalMathPRice();
        


        // Order order = new Order();
        // order.Menu();
        // order.BuildCustomerList();
        // order.ListCustomer();

    }
}