public class Assignment04
{
    public static void Main()
    {
        string programName = "Basic Airline Reservation System";
        Console.Clear();
        Console.WriteLine(programName);
        for (int i = 0; i < programName.Length; i++)
        {
            Console.Write('*');
        }
        const char BOOK = 'B',
            CANCEL = 'X',
            DISPLAY = 'D',
            QUIT = 'Q';
        char commandType;
        string[] seats = new string[10];

        Console.WriteLine("\nB: BOOK");
        Console.WriteLine("X: CANCEL");
        Console.WriteLine("D: Display");
        Console.WriteLine("Q: Quit");
        do
        {
            Console.Write("\nEnter command type: ");
            commandType = Convert.ToChar(Console.ReadLine());
            switch (char.ToUpper(commandType))
            {
                case BOOK:
                    BookSeat(seats);
                    break;
                case CANCEL:
                    CancelSeat(seats);
                    break;
                case DISPLAY:
                    DisplaySeat(seats);
                    break;
                case QUIT:
                    Console.WriteLine("Quitting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid command type entered.");
                    break;
            }
        } while (commandType != QUIT);
    }

    /*
     * Finds the first available seat in the array of seats.
     * Returns the index of the first available seat which is null or -1 if the plane is full.
     */
    public static int FindAvailableSeat(string[] seatAssign)
    {
        for (int i = 0; i < seatAssign.Length; ++i)
        {
            if (seatAssign[i] == null)
            {
                return i;
            }
        }
        return -1;
    }

    /*
     * Finds the seat of a specified customer in the seating assignments.
     * Returns the index of the customer's seat or -1 if the customer has no seat.
     * If multiple seats have the same name, only the first one is returned.
     */
    public static int FindCustSeat(string[] seatAssign, string cName)
    {
        for (int i = 0; i < seatAssign.Length; ++i)
        {
            if (cName == seatAssign[i])
            {
                return i;
            }
        }
        return -1;
    }

    /*
     * Books a seat for a customer.
     * Prompts for the customer's name and verifies that they have not already booked a seat.
     * If the customer has not booked, finds an available seat and assigns it.
     * If the plane is full, prints a message indicating no available seats.
     */
    public static void BookSeat(string[] seatAssign)
    {
        Console.WriteLine("\n-Welcome to booking-");
        Console.WriteLine("Please enter your name");
        string customerName = Console.ReadLine();
        int custSeat = FindCustSeat(seatAssign, customerName);
        if (custSeat != -1)
        {
            Console.WriteLine("{0} already have booking for the seat {1}", customerName, custSeat);
        }
        else
        {
            int availableSeat = FindAvailableSeat(seatAssign);
            if (availableSeat >= 0)
            {
                seatAssign[availableSeat] = customerName;
                Console.WriteLine(
                    "Seat {0} has been successfully reserved for {1}",
                    availableSeat,
                    customerName
                );
            }
            else
            {
                Console.WriteLine("Plane is full");
            }
        }
    }

    /*
     * Cancels the seat assignment for a specified customer.
     * Prompts for the customer's name, finds their seat, and sets it to null if valid.
     * If the customer has no seat, prints a message indicating no booking found.
     */
    public static void CancelSeat(string[] seatAssign) { }

    /*
     * Displays all occupied seats in the seating assignments.
     * Prints each seat number and the associated customer name.
     * Skips empty seats.
     */
    public static void DisplaySeat(string[] seatAssign)
    {
        for (int i = 0; i < seatAssign.Length; ++i)
        {
            if (seatAssign[i] != null)
            {
                Console.WriteLine("{0} has been reserved for the seat {1}", seatAssign[i], i);
            }
        }
    }
}
