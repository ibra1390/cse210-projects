using System;

public class Product
{
    public string productName;
    private string productID;
    private int quantity;
    private double productPrice = 0;
    private double totalPrice;
    

    public Product(string _productName, string _productID, double _productPrice, int _quantity)
    {
        productName = _productName;
        productID = _productID;
        productPrice = _productPrice;
        quantity = _quantity;
    }

    public string displayProduct()
    {
        return String.Format("Product: {0}, ID: {1}, Price: {2}, Quantity: {3}", productName, productID, productPrice, quantity);
    }

    public double calculateProductPrice()
    {
        totalPrice = productPrice * quantity;
        return totalPrice;

    }


} 