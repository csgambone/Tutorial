using System;

class Employee
{
    private string m_name;

    public string Name
    {
        get { return m_name; }
        set { m_name = value; }
    }
}

class Program3
{
    static void xMain()
    {
        Employee joe = new Employee();
        joe.Name = "Joe";

        Employee bob = new Employee();
        bob.Name = "Bob";

        Console.WriteLine("Original Employee Values:");
        Console.WriteLine("joe = " + joe.Name);
        Console.WriteLine("bob = " + bob.Name);

        // assign joe reference to bob variable
        bob = joe;

        Console.WriteLine();
        Console.WriteLine("Values After Reference Assignment:");
        Console.WriteLine("joe = " + joe.Name);
        Console.WriteLine("bob = " + bob.Name);

        joe.Name = "Bobbi Jo";

        Console.WriteLine();
        Console.WriteLine("Values After Changing One Instance:");
        Console.WriteLine("joe = " + joe.Name);
        Console.WriteLine("bob = " + bob.Name);

        // b
        Console.ReadKey();
    }
}