/*
 * Onur (Honor) Onel
 * Student Number: 0865803
 * Student Email: onuronel@trentu.ca
 * Date Submitted: 2024-11-30
 *
 * `Assignment05.cs`
 *
 * Description:
 * ************
 *  The `Clock` class represents a 12-hour clock with validation for hours (1-12),
 *  minutes (0-59), and AM/PM ('A' or 'P'). Functionalities include setting, displaying,
 *  comparing, and adding time with constructors, properties, and operators.
 *
 * Data Dictionary:
 * ****************
 *
 * FIELDS
 *   -int hours:        Validated hour (1-12)
 *   -int minutes:      Validated minute (0-59)
 *   -char clockPeriod: Validated AM/PM indicator
 *
 * PROPERTIES
 *   +int Hours:        Validates and sets `hours`
 *   +int Minutes:      Validates and sets `minutes`
 *   +char ClockPeriod: Validates and sets `clockPeriod`
 *
 * METHODS
 *   +Clock(): Default constructor, sets 12:00 AM.
 *   +Clock(int hrs, int mins, char cType): Three parameter constructor.
 *   +override string ToString(): Returns time as a formatted string.
 *   +static Clock operator +(Clock clk1, Clock clk2): Adds two clocks.
 *   +static bool operator >(Clock clk1, Clock clk2): Compares if clk1 > clk2.
 *   +static bool operator <(Clock clk1, Clock clk2): Compares if clk1 < clk2.
 */
public class Clock
{
    // Private fields for storing clock hours, minutes, and AM/PM period
    private int hours;
    private int minutes;
    private char clockPeriod;

    // Default constructor initializing the clock to 12:00 AM
    public Clock()
    {
        hours = 12;
        minutes = 0;
        clockPeriod = 'A';
    }

    // Three parameter constructor for customization
    public Clock(int hrs, int mins, char cType)
    {
        ClockPeriod = cType; // Use the ClockPeriod property to validate input
        Hours = hrs; // Use the Hours property to validate input
        Minutes = mins; // Use the Minutes property to validate input
    }

    // Property to get and set hours with validation
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
                hours = 12; // Default to 12 if the input is invalid
                Console.WriteLine("Invalid hour value, it has been set to {}", hours);
            }
        }
    }

    // Property to get and set minutes with validation
    public int Minutes
    {
        get { return minutes; }
        set
        {
            // Ensure minutes are between 0 and 59
            if (value < 60 && value >= 0)
            {
                minutes = value;
            }
            else
            {
                minutes = 0; // Default to 0 if the input is invalid
                Console.WriteLine("Invalid minute value, it has been set to {}", minutes);
            }
        }
    }

    // Property to get and set the AM/PM period with the validation
    public char ClockPeriod
    {
        get { return clockPeriod; }
        set
        {
            // Ensure the period is either 'A' or 'P'
            if (char.ToUpper(value) == 'A' || char.ToUpper(value) == 'P') // Achieving insensetive case with the validation
            {
                clockPeriod = char.ToUpper(value);
            }
            else
            {
                clockPeriod = 'A'; // Default to AM if the input is invalid
                Console.WriteLine("Invalid clock period, it has been set to {}", clockPeriod);
            }
        }
    }

    // Override ToString() to return the clock time in a formatted string.
    public override string ToString()
    {
        return Hours + ":" + Minutes + ClockPeriod; //Return the Properties since getters has validations
    }

    // Addition operator to add two Clock objects.
    public static Clock operator +(Clock clk1, Clock clk2)
    {
        // Calculate the total hours and minutes.
        int totalHour = clk1.Hours + clk2.Hours;
        int totalMinutes = clk1.Minutes + clk2.Minutes;
        char newPeriod = clk1.ClockPeriod;

        // If totalMinutes exceeds 59.
        if (totalMinutes >= 60)
        {
            totalHour++; // Add one more hour
            totalMinutes = totalMinutes % 60; // Update minutes with the remaining (after 60)
        }

        // If totalHour exceeds 12.
        if (totalHour >= 12)
        {
            totalHour = totalHour % 12; // Update hours with the remaining (after 12)

            int amPmFlips = totalHour / 12; // Calculate AM/PM flips
            if (amPmFlips % 2 != 0)
            {
                if (newPeriod == 'A')
                {
                    newPeriod = 'P';
                }
                else
                {
                    newPeriod = 'A';
                }
            }
        }
        // If totalHour is 0
        if (totalHour == 0)
        {
            totalHour = 12; // reset to 12
        }

        // Return a new Clock object with the calculated values.
        return new Clock(totalHour, totalMinutes, newPeriod);
    }

    //  Greater-than operator to compare two Clock objects.
    public static bool operator >(Clock clk1, Clock clk2)
    {
        // If the clocks are in the same period
        if (clk1.ClockPeriod == 'P' && clk2.ClockPeriod == 'P')
        {
            // Compare hours, if hours are equal compare minutes
            if (
                clk1.Hours > clk2.Hours
                || (clk1.Hours == clk2.Hours && clk1.Minutes > clk2.Minutes)
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (clk1.ClockPeriod == 'P' && clk2.ClockPeriod != 'P')
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Less-than operator to compare two Clock objects.
    public static bool operator <(Clock clk1, Clock clk2)
    {
        // If the clocks are in the same period
        if (clk1.ClockPeriod == 'P' && clk2.ClockPeriod == 'P')
        {
            // Compare hours, if hours are equal compare minutes
            if (
                clk1.Hours < clk2.Hours
                || (clk1.Hours == clk2.Hours && clk1.Minutes < clk2.Minutes)
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (clk1.ClockPeriod == 'P' && clk2.ClockPeriod != 'P')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
