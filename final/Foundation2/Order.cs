using System;

public class Order
{
    private double costOrder = 0;
    private string shippingLabel;
    private double shippingCost = 0;
    private string packingLabel;

    public List<Product> ProductList = new List<Product>();

    Customer customer;

    public void setCustomer(Customer _customer)
    {
        customer = _customer;
    }

    public void displayProductList()
    {
        foreach(Product product in ProductList)
        {
            Console.WriteLine(product.displayProduct());
        }
    }

    public void getShippingCost()
    {
        bool USshipping = customer.CustomerLivesUSA();
        if (USshipping == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
    }

    public void setPackingLabel(string _packingLabel)
    {
        packingLabel = _packingLabel;
    }

    public void DisplayPackingLabel()
    {
        foreach(Product product in ProductList)
        {
            packingLabel = product.displayProduct();
            Console.WriteLine(packingLabel);
        }
    }


    public void setShippingLabel(string _shippingLabel)
    {
        shippingLabel = _shippingLabel;
    }
    public void displayShippingLabel()
    {
        shippingLabel = String.Format("{0} \n{1}", customer.getCustomerName(), customer.getCustomerAddress());
        Console.WriteLine("Ship to: ");
        Console.WriteLine(shippingLabel);
    }

    public double calculateCostOrder()
    {
        foreach(Product product in ProductList)
        {
            costOrder += product.calculateProductPrice();
        }
        getShippingCost();
        costOrder += shippingCost;
        costOrder = Math.Round(costOrder, 2);
        return costOrder;
    }

    public string getOrderCost()
    {
        return string.Format("${0}", costOrder);
    }





}
