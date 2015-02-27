using System;

class ForEachLoop
{
    public static void xMain()
    {
        string[] names = { "Cheryl", "Joe", "Matt", "Robert" };

        foreach (string person in names)
        {
            Console.WriteLine("{0} ", person);
        }

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}