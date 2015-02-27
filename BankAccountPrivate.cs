using System;

class BankAccountPrivate
{
    private string m_name;

    public string CustomerName
    {
        get
        {
            return m_name;
        }
        set
        {
            m_name = value;
        }
    }
}