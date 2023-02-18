using System;

public class Address
{
    private string street, city, stateOrProvince, country;

    public Address()
    {
        street = "null";
        city = "null";
        stateOrProvince = "null";
        country = "null";
    }

     public Address(string _street, string _city, string _stateOrProvince, string _country)
    {
        street = _street;
        city = _city;
        stateOrProvince = _stateOrProvince;
        country = _country;
    }

    public string GetAddress()
    {
        string getAddress = ($"{street}, {city}, {stateOrProvince}, {country}");
        return getAddress;
    }





}