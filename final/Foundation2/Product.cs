using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Product
{
    private string _pname;
    private string _pID;
    private int _price;
    private int _pQuantity;

    public Product(string pname, string pID, string price, string pQuantity)
    {
        _pname = "Xbox 1";
        _pID = "5678";
        _price = 899;
        _pQuantity = 1;
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
    public int GetMath()
    {
        int _thePrice = _price * _pQuantity;
        return _thePrice;
    }

    public string GetProduct()
    {
        string gPrice = $"{_pname} {_pID}" + GetMath();
        return gPrice;
    }

    public static implicit operator string(Product v)
    {
        throw new NotImplementedException();
    }
}


