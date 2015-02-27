using System;

class Program2
{
    static void xMain()
    {
        float lengthFloat = 7.35f;

        // lose precision - explicit conversion
        int lengthInt = (int)lengthFloat;

        // no problem - implicit conversion
        double lengthDouble = lengthInt;

        Console.WriteLine("lengthInt = " + lengthInt);
        Console.WriteLine("lengthDouble = " + lengthDouble);
        Console.ReadKey();
    }
}