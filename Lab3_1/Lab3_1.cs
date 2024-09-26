/*
* Name: Onur (Honor) Onel
* Student Number: 0865803
* Date: 2024-09-19
* Lab 3, Part 1
* Program Description: This program computes the amount of money in a
* piggy-bank given the number of pennies, nickels, dimes, quarters,
* loonies, and twoonies.
*/
public static class Lab3_1
{
    public static void Main()
    {
        // declare the variables and constants
        int numPens, numNicks, numDimes, numQuarts, numLoons, numTwoons;
        double amtInPiggyBank;
        string name;
        Console.Clear();
        // Input the name of the user
        Console.Write("Enter your name => ");
        name = Console.ReadLine();
        // Input the number of pennies
        Console.Write("Enter the number of pennies in the Piggy Bank => ");
        numPens = Convert.ToInt32(Console.ReadLine());
        // Input the number of nickels
        Console.Write("Enter the number of nickels in the Piggy Bank => ");
        numNicks = Convert.ToInt32(Console.ReadLine());
        // Input the number of dimes
        Console.Write("Enter the number of dimes in the Piggy Bank => ");
        numDimes = Convert.ToInt32(Console.ReadLine());
        // Input the number of quarters
        Console.Write("Enter the number of quarters in the Piggy Bank => ");
        numQuarts = Convert.ToInt32(Console.ReadLine());
        // Input the number of loonies
        Console.Write("Enter the number of loonies in the Piggy Bank => ");
        numLoons = Convert.ToInt32(Console.ReadLine());
        // Input the number of twoonies
        Console.Write("Enter the number of twoonies in the Piggy Bank => ");
        numTwoons = Convert.ToInt32(Console.ReadLine());
        // Compute the amount in the Piggy Bank
        amtInPiggyBank = numPens * 0.01 + numNicks * 0.05 + numDimes * 0.10 + numQuarts * 0.25 + numLoons * 1 + numTwoons * 2;
        // Print out the amount in the Piggy Bank
        Console.WriteLine("{0} has {1:C} in the Piggy Bank", name, amtInPiggyBank);
    }
}