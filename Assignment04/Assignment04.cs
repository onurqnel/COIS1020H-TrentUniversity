/*
 * Onur (Honor) Onel
 * Student Number: 0865803
 * Student Email: onuronel@trentu.ca
 * Date Submitted: 2024-11-11
 *
 * `Assignment04.cs`
 *
 * Data Dictionary:
 * ****************
 * string programName  - Stores the title of the program to be displayed at the start.
 * char BOOK           - Constant for booking a seat
 * char CANCEL         - Constant for canceling a reservation
 * char DISPLAY        - Constant for displaying the seating assignments
 * char QUIT           - Constant for quitting the program
 * char commandType    - Holds the user's command input to determine program action.
 * string[] seats      - Array representing seating assignments with a size of 10 seats.
 * string customerName - Stores the customer name for booking or cancellation.
 * int custSeat        - Holds the index of the seat assigned to a customer if booked.
 * int availableSeat   - Holds the index of the first available seat for a new booking.
 */
public class Assignment04
{
    public static void Main()
    {
        //Variables
        const char BOOK = 'B', // Book option B || b
            CANCEL = 'X', // Cancel option X || x
            DISPLAY = 'D', // Display option D || d
            QUIT = 'Q'; // Quit Q || q
        char commandType; // Holds the users option choice

        // Array of the seats
        string[] seats = new string[10];

        // Menu
        string programName = "Basic Airline Reservation System";
        Console.Clear();
        Console.WriteLine(programName); // Print the program name for the menu
        for (int i = 0; i < programName.Length; i++) // Fashion by dev
        {
            Console.Write('*');
        }
        // Menu cont.
        Console.WriteLine("\nB: BOOK");
        Console.WriteLine("X: CANCEL");
        Console.WriteLine("D: Display");
        Console.WriteLine("Q: Quit");
        do
        {
            Console.Write("\nEnter command type: "); // Choose the option
            commandType = Convert.ToChar(Console.ReadLine()); // Read the users option
            switch (char.ToUpper(commandType)) // Switch between cases based on option
            {
                case BOOK: // B || b
                    BookSeat(seats);
                    break;
                case CANCEL: // X || x
                    CancelSeat(seats);
                    break;
                case DISPLAY: // D || d
                    DisplaySeat(seats);
                    break;
                case QUIT: // Q || q
                    Console.WriteLine("Quitting the program...");
                    return; // Terminates
                default: // If choice is not equivalent to one of our initialized variables
                    Console.WriteLine("Invalid command type entered."); // Do default behaviour
                    break;
            }
        } while (commandType != QUIT);
    }

    /*
     * Method: FindAvailableSeat
     * Finds the first available seat in the array of seats.
     * Returns the index of the first available seat which is first null element or -1 if the plane (array) is full.
     *
     * Parameters:
     * - seatAssign: An array representing the seating assignments, where each element corresponds to a seat.
     *
     */
    public static int FindAvailableSeat(string[] seatAssign)
    {
        for (int i = 0; i < seatAssign.Length; ++i) // Loop through array 0 to last element
        {
            if (seatAssign[i] == null) // Find the first null element starting from 0th element
            {
                return i; // return the first null elements index
            }
        }
        return -1; // otherwise (plane full) return -1, ussualy means error.
    }

    /*
     * Method: FindCustSeat
     * Finds the seat of a specified customer in the seating assignments.
     * Returns the index of the customer's seat or -1 if the customer has no seat.
     * If multiple seats have the same name, only the first one is returned.
     *
     * Parameters:
     * - seatAssign: An array representing the seating assignments, where each element corresponds to a seat.
     * - cName: A string representing the name of the customer whose seat is being searched.
     *
     */
    public static int FindCustSeat(string[] seatAssign, string cName)
    {
        for (int i = 0; i < seatAssign.Length; ++i) // Loop through array 0 to last element
        {
            if (cName == seatAssign[i]) // Finds the seat index of the specified customer name
            {
                return i; // return index
            }
        }
        return -1; // otherwise (name not found) return -1, ussualy means error.
    }

    /*
     * Method: BookSeat
     * Prompts for the customer's name and verifies that they have not already booked a seat.
     * If the customer has not booked, finds an available seat and assigns it.
     * If the plane is full, prints a message indicating no available seats.
     *
     * Parameters:
     * - seatAssign: An array representing the seating assignments, where each element corresponds to a seat.
     *
     * Local Variables:
     * - customerName: A string for storing the customer's name entered via console input.
     * - custSeat: An integer representing the seat index where the customer is currently booked, if any.
     * - availableSeat: An integer representing the index of the first available seat for booking.
     */
    public static void BookSeat(string[] seatAssign)
    {
        Console.WriteLine("\n-Welcome to booking-"); // Greetings
        Console.WriteLine("Please enter your name");
        string customerName = Console.ReadLine(); // Read customer name and initialize variable with it
        int custSeat = FindCustSeat(seatAssign, customerName); // Verifies that they have not already booked a seat
        if (custSeat != -1) // If its booked
        {
            Console.WriteLine("{0} already have booking for the seat {1}", customerName, custSeat); // let them know
        }
        else
        {
            int availableSeat = FindAvailableSeat(seatAssign); // Find the first avaliable seat, first null element.
            if (availableSeat >= 0 && availableSeat <= 10) // if avaliable seat is one of the null elements then,
            {
                seatAssign[availableSeat] = customerName; // Assign the name to it
                Console.WriteLine(
                    "Seat {0} has been successfully reserved for {1}",
                    availableSeat,
                    customerName
                ); // let them know
            }
            else
            {
                Console.WriteLine("Plane is full"); // Otherwise let them know
            }
        }
    }

    /*
     * Method: CancelSeat
     * Cancels the seat assignment for a specified customer.
     * Prompts for the customer's name, finds their seat, and sets it to null if valid.
     * If the customer has no seat, prints a message indicating no booking found.
     *
     * Parameters:
     * - seatAssign: An array representing the seating assignments, where each element corresponds to a seat.
     *
     * Local Variables:
     * - customerName: A string for storing the customer's name entered via console input.
     * - custSeat: An integer representing the seat index where the customer is currently booked, if any.
     */
    public static void CancelSeat(string[] seatAssign)
    {
        Console.WriteLine("\n-Welcome to cancelling-"); //Greetings
        Console.WriteLine("Please enter your name");
        string customerName = Console.ReadLine(); // Read customer name and initialize variable with it
        int custSeat = FindCustSeat(seatAssign, customerName); // Verifies that they have not already booked a seat
        if (custSeat != -1) // If its booked
        {
            seatAssign[custSeat] = null; // assign null (cancel)
            Console.WriteLine(
                "Booking for {0} has been successfully canceled from seat {1}.",
                customerName,
                custSeat
            ); // let them know
        }
        else
        {
            Console.WriteLine("Customer name does not have seat on this plane"); // Otherwise let them know
        }
    }

    /*
     * Method: DisplaySeat
     * Displays all occupied seats in the seating assignments.
     * Prints each seat number and the associated customer name. Skips empty seats.
     *
     * Parameters:
     * - seatAssign: An array representing the seating assignments, where each element corresponds to a seat.
     *
     */
    public static void DisplaySeat(string[] seatAssign)
    {
        // Loop through each element in the seatAssign array
        for (int i = 0; i < seatAssign.Length; ++i)
        {
            // Check if the seat at index i has been reserved (not null)
            if (seatAssign[i] != null)
            {
                // Display the reserved name and seat index
                Console.WriteLine("{0} has been reserved for the seat {1}", seatAssign[i], i);
            }
        }
    }
}
