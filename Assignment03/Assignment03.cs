/*
 * Onur (Honor) Onel
 * Student Number: 0865803
 * Student Email: onuronel@trentu.ca
 * Date: 2024-11-01
 *
 * `Assignment03.cs`
 * This program manages various transactions on a credit card balance, including purchasing an item,
 * making a cash withdrawal, making a payment, and displaying the balance. Each transaction type
 * updates or displays the balance according to user input.
 *
 * Data Dictionary:
 * ****************
 * const char BUY - 'B' represents a purchase transaction.
 * const char WITHDRAWAL - 'W' represents a cash withdrawal transaction.
 * const char PAYMENT - 'P' represents a payment transaction.
 * const char DISPLAY - 'D' represents displaying the credit card balance.
 * const char QUIT - 'Q' represents quitting the program.
 * double creditCardBalance - stores the current balance of the credit card, updated per transaction.
 * char transType - stores the type of transaction input by the user.
 * double amt - stores the amount for each transaction, entered by the user.
 */
public static class Assignment03
{
    /*
     * Method: Main
     * The main control loop that handles user input for various credit card transactions.
     * Based on the user’s input, it calls the corresponding function to handle the transaction
     * and updates the credit card balance accordingly. The loop continues until the user
     * selects 'q' to quit.
     */
    public static void Main()
    {
        // Transaction bptions
        const char BUY = 'B',
            WITHDRAWAL = 'W',
            PAYMENT = 'P',
            DISPLAY = 'D',
            QUIT = 'Q';

        double creditCardBalance = 0; // Initial balance
        char transType;
        double amt; // Amount of the transaction
        string programName = "Basic Card Transaction Program";

        Console.Clear();
        Console.WriteLine(programName);
        for (int i = 0; i < programName.Length; i++) // Fashion by dev
        {
            Console.Write('*');
        }
        // Displaying options
        Console.WriteLine("\nB: Buy");
        Console.WriteLine("W: Withdrawal");
        Console.WriteLine("P: Payment");
        Console.WriteLine("D: Display");
        Console.WriteLine("Q: Quit");
        do
        {
            Console.Write("\nEnter transaction type: ");
            transType = Convert.ToChar(Console.ReadLine()); // Read the input option from the user
            switch (char.ToUpper(transType))
            {
                case BUY: // If user inputs b or B
                    amt = ReadAmount(); // Ask the amount to user that will be proccessed
                    BuyAnItem(amt, ref creditCardBalance);
                    break;
                case WITHDRAWAL: // If user inputs w or W
                    amt = ReadAmount(); // Ask the amount to user that will be proccessed
                    CashWithdrawal(amt, ref creditCardBalance);
                    break;
                case PAYMENT: // If user inputs p or P
                    amt = ReadAmount(); // Ask the amount to user that will be proccessed
                    MakePayment(amt, ref creditCardBalance);
                    break;
                case DISPLAY: // If user inputs d or D
                    Display(creditCardBalance); // Display the avaliable balance
                    break;
                case QUIT: // If user inputs q or Q
                    Console.WriteLine("Quitting the program...");
                    return; // App terminates
                default: // If user inputs wrong character.
                    Console.WriteLine("Invalid Transaction Type entered.");
                    break;
            }
        } while (transType != QUIT); // As long as q or Q not chosen do above
    }

    /*
     * Method: ReadAmount
     * ReadAmount which takes no formal parameters but returns a non-negative value of
     * type double representing the cost of an item, the amount of cash withdrawn, or the amount of a
     * payment. ReadAmount is to be invoked by Main() when the user chooses to buy an item (B’ or
     * ‘b’), make a cash withdrawal (‘w’ or ‘W’), or make a payment (‘p’ or ‘P’). The ReadAmount
     * method is to prompt the user to enter an amount, validate that it is non-negative with a loop, and
     * then return the non-negative value.
     *
     * Parameters: None
     *
     * Local Variables:
     *    double amount - stores the validated non-negative amount.
     */
    public static double ReadAmount()
    {
        double amount; // Variable to store the entered amount

        do
        {
            Console.Write("Enter an amount: "); // Prompt user to enter an amount
            amount = Convert.ToDouble(Console.ReadLine()); // Read user input and convert it to a double

            // Check if the entered amount is negative
            if (amount < 0)
            {
                Console.WriteLine("Amount must be non-negative"); // Show error message if amount is negative
            }
        } while (amount < 0); // Repeat loop if amount is negative

        return amount; // Return the valid amount
    }

