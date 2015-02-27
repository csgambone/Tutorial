using System;

public class xxxCustomer
{
    private int m_id = -1;
    private string m_name = string.Empty;

    public xxxCustomer(int id, string name)
    {
        m_id = id;
        m_name = name;
    }

    public int ID
    {
        get
        {
            return m_id;
        }
    }

    public string Name
    {
        get
        {
            return m_name;
        }
    }
}

public class ReadOnlyCustomerManager
{
    public static void xMain()
    {
        xxxCustomer cust = new xxxCustomer(1, "Amelio Rosales");

        Console.WriteLine(
            "ID: {0}, Name: {1}",
            cust.ID,
            cust.Name);

        Console.ReadKey();
    }
}