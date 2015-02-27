using System;

class WhileLoop
{
    public static void xMain()
    {
        int myInt = 0;

        while (myInt < 10)
        {
            Console.Write("{0} ", myInt);
            myInt++;
        }
        Console.WriteLine();

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}