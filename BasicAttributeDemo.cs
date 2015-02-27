using System;

class BasicAttributeDemo
{
    [Obsolete]
    public void MyFirstdeprecatedMethod()
    {
        Console.WriteLine("Called MyFirstdeprecatedMethod().");
    }

    [ObsoleteAttribute]
    public void MySecondDeprecatedMethod()
    {
        Console.WriteLine("Called MySecondDeprecatedMethod().");
    }

    [Obsolete("You shouldn't use this method anymore.")]
    public void MyThirdDeprecatedMethod()
    {
        Console.WriteLine("Called MyThirdDeprecatedMethod().");
    }

    // make the program thread safe for COM
    [STAThread]
    static void xMain(string[] args)
    {
        BasicAttributeDemo attrDemo = new BasicAttributeDemo();

        attrDemo.MyFirstdeprecatedMethod();
        attrDemo.MySecondDeprecatedMethod();
        attrDemo.MyThirdDeprecatedMethod();

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}