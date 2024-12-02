/*
 * Onur (Honor) Onel
 * Student Number: 0865803
 * Student Email: onuronel@trentu.ca
 * Date Submitted: 2024-12-01
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

    /*
     * Default constructor initializes the clock to 12:00 AM
     * Sets hours to 12, minutes to 0, and the clock period to 'A' AM
     */
    public Clock()
    {
        hours = 12;
        minutes = 0;
        clockPeriod = 'A';
    }

    /*
     * Three parameter constructor initializes the clock with custom values
     * Validates and sets hours, minutes, and clock period using their respective properties
     */

    public Clock(int hrs, int mins, char cType)
    {
        ClockPeriod = cType; // Use the ClockPeriod property to validate input
        Hours = hrs; // Use the Hours property to validate input
        Minutes = mins; // Use the Minutes property to validate input
    }

    /*
     * Property to get or set the hour value with validation.
     * Ensures the hour is between 1 and 12, defaulting to 12 if invalid
     */
    public int Hours
    {
        get { return hours; } // Return the current hour
        set
        {
            // Allow 0 for midnight
            if (value == 0)
            {
                hours = 12; // Adjust to 12-hour format
            }
            // Ensure hours are between 1 and 12
            else if (value >= 1 && value <= 12)
            {
                hours = value; // Set to valid hour
            }
            else
            {
                hours = 12; // Default to 12 for invalid input
                Console.WriteLine(
                    "\n{0} is an invalid hour value. It has been set to {1}",
                    value,
                    hours
                );
            }
        }
    }

    /*
     * Property to get or set the minute value with validation
     * Ensures the minute is between 0 and 59, defaulting to 0 if invalid
     */
    public int Minutes
    {
        get { return minutes; } // Return the current minute
        set
        {
            // Ensure minutes are between 0 and 59
            if (value < 60 && value >= 0)
            {
                minutes = value; // Set to valid minute
            }
            else
            {
                minutes = 0; // Default to 0 if the input is invalid
                Console.WriteLine(
                    "{0} is an invalid minute value. It has been set to {1}",
                    value,
                    minutes
                );
            }
        }
    }

    /*
     * Property to get or set the clock period (AM/PM) with validation
     * Ensures the period is either 'A' or 'P', defaulting to 'A' if invalid
     */

    public char ClockPeriod
    {
        get { return clockPeriod; } // Return the current period
        set
        {
            char upperValue = char.ToUpper(value); // Convert to uppercase

            // Ensure the period is either 'A' or 'P'
            if (upperValue == 'A' || upperValue == 'P') // Ensuring case-insensitivity
            {
                clockPeriod = upperValue; // Set to valid period
            }
            else
            {
                clockPeriod = 'A'; // Default to 'A' (AM) if the input is invalid
                Console.WriteLine(
                    "{0} is an invalid clock period. It has been set to {1}",
                    value,
                    clockPeriod
                );
            }
        }
    }

    /*
     * This method calculates the resulting time by converting the input clocks into total minutes,
     * handling any overflow in hours and minutes, and determining the correct 12-hour clock period
     * It ensures proper time wrapping within a 24-hour cycle and adjusts the result to the 12-hour format
     * before creating and returning a new Clock object
     */
    public static Clock operator +(Clock clk1, Clock clk2)
    {
        int hour1 = clk1.Hours;
        if (clk1.ClockPeriod == 'P' && hour1 != 12)
        {
            hour1 += 12; // Convert clk1 to 24-hour format
        }
        else if (clk1.ClockPeriod == 'A' && hour1 == 12)
        {
            hour1 = 0; // Set to zero if its 12
        }
        int hour2 = clk2.Hours;
        if (clk2.ClockPeriod == 'P' && hour2 != 12)
        {
            hour2 += 12; // Convert clk2 to 24-hour format
        }
        else if (clk2.ClockPeriod == 'A' && hour2 == 12)
        {
            hour2 = 0; // Set to zero if its 12
        }

        int totalMinutes1 = (hour1 * 60) + clk1.Minutes; // Calculate total minutes for the first clock
        int totalMinutes2 = (hour2 * 60) + clk2.Minutes; // Calculate total minutes for the second clock
        int totalMinutes = totalMinutes1 + totalMinutes2; // Add the total minutes of both clocks

        // Converting total minutes back to hours
        int finalHour = totalMinutes / 60 % 24;
        // Calculate the remaining minutes
        int finalMinute = totalMinutes % 60;

        char finalPeriod = 'A'; // Default clock period is AM
        if (finalHour >= 12) // Determine if the final time is in PM
        {
            finalPeriod = 'P'; // Switch to PM
            finalHour -= 12; // Adjust hour to 12-hour format
        }
        else if (finalHour == 0)
        {
            finalHour = 12; // Adjust midnight to 12 AM
        }
        return new Clock(finalHour, finalMinute, finalPeriod);
    }

    /**
    * Compares two Clock objects to determine if the first clock (clk1) represents a time later than the second clock (clk2).
    * Converts 12-hour format to 24-hour format for accurate comparison.
    */
    public static bool operator >(Clock clk1, Clock clk2)
    {
        int clk1Hours = clk1.Hours;
        int clk2Hours = clk2.Hours;

        // Convert to 24-hour format for comparison
        if (clk1.ClockPeriod == 'P' && clk1Hours != 12)
        {
            clk1Hours += 12; // Add 12 for PM times (except 12 PM)
        }
        if (clk1.ClockPeriod == 'A' && clk1Hours == 12)
        {
            clk1Hours = 0; // Convert 12 AM to 0
        }

        if (clk2.ClockPeriod == 'P' && clk2Hours != 12)
        {
            clk2Hours += 12; // Add 12 for PM times (except 12 PM)
        }
        if (clk2.ClockPeriod == 'A' && clk2Hours == 12)
        {
            clk2Hours = 0; // Convert 12 AM to 0
        }

        // Compare total time in minutes (hour * 60 + minutes)
        int clk1TotalMinutes = clk1Hours * 60 + clk1.Minutes;
        int clk2TotalMinutes = clk2Hours * 60 + clk2.Minutes;

        return clk1TotalMinutes > clk2TotalMinutes;
    }

    /**
     * Compares two Clock objects to determine if the first clock (clk1) represents a time earlier than the second clock (clk2).
     * Converts 12-hour format to 24-hour format for accurate comparison.
     */
    public static bool operator <(Clock clk1, Clock clk2)
    {
        int clk1Hours = clk1.Hours;
        int clk2Hours = clk2.Hours;

        // Convert to 24-hour format for comparison
        if (clk1.ClockPeriod == 'P' && clk1Hours != 12)
        {
            clk1Hours += 12; // Add 12 for PM times (except 12 PM)
        }
        if (clk1.ClockPeriod == 'A' && clk1Hours == 12)
        {
            clk1Hours = 0; // Convert 12 AM to 0
        }

        if (clk2.ClockPeriod == 'P' && clk2Hours != 12)
        {
            clk2Hours += 12; // Add 12 for PM times (except 12 PM)
        }
        if (clk2.ClockPeriod == 'A' && clk2Hours == 12)
        {
            clk2Hours = 0; // Convert 12 AM to 0
        }

        // Compare total time in minutes (hour * 60 + minutes)
        int clk1TotalMinutes = clk1Hours * 60 + clk1.Minutes;
        int clk2TotalMinutes = clk2Hours * 60 + clk2.Minutes;

        return clk1TotalMinutes < clk2TotalMinutes;
    }

    /*
    * Overrides ToString() to return the clock time in the format "Hour:MinutePeriod"
    * using validated property values
    */
    public override string ToString()
    {
        return Hours + ":" + Minutes + ClockPeriod; //Return the Properties since getters has validations
    }
}
