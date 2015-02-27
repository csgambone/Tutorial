using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        Button btnHello = new Button();
        btnHello.Text = "Hello";

        btnHello.Click +=
            delegate
            {
                MessageBox.Show("Hello");
            };

        Button btnGoodBye = new Button();
        btnGoodBye.Text = "Goodbye";
        btnGoodBye.Left = btnHello.Width + 5;
        btnGoodBye.Click +=
            delegate(object sender, EventArgs e)
            {
                string message = (sender as Button).Text;
                MessageBox.Show(message);
            };

        Controls.Add(btnHello);
        Controls.Add(btnGoodBye);
    }

    static void xMain()
    {
        Application.Run(new Form1());

        Console.ReadLine();
    }
}