/*
* Onur (Honor) Onel
* Student Number: 0865803
* Student Email: onuronel@trentu.ca
* Date: 2024-09-28
*
* `Assignment02.cs`
* Description: 
* This program records and averages temperatures from three regions of Canada: 
* Western, Central, and Eastern Canada. The user inputs temperatures for each 
* region, and the program calculates and displays the average temperature for 
* each region. The program also ensures that the temperatures fall within a valid range.
*
* Data Dictionary:
*
* char regType         - Holds the region type entered by the user.
* double tempData      - Holds the temperature input by the user.
* char quit            - Holds the character 'q' for quit.
* char easternCanada   - Holds the character 'e' for Eastern Canada.
* char centralCanada   - Holds the character 'c' for Central Canada.
* char westernCanada   - Holds the character 'w' for Western Canada.
* int totalEastern     - Counts the number of temperature inputs for Eastern Canada.
* int totalCentral     - Counts the number of temperature inputs for Central Canada.
* int totalWestern     - Counts the number of temperature inputs for Western Canada.
* double sumWestern    - Adds on top the sum of temperatures for Western Canada.
* double sumCentral    - Adds on top the sum of temperatures for Central Canada.
* double sumEastern    - Adds on top the sum of temperatures for Eastern Canada.
* double avgWestern    - Holds the average temperature for Western Canada.
* double avgCentral    - Holds the average temperature for Central Canada.
* double avgEastern    - Holds the average temperature for Eastern Canada.
*
*/
public static class Assignment02
{
    public static void Main()
    {
        // Declaring variables
        char regType;
        double tempData;

        // Characters for region types and quitting
        char quit = 'q', easternCanada = 'e', centralCanada = 'c', westernCanada = 'w';

        // Variables to store total inputs and temperature sums for each region
        int totalEastern = 0, totalCentral = 0, totalWestern = 0;
        double sumWestern = 0, sumCentral = 0, sumEastern = 0;

        // Variables to store average temperatures for each region
        double avgWestern = 0, avgCentral = 0, avgEastern = 0;

        // Clear the console for fresh input
        Console.Clear();
        Console.Write("Enter a region type: W or w for Western Canada, C or c for Central Canada, and E or e for Eastern Canada, or enter Q or q to quit => ");
        regType = Console.ReadKey().KeyChar;

        // Loop until the user enters either 'q' or 'Q' to quit
        while (regType != quit && char.ToUpper(regType) != char.ToUpper(quit))
        {
            // If region is Western Canada
            if (regType == westernCanada || char.ToUpper(regType) == char.ToUpper(westernCanada))
            {
                // Ensure the temperature is within the valid range
                do
                {
                    Console.Write("\nEnter the temperature (>= -50C or <= 50C) => ");
                    tempData = Convert.ToDouble(Console.ReadLine());
                }
                while (tempData < -50.00 || tempData > 50.00);

                // Update Western Canada temperature
                totalWestern++;
                sumWestern += tempData;
                avgWestern = sumWestern / totalWestern;
            }
            // If region is Central Canada
            else if (regType == centralCanada || char.ToUpper(regType) == char.ToUpper(centralCanada))
            {
                // Ensure the temperature is within the valid range
                do
                {
                    Console.Write("\nEnter the temperature (>= -50C or <= 50C) => ");
                    tempData = Convert.ToDouble(Console.ReadLine());
                }
                while (tempData < -50.00 || tempData > 50.00);

                // Update Central Canada temperature
                totalCentral++;
                sumCentral += tempData;
                avgCentral = sumCentral / totalCentral;
            }
            // If region is Eastern Canada
            else if (regType == easternCanada || char.ToUpper(regType) == char.ToUpper(easternCanada))
            {
                // Ensure the temperature is within the valid range
                do
                {
                    Console.Write("\nEnter the temperature (>= -50C or <= 50C) => ");
                    tempData = Convert.ToDouble(Console.ReadLine());
                }
                while (tempData < -50.00 || tempData > 50.00);

                // Update Eastern Canada temperature
                totalEastern++;
                sumEastern += tempData;
                avgEastern = sumEastern / totalEastern;
            }
            else
            {
                // Handle invalid region input
                Console.WriteLine("\n***Invalid region type");
            }

            // Ask the user for the next region input or to quit
            Console.Write("Enter a region type: W or w for Western Canada, C or c for Central Canada, and E or e for Eastern Canada, or enter Q or q to quit => ");
            regType = Console.ReadKey().KeyChar;
        }

        // Display the average temperatures for each region
        Console.WriteLine("\nThe average temperature for Western Canada is {0:F2}", avgWestern);
        Console.WriteLine("The average temperature for Central Canada is {0:F2}", avgCentral);
        Console.WriteLine("The average temperature for Eastern Canada is {0:F2}", avgEastern);
    }
}

