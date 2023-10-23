using System;
using System.Xml.Schema;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        order.Menu();
        order.ListCustomer();

    }
}