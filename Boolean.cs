using System;

class Booleans
{
    public static void xMain()
    {
        bool content = true;
        bool noContent = false;

        Console.WriteLine("It is {0} that C# Station provides C# programming language content.", content);
        Console.WriteLine("The statement above is not {0}.", noContent);

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}