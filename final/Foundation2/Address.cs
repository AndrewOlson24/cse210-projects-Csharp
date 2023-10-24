using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;



    public Address(string address, string city, string state, string country)
    {
        _address = "26333 130th Ave S.E. ";
        _city = "Kent ";
        _state = "Washington";
        _country = "USA";



    }

    public string America()
    {
        string _where = "";
        if (_country == "America")
        {
            _where = "This customer lives in the USA";
        }
        else
        {
            _where = "This customer does NOT live in the USA";
        }
        return _where;

    }
    public string getterAddress()
    {   
        string _theAddress = $"{_address}{_city} \n{_state} {_country}";
        return _theAddress;
    }
}