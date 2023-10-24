using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Customer
{
    private string _humanName;
    public  Address _address;


    public void CheckAddress()
    {
        _address.America();
    }
    public Customer(string humanName, Address address)
    {
        _humanName = humanName;
        _address = address;
    }
    public string GetCustomerInfo()
    {   
        
        string _fullAdress = $"{_humanName}\n{_address.getterAddress()}";
        return _fullAdress;
    }

    public static implicit operator string(Customer v)
    {
        throw new NotImplementedException();
    }
}