public class Clock
{
    // Private fields for storing clock hours, minutes, and AM/PM period.
    private int hours;
    private int minutes;
    private char clockPeriod;

    // Default constructor initializing the clock to 12:00 AM.
    public Clock()
    {
        hours = 12;
        minutes = 0;
        clockPeriod = 'A';
    }

    // Parameterized constructor for custom initialization.
    public Clock(int hrs, int mins, char cType)
    {
        ClockPeriod = cType; // Use the ClockPeriod property to validate input.
        Hours = hrs; // Use the Hours property to validate input.
        Minutes = mins; // Use the Minutes property to validate input.
    }

    // Property to get and set hours with validation.
    public int Hours
    {
        get { return hours; }
        set
        {
            // Ensure hours are between 1 and 12
            if (value <= 12 && value >= 1)
            {
                hours = value;
            }
            else
            {
                hours = 12; // Default to 12 if the input is invalid.
                Console.WriteLine("Invalid hour value, it has been set to {}", hours);
            }
        }
    }

    // Property to get and set minutes with validation.
    public int Minutes
    {
        get { return minutes; }
        set
        {
            // Ensure minutes are between 0 and 59 (inclusive).
            if (value < 60 && value >= 0)
            {
                minutes = value;
            }
            else
            {
                minutes = 0; // Default to 0 if the input is invalid.
                Console.WriteLine("Invalid minute value, it has been set to {}", minutes);
            }
        }
    }

    // Property to get and set the AM/PM period with validation.
    public char ClockPeriod
    {
        get { return clockPeriod; }
        set
        {
            // Ensure the period is either 'A' or 'P' (case-insensitive).
            if (char.ToUpper(value) == 'A' || char.ToUpper(value) == 'P')
            {
                clockPeriod = char.ToUpper(value);
            }
            else
            {
                clockPeriod = 'A'; // Default to 'A' (AM) if the input is invalid.
                Console.WriteLine("Invalid clock period, it has been set to {}", clockPeriod);
            }
        }
    }

    // Override ToString() to return the clock time in a formatted string.
    public override string ToString()
    {
        return hours + ":" + minutes + clockPeriod;
    }

    // Overloaded addition operator to add two Clock objects.
    public static Clock operator +(Clock clk1, Clock clk2)
    {
        // Calculate the total hours and minutes.
        int totalHour = clk1.Hours + clk2.Hours;
        int totalMinutes = clk1.Minutes + clk2.Minutes;
        char newPeriod = clk1.ClockPeriod;

        // Adjust hours and minutes if totalMinutes exceeds 59.
        if (totalMinutes >= 60)
        {
            totalHour++;
            totalMinutes = totalMinutes % 60; // Get the remaining minutes.
        }

        // Adjust the AM/PM period if totalHour exceeds 12.
        if (totalHour >= 12)
        {
            int amPmFlips = totalHour / 12; // Calculate how many AM/PM flips occur.
            totalHour = totalHour % 12; // Get the remaining hours.

            // Special case: If totalHour is 0, reset to 12 (clock convention).
            if (totalHour == 0)
            {
                totalHour = 12;
            }

            // Flip the period for odd numbers of 12-hour cycles.
            if (amPmFlips % 2 != 0)
            {
                newPeriod = (newPeriod == 'A') ? 'P' : 'A';
            }
        }

        // Return a new Clock object with the calculated values.
        return new Clock(totalHour, totalMinutes, newPeriod);
    }

    // Overloaded greater-than operator to compare two Clock objects.
    public static bool operator >(Clock clk1, Clock clk2)
    {
        // Compare hours first, then minutes if hours are equal.
        if (clk1.Hours > clk2.Hours || (clk1.Hours == clk2.Hours && clk1.Minutes > clk2.Minutes))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Overloaded less-than operator to compare two Clock objects.
    public static bool operator <(Clock clk1, Clock clk2)
    {
        // Compare hours first, then minutes if hours are equal.
        if (clk1.Hours < clk2.Hours || (clk1.Hours == clk2.Hours && clk1.Minutes < clk2.Minutes))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
