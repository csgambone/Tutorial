using System;

[assembly: CLSCompliant(true)]

public class AttributeTargetdemo
{
    public void NonClsCompliantMethod(uint nclsParam)
    {
        Console.WriteLine("Called NonClsCompliantMethod().");
    }

    [STAThread]
    static void xMain(string[] args)
    {
        uint myUint = 0;

        AttributeTargetdemo tgtdemo = new AttributeTargetdemo();

        tgtdemo.NonClsCompliantMethod(myUint);

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}