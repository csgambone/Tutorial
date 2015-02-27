using System;

public class xxxxxCustomer
{
    public int ID { get; set; }
    public string Name { get; set; }
}

public class AutoImplementedCustomerManager
{
    static void xMain()
    {
        xxxxxCustomer cust = new xxxxxCustomer();

        cust.ID = 1;
        cust.Name = "Amelio Rosales";

        Console.WriteLine(
            "ID: {0}, Name: {1}",
            cust.ID,
            cust.Name);

        Console.ReadKey();
    }
}