using System;

/// <summary>
/// Custom struct type, representing a rectangular shape
/// </summary>
struct xxRectangle
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

    /// <summary>
    /// Instantiate rectangle struct with dimensions 
    /// </summary>

    /// <param name="width">Width to make new rectangle</param> 
    /// <param name="height">Height to make new rectangle</param>
    public xxRectangle(int width, int height)
    {
        m_width = width;
        m_height = height;
    }
}

/// <summary>
/// Example of declaring and using a struct
/// </summary>
class xxStructExample
{
    /// <summary>
    /// Entry point: execution starts here
    /// </summary>
    static void xMain()
    {
        // instantiate a new Rectangle struct
        // where Width is set to 5 and Height is set to 7
	    xxRectangle rect2 = new xxRectangle(5, 7);

        // show the value of Width and Height for rect2
        Console.WriteLine("rect2: {0}:{1}", rect2.Width, rect2.Height);

        Console.ReadKey();
    }
}