using System;

class xInterfaceImplementer : xIMyInterface
{
    static void xMain()
    {
        InterfaceImplementer iImp = new InterfaceImplementer();
        iImp.MethodToImplement();
    }

    public void MethodToImplement()
    {
        Console.WriteLine("MethodToImplement() called.");

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}