/*
* Onur (Honor) Onel
* Student Number: 0865803
* Student Email: onuronel@trentu.ca
* Date: 2024-09-10
*
* `Program.cs`
* Description: This program calculates the tax owed by a person based on their total income.
* The tax owed is calculated based on the following rules:
* - Income from $0 to less than $15,000: 0% tax rate
* - Income from $15,000 to $50,000: 20% tax rate
* - Income from $50,000 to $110,000: 28% tax rate
* - Income from $110,000 to $150,000: 30% tax rate
* - Income from $150,000 to $200,000: 33% tax rate
* - For income greater than $200,000, a 5% surcharge is applied only to the portion of income above $200,000
* - A flat tax of $100 applies to all individuals with any income greater than $0
*/
public class Program
{
    public static void Main()
    {
        Console.Clear(); // First clear the console *VsCode specific*
        TaxCalculator taxCalculator = new(); // Created a new instance of the TaxCalculator class

        Console.Write("Enter the last name => ");
        taxCalculator.LastName = Console.ReadLine(); // Read the string last name from the user


        Console.Write("Enter the social insurance number => ");
        try
        {
            taxCalculator.SocialInsuranceNumber = Convert.ToInt32(Console.ReadLine()); // Read the int social insurance number from the user
        }
        catch (FormatException) // Catch the error if the social insurance number is not a number
        {
            Console.WriteLine("Social insurance number must be a number");
            return; // Exit the program
        }

        Console.Write("Enter the total income => ");
        try
        {
            taxCalculator.TotalIncome = Convert.ToInt32(Console.ReadLine());  // Read the integer total income from the user

            if (taxCalculator.TotalIncome < 0) // Check if the total income is less than 0
            {
                throw new ArgumentException("Total income cannot be negative"); // Throw an exception if the total income is negative 
            }
        }
        catch (FormatException) // Catch the error if the total income is not a number
        {
            Console.WriteLine("Total income must be a number");
            return; // Exit the program
        }
        catch (ArgumentException exception) // Catch the ArgumentException for negative income
        {
            Console.WriteLine(exception.Message);
            return; // Exit the program
        }

        double taxOwed = taxCalculator.TotalOwe(); // Calculate the tax owed by the user through totalOwe function
        Console.WriteLine($"The amount of tax owed by {taxCalculator.LastName}: {taxCalculator.SocialInsuranceNumber} is ${taxOwed:N2}"); // Print the final information to the user
    }
}