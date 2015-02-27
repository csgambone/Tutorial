﻿using System;

public class xxxxCustomer
{
    private int m_id = -1;

    public int ID
    {
        set
        {
            m_id = value;
        }
    }

    private string m_name = string.Empty;

    public string Name
    {
        set
        {
            m_name = value;
        }
    }

    public void DisplayCustomerData()
    {
        Console.WriteLine("ID: {0}, Name: {1}", m_id, m_name);
    }
}

public class WriteOnlyCustomerManager
{
    public static void xMain()
    {
        xxxxCustomer cust = new xxxxCustomer();

        cust.ID = 1;
        cust.Name = "Amelio Rosales";

        cust.DisplayCustomerData();

        Console.ReadKey();
    }
}