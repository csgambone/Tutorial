using System;

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent Constructor.");
    }

    public void print()
    {
        Console.WriteLine("I'm a Parent Class.");
    }
}

public class ChildClass : ParentClass
{
    public ChildClass()
    {
        Console.WriteLine("Child Constructor.");
    }

    public static void xMain()
    {
        ChildClass child = new ChildClass();

        child.print();

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}