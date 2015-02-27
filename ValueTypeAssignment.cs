using System;

struct Height
{
    private int m_inches;

    public int Inches
    {
        get { return m_inches; }
        set { m_inches = value; }
    }
}

class Program4
{
    static void Main()
    {
        Height joe = new Height();
        joe.Inches = 71;

        Height bob = new Height();
        bob.Inches = 59;

        Console.WriteLine("Original Height Values:");
        Console.WriteLine("joe = " + joe.Inches);
        Console.WriteLine("bob = " + bob.Inches);

        // assign joe value to bob variable
        bob = joe;

        Console.WriteLine();
        Console.WriteLine("Values After Value Assignment:");
        Console.WriteLine("joe = " + joe.Inches);
        Console.WriteLine("bob = " + bob.Inches);

        joe.Inches = 65;

        Console.WriteLine();
        Console.WriteLine("Values After Changing One Instance:");
        Console.WriteLine("joe = " + joe.Inches);
        Console.WriteLine("bob = " + bob.Inches);

        // a
        Console.ReadKey();
    }
}