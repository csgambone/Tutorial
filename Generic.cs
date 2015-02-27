using System;
using System.Collections.Generic;

public class xxxxxxCustomer
{
    public xxxxxxCustomer(int id, string name)
    {
        ID = id;
        Name = name;
    }

    private int m_id;

    public int ID
    {
        get { return m_id; }
        set { m_id = value; }
    }

    private string m_name;

    public string Name
    {
        get { return m_name; }
        set { m_name = value; }
    }

    static void xMain()
    {
        Dictionary<int, xxxxxxCustomer> customers = new Dictionary<int, xxxxxxCustomer>();

        xxxxxxCustomer cust1 = new xxxxxxCustomer(1, "Cust 1");
        xxxxxxCustomer cust2 = new xxxxxxCustomer(2, "Cust 2");
        xxxxxxCustomer cust3 = new xxxxxxCustomer(3, "Cust 3");

        customers.Add(cust1.ID, cust1);
        customers.Add(cust2.ID, cust2);
        customers.Add(cust3.ID, cust3);

        foreach (System.Collections.Generic.KeyValuePair<int, xxxxxxCustomer> custKeyVal in customers)
        {
            Console.WriteLine("Customer ID: {0}, Name: {1}", custKeyVal.Key, custKeyVal.Value.Name);
        }

        Console.ReadLine();
    }
}