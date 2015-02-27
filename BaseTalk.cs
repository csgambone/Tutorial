﻿using System;

public class Parent
{
    string parentString;
    public Parent()
    {
        Console.WriteLine("Parent Constructor.");
    }
    public Parent(string myString)
    {
        parentString = myString;
        Console.WriteLine(parentString);
    }
    public void print()
    {
        Console.WriteLine("I'm a Parent Class.");
    }
}

public class Child : Parent
{
    public Child()
        : base("From Derived")
    {
        Console.WriteLine("Child Constructor.");
    }
    public new void print()
    {
        base.print();
        Console.WriteLine("I'm a Child Class.");
    }
    public static void xMain()
    {
        Child child = new Child();
        child.print();
        ((Parent)child).print();

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}