/*
* Name: Onur (Honor) Onel
* Student Number: 0865803
* Date: 2024-10-03
* Lab 5 
*
* Program Description: 
* This program allows the user to input a student's last name and their grade (mark).
* It then converts the numeric grade into a letter grade using a method and displays the result.
*/
public static class Lab5
{
    public static void Main()
    {
        // declare variables
        int inpMark; // variable to hold the student's mark
        string lastName; // variable to hold the student's last name
        char grade = ' '; // variable to hold the letter grade, initialized to a space

        // clear the console screen for clean output
        Console.Clear();

        // prompt user for the student's last name
        Console.Write("Enter the last name of the student => ");
        lastName = Console.ReadLine(); // read and store the last name

        // prompt user for the student's mark and validate the input (ensure it's between 0 and 100)
        do
        {
            Console.Write("Enter a mark between 0 and 100 => ");
            inpMark = Convert.ToInt32(Console.ReadLine()); // convert input to integer
        } while (inpMark < 0 || inpMark > 100); // repeat until valid input is provided

        // call the MarkToGrade method to convert the numeric mark to a letter grade
        MarkToGrade(inpMark, ref grade);

        // print out the student's last name, mark, and the corresponding letter grade
        Console.WriteLine("{0}'s mark of {1} converts to a {2}", lastName, inpMark, grade);
    }

    // Method: MarkToGrade
    // Parameters:
    //      mark: an integer representing the student's numeric mark (passed by value)
    //      letterValue: a reference to a char where the corresponding letter grade will be stored (passed by reference)
    // Purpose: Converts the numeric mark to a letter grade based on the grading scheme
    public static void MarkToGrade(int mark, ref char letterValue)
    {
        // multi-alternative If statement to determine letter grade based on the mark value
        if (mark > 0 && mark < 50)
            letterValue = 'F'; // mark is between 0 and 49 -> grade is 'F'
        else if (mark >= 50 && mark < 60)
            letterValue = 'D'; // mark is between 50 and 59 -> grade is 'D'
        else if (mark >= 60 && mark < 75)
            letterValue = 'C'; // mark is between 60 and 74 -> grade is 'C'
        else if (mark >= 75 && mark < 85)
            letterValue = 'B'; // mark is between 75 and 84 -> grade is 'B'
        else if (mark >= 85 && mark <= 100)
            letterValue = 'A'; // mark is between 85 and 100 -> grade is 'A'
        else
        {
            // error handling for invalid marks (although should be caught in input validation)
            Console.WriteLine("***Error - invalid mark");
            letterValue = 'X'; // 'X' represents an invalid grade
        }
    }
}
