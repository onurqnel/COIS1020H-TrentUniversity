public class Clock
{
    private int hours;
    private int minutes;
    private char clockPeriod;

    // No Parameter Constructor
    public Clock()
    {
        // insert code here
    }

    // Three Parameter Constructor
    public Clock(int hrs, int mins, char cType)
    {
        hours = hrs;
        minutes = mins;
        clockPeriod = cType;
    }

    // Hours Property
    public int Hours
    {
        get { return hours; }
        set { hours = value; }
    }

    // Minutes Property
    public int Minutes
    {
        get { return minutes; }
        set { minutes = value; }
    }
    public char ClockPeriod
    {
        get { return clockPeriod; }
        set { clockPeriod = value; }
    }

    // ToString method
    public override string ToString()
    {
        return hours + ":" + minutes + clockPeriod;
    }

    // Overloaded Operator Addition method
    public static Clock operator +(Clock clk1, Clock clk2)
    {
        // insert code here
    }

    // Greater Than operator
    public static bool operator >(Clock clk1, Clock clk2)
    {
        // insert code here
    }

    // Less Than operator
    public static bool operator <(Clock clk1, Clock clk2)
    {
        // insert code here
    }
}
