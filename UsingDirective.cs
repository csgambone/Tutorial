// Namespace Declaration
using System;
using csharp_station.xtutorial;

// Program start class
class UsingDirective
{
    // Main begins program execution.
    public static void xMain()
    {
        // Call namespace member
        myExample.myPrint();

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}

// C# Station Tutorial Namespace
namespace csharp_station.xtutorial
{
    class myExample
    {
        public static void myPrint()
        {
            Console.WriteLine("Example of using a using directive.");
        }
    }
}