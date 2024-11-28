using System.Runtime.InteropServices;

public static class ClockDemo
{
    public static void Main()
    {
        Console.Clear();

        Clock[] testClock = new Clock[6];
        testClock[0] = new Clock(6, 42, 'P');
        testClock[1] = new Clock(7, 19, 'A');
        testClock[2] = new Clock();
        testClock[3] = new Clock();
        int hour;
        int min;
        char period;

        Console.WriteLine("Enter the values for  clock 3");
        Console.Write("Enter the Hour -> ");
        hour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Minute -> ");
        min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Period -> ");
        period = Convert.ToChar(Console.ReadLine());
        testClock[2].Hours = hour;
        testClock[2].Minutes = min;
        testClock[2].ClockPeriod = period;

        Console.WriteLine("Enter the values for clock 4");
        Console.Write("Enter the Hour -> ");
        hour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Minute -> ");
        min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Period -> ");
        period = Convert.ToChar(Console.ReadLine());
        testClock[3].Hours = hour;
        testClock[3].Minutes = min;
        testClock[3].ClockPeriod = period;

        Console.WriteLine("\nClock details:");
        for (int i = 0; i < testClock.Length; i++)
        {
            Console.WriteLine("Clock {0}", testClock[i]);
        }
    }
}
