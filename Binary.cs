using System;

class Binary
{
    public static void xMain()
    {
        int x, y, result;
        float floatresult;

        x = 7;
        y = 5;

        result = x + y;
        Console.WriteLine("x+y: {0}", result);

        result = x - y;
        Console.WriteLine("x-y: {0}", result);

        result = x * y;
        Console.WriteLine("x*y: {0}", result);

        result = x / y;
        Console.WriteLine("x/y: {0}", result);

        floatresult = (float)x / (float)y;
        Console.WriteLine("x/y: {0}", floatresult);

        result = x % y;
        Console.WriteLine("x%y: {0}", result);

        result += x;
        Console.WriteLine("result+=x: {0}", result);

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}