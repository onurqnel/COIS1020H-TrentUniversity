/*
* Name: Onur (Honor) Onel
* Student Number: 0865803
* Date: 2024-09-19
* Lab 3, Part 2
* Program Description: This program calculates the cost of the package based on its weight and flat price
*/
public static class Lab3_2
{
   public static void Main()
   {
      // declare the variables and constants
      const double FLAT = 1.25;
      double weight;
      double cost, pricePerKg = 0;

      Console.Clear();
      // Input the weight
      Console.Write("Enter a positive weight of the package => ");
      weight = Convert.ToDouble(Console.ReadLine());
      // Determine the cost per kilogram
      if (weight <= 0)
      {
         Console.WriteLine("*** Invalid weight");

      }
      else if (weight < 1)
      {
         pricePerKg = 0.25;

      }
      else if (weight >= 1 && weight <= 3.5)
      {
         pricePerKg = 0.5;
      }
      else if (weight > 3.5)
      {
         pricePerKg = 1.0;

      }
      // Compute the cost to send the package
      if (weight > 0)
      {
         cost = weight * pricePerKg + FLAT;
      }
      else
      {
         cost = 0;
      }
      // Output the results
      Console.WriteLine("The cost to send the package is {0:C}", cost);
   }
}