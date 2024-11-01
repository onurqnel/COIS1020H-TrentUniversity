/*
* Name: Onur (Honor) Onel
* Student Number: 0865803
* Date: 2024-10-31
*
* Lab 8
* Program Description: This program uses four user-defined methods: one
*    to input an array of numbers, one to compute the average the array, one
*    to find the largest number in the array, and one to find the smallest
*    number in the array.
*/
public static class Lab8
{
    public static void Main()
    {
        int[] compStats = new int[25];
        int n = 0,
            large,
            small;
        double avg;

        Console.Clear();
        // Input values into the array
        InpArray(compStats, ref n);

        // Find the average of the elements in the array
        avg = FindAverage(compStats, n);

        // Find the largest element in the array
        large = FindLarge(compStats, n);

        // Find the smallest element in the array
        small = FindSmall(compStats, n);

        // Print out the results
        Console.WriteLine("\nThe Average of the array is {0:F2}", avg);
        Console.WriteLine("\nThe Largest of the array is {0}", large);
        Console.WriteLine("\nThe Smallest of the array is {0}", small);
    }

    // Method:       InpArray
    // Description:  Input values into an array.
    // Parameters:   arrValues: the array to fill.
    //               num: number of elements in the array.
    // Returns:      void
    public static void InpArray(int[] arrValues, ref int num)
    {
        // input the number of data values to put in the array
        do
        {
            Console.Write("Enter the number of elements (<= 25) => ");
            num = Convert.ToInt32(Console.ReadLine());
        } while (num < 0 || num > 25);

        // loop to enter the values
        for (int i = 0; i < num; ++i)
        {
            Console.Write("Enter the Element {0} => ", i);
            arrValues[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    // Method:       FindAverage
    // Description:  Computes the average of the elements in the array.
    // Parameters:   arrVals: array to be processed
    //               num: number of elements in the array.
    // Returns:      the average of the elements in the array
    public static double FindAverage(int[] arrVals, int num)
    {
        int result = 0;
        for (int o = 0; o < num; o++)
        {
            result += arrVals[o];
        }
        if (result == 0)
        {
            return result;
        }
        return (double)result / num;
    }

    // Method:       FindLarge
    // Description:  Determines the largest element in the array.
    // Parameters:   arrVals: array to be processed
    //               num: number of elements in the array.
    // Returns:      the largest element in the array
    public static int FindLarge(int[] arrVals, int num)
    {
        int largest = arrVals[0];
        for (int o = 1; o < num; o++)
        {
            if (largest < arrVals[o])
            {
                largest = arrVals[o];
            }
        }
        return largest;
    }

    // Method:       FindSmall
    // Description:  Determines the smallest element in the array.
    // Parameters:   arrVals: array to be processed
    //               num: number of elements in the array.
    // Returns:      the smallest element in the array
    public static int FindSmall(int[] arrVals, int num)
    {
        int smallest = arrVals[0];
        for (int o = 1; o < num; o++)
        {
            if (smallest > arrVals[o])
            {
                smallest = arrVals[o];
            }
        }
        return smallest;
    }
}
