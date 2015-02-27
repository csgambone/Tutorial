// Namespace Declaration
using System;

// Program start class
class InteractiveWelcome
{
    // Main begins program execution.
    public static void xMain()
    {
        // Write to console/get input
        Console.Write("What is your name?: ");
        Console.Write("Hello, {0}! ", Console.ReadLine());
        Console.WriteLine("Welcome to the C# Station Tutorial!!");

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}