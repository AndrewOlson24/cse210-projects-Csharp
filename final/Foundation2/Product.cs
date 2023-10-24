using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Product
{
    private string _pName;
    private string _pID;
    private int _price;
    private int _pQuantity;

    public Product(string pName, string pID, int price, int pQuantity)
    {
        _pName = pName;
        _pID = pID;
        _price = price;
        _pQuantity = pQuantity;
    }
    /*public Product2(string pname, string pID, string price, string pQuantity)
    {
        _pname = "Wii";
        _pID = "5698";
        _price = 499;
        _pQuantity = 1;
    }
    public Product3(string pname, string pID, string price, string pQuantity)
    {
        _pname = "iPhone";
        _pID = "7698";
        _price = 699;
        _pQuantity = 1;
    }*/
    public int GetTotalPrice()
    {
        int _thePrice = _price * _pQuantity;
        return _thePrice;
    }

    public string GetTotalPriceString()
    {
        string gPrice = $"Product name: {_pName}, Product ID: {_pID}, Total Price: {GetTotalPrice()}";
        return gPrice;
    }

    public string GetProductString() {
        return $"{_pName}, {_pID}, {_price}, {_pQuantity}";
    }

    public int GetTotalPriceForALL()
    {
        int tree = GetTotalPrice() + 35;
        return tree;
    }
    public int TotalSumPrice()
    {
        int total = 0;
        for (int i = 0; i < 3; i++)
        {
            int number = GetTotalPrice();
            total += number;
        }
        return total;
    }
}


