/*
 * Onur (Honor) Onel
 * Student Number: 0865803
 * Student Email: onuronel@trentu.ca
 * Date Submitted: 2024-12-01
 *
 * `ClockDemo.cs`
 *
 * Description:
 * ************
 *   The `ClockDemo` class demonstrates the functionality of the `Clock` class.
 *   It includes examples of creating clocks, setting values, performing
 *   arithmetic operations, and comparing clocks. User input is also utilized
 *   for customization.
 */
public static class ClockDemo
{
    public static void Main()
    {
        Console.Clear();

        string programName = "Assignment 05: The 12-Hour Clock";
        Console.WriteLine(programName); // Print the program name
        for (int i = 0; i < programName.Length; i++) // Fashion by dev
        {
            Console.Write('*');
        }

        // Array of Clock objects to demonstrate various scenarios
        Clock[] testClock = new Clock[6];

        testClock[0] = new Clock(6, 30, 'A'); // Clock 1: 6:30 AM
        testClock[1] = new Clock(3, 40, 'P'); // Clock 2: 3:40 PM
        testClock[2] = new Clock(); // Clock 3: Default constructor
        testClock[3] = new Clock(); // Clock 4: Default constructor

        // Variables to hold user input
        int hour1;
        int hour2;
        int min;
        char period;

        // Input for Clock 3
        Console.WriteLine("\n\nEnter the values for Clock 3");
        Console.Write("Enter the Hour -> ");
        hour1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Minute -> ");
        min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Period (A/P) -> ");
        period = Convert.ToChar(Console.ReadLine());
        testClock[2].Hours = hour1;
        testClock[2].Minutes = min;
        testClock[2].ClockPeriod = period;

        // Input for Clock 4
        Console.WriteLine("\nEnter the values for Clock 4");
        Console.Write("Enter the Hour -> ");
        hour2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Minute -> ");
        min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Period (A/P) -> ");
        period = Convert.ToChar(Console.ReadLine());
        testClock[3].Hours = hour2;
        testClock[3].Minutes = min;
        testClock[3].ClockPeriod = period;

        // Add two clocks and assign the result to Clock 5 and Clock 6
        testClock[4] = testClock[0] + testClock[1]; // Add Clock 1 and Clock 2
        testClock[5] = testClock[2] + testClock[3]; // Add Clock 3 and Clock 4

        // Compare clocks for greater and lesser operations
        bool isGreater = testClock[0] > testClock[1]; // Clock 1 > Clock 2?
        bool isLower = testClock[2] < testClock[3]; // Clock 3 < Clock 4?

        // Display clock details
        Console.WriteLine("\nDetails:");
        for (int i = 0; i < testClock.Length; i++)
        {
            Console.WriteLine("Clock {0}: {1}", i + 1, testClock[i]);
        }

        // Display comparison results
        Console.WriteLine("\nComparisons:");
        Console.WriteLine("Clock 1 > Clock 2: {0}", isGreater);
        Console.WriteLine("Clock 3 < Clock 4: {0}", isLower);
    }
}
