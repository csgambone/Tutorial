using System;
using System.IO;

class tryCatchDemo
{
    static void xMain(string[] args)
    {
        try
        {
            File.OpenRead("NonExistentFile");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}