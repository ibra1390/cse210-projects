using System;

public class Customer
{
    private string customerName;
    private bool LivesInUSA;
    private Address address = new Address();

    public Customer(string _customerName)
    {
        customerName = _customerName;
    }

    public void setCustomerAddress(Address _address)
    {
        address = _address;
    }

    public string getCustomerName()
    {
        return customerName;
    }

    public bool CustomerLivesUSA()
    {
        LivesInUSA = address.AddressInUSA();
        return LivesInUSA;
    }

    public string getCustomerAddress()
    {
        return address.FullAddress();
    }

}

    
