using System;
using System.Runtime.InteropServices;

class AttributeParamsDemo
{
    [DllImport("User32.dll", EntryPoint = "MessageBox")]
    static extern int MessageDialog(int hWnd, string msg, string caption, int msgType);

    [STAThread]
    static void xMain(string[] args)
    {
        MessageDialog(0, "MessageDialog Called!", "DllImport Demo", 0);

        // keep screen from going away
        // when run from VS.NET
        Console.ReadLine();
    }
}