using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---ONLINE ORDERING---");
        Console.WriteLine();

        List<Order> orderList = new List<Order>
        {
            new Order(),
            new Order(),
            new Order(),
        };
    
        //Order #1
        Customer customer1 = new Customer("Juan Perez");
        orderList[0].setCustomer(customer1);
    
        Address address1 = new Address("No. 43 Col. Villas de la cruz", "Cholula", "Puebla", "Mexico");
        customer1.setCustomerAddress(address1);
    
        List<Product> newProductList = new List<Product>
        {
            new Product("nintendo switch","5421",250.00, 1),
            new Product("control pro", "4321", 70.00, 2),
            new Product("Super Mario Bros", "4311", 60.00, 1),
        };
        orderList[0].ProductList.AddRange(newProductList);


        //Order #2
        Customer customer2 = new Customer("Mary Jane");
        orderList[1].setCustomer(customer2);

        Address address2 = new Address("Baker street Num 132", "Oxford", "Philadelphia", "USA");
        customer2.setCustomerAddress(address2);

        newProductList = new List<Product>
        {
            new Product("iphone","7865",600.00, 1),
            new Product("smartwatch", "5218", 150.00, 3),
            new Product("headphones", "2875", 20.00, 2),
        };
        orderList[1].ProductList.AddRange(newProductList);

        //Order #3
        Customer customer3 = new Customer("Johanna Drakaris");
        orderList[2].setCustomer(customer3);

        Address address3 = new Address("Corner Street #143", "Wahrenholz", "Wolfsburg", "Germany");
        customer3.setCustomerAddress(address3);

        newProductList = new List<Product>
        {
            new Product("dress","7543",50.00, 1),
            new Product("high heels", "2132", 70.00, 2),
            new Product("blouse", "1875", 20.00, 5),
        };
        orderList[2].ProductList.AddRange(newProductList);

        foreach (Order order in orderList)
        {
            int orderNumber = orderList.IndexOf(order);
            orderNumber ++;
            Console.WriteLine($"Order # {orderNumber}");

            order.DisplayPackingLabel();
            order.calculateCostOrder();
            Console.WriteLine();

            Console.WriteLine($"Total cost Order: {order.getOrderCost()}");
            Console.WriteLine();
            order.displayShippingLabel();  
            Console.WriteLine("--------------------------------");
            Console.WriteLine();


        }



    }
}