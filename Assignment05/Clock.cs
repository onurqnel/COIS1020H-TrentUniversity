public class Clock
{
    private int hours;
    private int minutes;
    private char clockPeriod;

    // No Parameter Constructor
    public Clock()
    {
        hours = 12;
        minutes = 0;
        clockPeriod = 'A';
    }

    // Three Parameter Constructor
    public Clock(int hrs, int mins, char cType)
    {
        ClockPeriod = cType;
        Hours = hrs;
        Minutes = mins;
    }

    // Hours Property
    public int Hours
    {
        get { return hours; }
        set
        {
            if (value <= 12 && value >= 1)
            {
                hours = value;
            }
            else
            {
                hours = 12;
                Console.WriteLine("Invalid hour value, it has been set to {}", hours);
            }
        }
    }

    // Minutes Property
    public int Minutes
    {
        get { return minutes; }
        set
        {
            if (value < 60 && value >= 0)
            {
                minutes = value;
            }
            else
            {
                minutes = 0;
                Console.WriteLine("Invalid minute value, it has been set to {}", minutes);
            }
        }
    }
    public char ClockPeriod
    {
        get { return clockPeriod; }
        set
        {
            if (char.ToUpper(value) == 'A' || char.ToUpper(value) == 'P')
            {
                clockPeriod = char.ToUpper(value);
            }
            else
            {
                clockPeriod = 'A';
                Console.WriteLine("Invalid clock period, it has been set to {}", clockPeriod);
            }
        }
    }

    // ToString method
    public override string ToString()
    {
        return hours + ":" + minutes + clockPeriod;
    }

    // Overloaded Operator Addition method
    public static Clock operator +(Clock clk1, Clock clk2)
    {
        int totalHour = clk1.Hours + clk2.Hours;
        int totalMinutes = clk1.Minutes + clk2.Minutes;
        char newPeriod = clk1.ClockPeriod;

        if (totalMinutes >= 60)
        {
            totalHour++;
            totalMinutes %= 60;
        }
        if (totalHour > 12)
        {
            totalHour %= 12;
            if (totalHour == 0)
            {
                totalHour = 12;
            }
            if (clk1.ClockPeriod == 'A')
            {
                newPeriod = 'P';
            }
            else
            {
                newPeriod = 'A';
            }
        }
        return new Clock(totalHour, totalMinutes, newPeriod);
    }

    /*
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
    */
}