    /*
     * Method: BuyAnItem
     * A void method called BuyAnItem which accepts one call by value formal parameter of type
     * double (the amount of the item) and one call by reference formal parameter of type double (the
     * balance on the credit card). BuyAnItem first applies the HST (13%) to the amount of the item
     * and then determines if there is enough credit remaining on the card to allow the purchase to
     * complete. If there is, add the amount of the purchase (plus HST) to update the balance of the credit
     * card. If not, it will print an error message indicating that the purchase could not complete as it
     * would put the credit card over its limit. Assume that the limit on the credit card is $1500 (a
     * constant).
     *
     * Parameters:
     *    double itemAmt - cost of the item.
     *    ref double Balance - credit card balance.
     *
     * Local Variables:
     *    const double HST - 13% sales tax.
     *    const double CREDIT_LIMIT - maximum credit card limit ($1500).
    *     double taxCost - amount multiplied with HST (13% sales tax).
     *    double totalCost - item amount including HST.
     */
    public static void BuyAnItem(double amount, ref double ccBalance)
    {
        const double HST = 0.13; // Sales tax rate (13%)
        const double CREDIT_LIMIT = 1500.00; // Maximum allowable credit card balance

        double taxCost = amount * HST; // Calculate tax amount on the item
        double totalCost = amount + taxCost; // Calculate total cost including tax

        // Check if adding the total cost would stay within the credit limit
        if (ccBalance + totalCost <= CREDIT_LIMIT)
        {
            ccBalance += totalCost; // Update balance if within limit
            Console.WriteLine("New card balance is {0:C}", ccBalance); // Display updated balance in currency format
        }
        else
        {
            Console.WriteLine("Insufficient balance"); // Show error if balance would exceed limit
        }
    }

    /*
     * Method: CashWithdrawal
     * A void function called CashWithdrawal which accepts one call by value formal parameter of
     * type double (the amount of the cash withdrawal) and one call by reference formal parameter of
     * type double (the credit card balance). CashWithdrawal adds the amount of the cash withdrawal
     * plus a $2.50 service charge (use a constant) to the credit card balance if this amount (including
     * service charge) does not exceed the credit card limit ($1500). If the amount of the cash withdrawal
     * plus the service charge does exceed the credit limit, print an error message that the cash
     * withdrawal transaction could not be completed as the limit on the credit card would be reached.
     *
     * Parameters:
     *    double cashAmt - the cash withdrawal amount.
     *    ref double ccBalance - credit card balance.
     *
     * Local Variables:
     *    const double SERVICE_CHARGE - fixed service fee of $2.50.
     *    const double CREDIT_LIMIT - maximum credit card limit ($1500).
     *    double totalWithdrawal - total amount to be added to balance, including service charge.
     */
    public static void CashWithdrawal(double amount, ref double ccBalance)
    {
        const double SERVICE_CHARGE = 2.50; // Fixed service charge for each withdrawal
        const double CREDIT_LIMIT = 1500.00; // Maximum allowable credit card balance

        double totalWithdrawal = amount + SERVICE_CHARGE; // Calculate total amount including service charge

        // Check if adding the total withdrawal amount would stay within the credit limit
        if (ccBalance + totalWithdrawal <= CREDIT_LIMIT)
        {
            ccBalance += totalWithdrawal; // Update balance if within limit
            Console.WriteLine("New card balance is {0:C}", ccBalance); // Display updated balance in currency format
        }
        else
        {
            Console.WriteLine("Insufficient balance for this cash withdrawal."); // Show error if balance would exceed limit
        }
    }

    /*
     * Method: MakePayment
     * A void function called MakePayment which accepts one call by value formal parameter of type
     * double (the amount of the payment) and one call by reference formal parameter of type double
     * (the credit card balance). MakePayment simply subtracts the amount of the payment from the
     * credit card balance (it is fine to have a negative credit card balance).
     *
     * Parameters:
     *    double amount - the payment amount.
     *    ref double Balance - credit card balance.
     *
     * Local Variables: None
     */
    public static void MakePayment(double amount, ref double ccBalance)
    {
        ccBalance -= amount; // Subtract the payment amount from the current card balance
        Console.WriteLine("New card balance is {0:C}", ccBalance); // Display the updated balance in currency format
    }

    /*
     * Method: Display
     * A void function called Display which takes one call by value formal parameter of type double
     * which contains the credit card balance and then prints it out in a nice fashion.
     *
     * Parameters:
     *    double ccBalance - the current credit card balance.
     *
     * Local Variables: const double CREDIT_LIMIT - maximum credit card limit ($1500).
     */
    public static void Display(double ccBalance)
    {
        const double CREDIT_LIMIT = 1500.00; // Maximum allowable credit card balance

        // Calculate and display the available credit by subtracting the current balance from the credit limit
        Console.WriteLine("Available card balance is {0:C}", CREDIT_LIMIT - ccBalance);
    }
}
