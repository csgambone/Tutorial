using System;

/// <summary>
/// Custom struct type, representing
/// a rectangular shape
/// </summary>
struct xRectangle
{
    /// <summary>
    /// Backing Store for Width
    /// </summary>
    private int m_width;

    /// <summary>
    /// Width of rectangle
    /// </summary>
    public int Width 
    {
        get
        {
            return m_width;
        }
        set
        {
            m_width = value;
        }
    }

    /// <summary>
    /// Backing store for Height
    /// </summary>
    private int m_height;

    /// <summary>
    /// Height of rectangle
    /// </summary>
    public int Height
    {
        get
        {
            return m_height;
        }
        set
        {
            m_height = value;
        }
    }
}


/// <summary>
/// Example of declaring and using a struct
/// </summary>
class xStructExample
{
    /// <summary>
    /// Entry point: execution starts here
    /// </summary>
    static void xMain()
    {
        // instantiate a new Rectangle struct
        // where Width is set to 1 and Height
        //  is set to 3
	    xRectangle rect1 = new xRectangle();
        rect1.Width = 1;
        rect1.Height = 3;

        // you can also use object initialization syntax
        xRectangle rect2 = new xRectangle
        {
            Width = 2,
            Height = 4
        };

        // show the value of Width and Height for rect1
        Console.WriteLine("rect1: {0}:{1}", rect1.Width, rect1.Height);

        // show the value of Width and Height for rect2
        Console.WriteLine("rect2: {0}:{1}", rect2.Width, rect2.Height);

        Console.ReadKey();
    }
}