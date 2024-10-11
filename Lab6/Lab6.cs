/*
* Name: Onur (Honor) Onel
* Student Number: 0865803
* Date: 2024-10-10
* Lab 6
*
* Program Description: 
* This program uses two user defined methods to compute the gross pay and net pay 
* for an employee after entering the employee’s last name, hours worked, hourly rate, and percentage of tax.
*/
public static class Lab6
{
    public static void Main()
    {
        // declare variables
        int hrsWrked; // stores the number of hours worked
        double ratePay, taxRate, grossPay, overTimePay, netPay = 0; // stores hourly rate, tax rate, gross pay, overtime pay, and net pay
        string lastName; // stores the employee's last name

        Console.Clear(); // clears the console for new input
        // enter the employee's last name
        Console.Write("Enter the last name of the employee => ");
        lastName = Console.ReadLine(); // reads the employee's last name

        // enter (and validate) the number of hours worked (positive number)
        do
        {
            Console.Write("Enter the number of hours worked (> 0) => ");
            hrsWrked = Convert.ToInt32(Console.ReadLine()); // reads the number of hours worked
        } while (hrsWrked < 0); // repeat until a valid positive number is entered

        // enter (and validate) the hourly rate of pay (positive number)
        do
        {
            Console.Write("Enter the hourly rate of pay (> 0) => ");
            ratePay = Convert.ToDouble(Console.ReadLine()); // reads the hourly rate of pay
        } while (ratePay < 0); // repeat until a valid positive number is entered

        // enter (and validate) the percentage of tax (between 0 and 1)
        do
        {
            Console.Write("Enter the percentage of tax (> 0 and < 1) => ");
            taxRate = Convert.ToDouble(Console.ReadLine()); // reads the tax percentage
        } while (!(taxRate > 0 && taxRate < 1)); // repeat until a valid percentage is entered

        // Call a method to calculate the gross pay (call by value)
        grossPay = CalculateGross(hrsWrked, ratePay); // calculates the gross pay based on hours worked and rate

        // Invoke a method to calculate the net pay (call by reference)
        CalculateNet(grossPay, taxRate, ref netPay); // calculates the net pay by deducting tax from gross pay

        overTimePay = CalculateOT(hrsWrked, ratePay); // calculates the overtime pay

        // print out the results
        Console.WriteLine("{0} worked {1} hours at {2:C} per hour", lastName,
                          hrsWrked, ratePay); // displays employee's last name, hours worked, and hourly rate
        Console.WriteLine("Gross pay is {0:C}, and net pay is {1:C}", grossPay, netPay); // displays gross and net pay

        Console.WriteLine("Over time pay is {0:C}", overTimePay); // displays the overtime pay
    }

    // Method: CalculateGross
    // Parameters
    //      hours: integer storing the number of hours of work
    //      rate: double storing the hourly rate
    // Returns: double storing the computed gross pay
    public static double CalculateGross(int hours, double rate)
    {
        return hours * rate + CalculateOT(hours, rate); // calculates gross pay including overtime
    }

    // Method: CalculateNet
    // Parameters
    //      grossP: double storing the grossPay
    //      tax: double storing tax percentage to be removed from gross pay
    //      netP: call by reference double storing the computed net pay
    // Returns: void
    public static void CalculateNet(double grossP, double tax, ref double netP)
    {
        netP = grossP - (grossP * tax); // calculates net pay by subtracting tax from gross pay
    }

    // Method: CalculateOT
    // Parameters
    //      hours: integer storing the number of hours worked
    //      rate: double storing the hourly rate
    // Returns: double storing the computed overtime pay
    public static double CalculateOT(int hours, double rate)
    {
        if (hours > 40) // check if hours worked is greater than 40 (for overtime)
        {
            return (hours - 40) * rate * 0.5; // calculates overtime pay at half of the regular rate
        }
        else
        {
            return 0; // no overtime pay if hours worked is less than or equal to 40
        }
    }
}

