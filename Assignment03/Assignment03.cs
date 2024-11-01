/*
 * Onur (Honor) Onel
 * Student Number: 0865803
 * Student Email: onuronel@trentu.ca
 * Date: 2024-11-01
 *
 * `Assignment03.cs`
 * Description:
 * This program manages various transactions on a credit card balance, including purchasing an item,
 * making a cash withdrawal, making a payment, and displaying the balance. Each transaction type
 * updates or displays the balance according to user input, with limits applied as necessary.
 *
 * Data Dictionary:
 * ******************
 * const char BUY - 'b' represents a purchase transaction.
 * const char WITHDRAWAL - 'w' represents a cash withdrawal transaction.
 * const char PAYMENT - 'p' represents a payment transaction.
 * const char DISPLAY - 'd' represents displaying the credit card balance.
 * const char QUIT - 'q' represents quitting the program.
 * double creditCardBalance - stores the current balance of the credit card, updated per transaction.
 * char transType - stores the type of transaction input by the user.
 * double amt - stores the amount for each transaction, entered by the user.
 */
public static class Assignment03
{
    /*
     * Method: Main
     * The main control loop that handles user input for various credit card transactions.
     * The user can choose to:
     * - Buy an item ('b')
     * - Make a cash withdrawal ('w')
     * - Make a payment ('p')
     * - Display the credit card balance ('d')
     * - Quit the program ('q')
     *
     * Based on the user’s input, it calls the corresponding function to handle the transaction
     * and updates the credit card balance accordingly. The loop continues until the user
     * selects 'q' to quit.
     */
    public static void Main()
    {
        const char BUY = 'b',
            WITHDRAWAL = 'w',
            PAYMENT = 'p',
            DISPLAY = 'd',
            QUIT = 'q';

        double creditCardBalance = 0;
        char transType;
        double amt;

        do
        {
            transType = Convert.ToChar(Console.ReadLine());

            switch (transType)
            {
                case 'b':
                    amt = ReadAmount();
                    BuyAnItem(amt, ref creditCardBalance);
                    break;
                case 'w':
                    amt = ReadAmount();
                    CashWithdrawal(amt, ref creditCardBalance);
                    break;
                case 'p':
                    amt = ReadAmount();
                    MakePayment(amt, ref creditCardBalance);
                    break;
                case 'd':
                    Display(creditCardBalance);
                    break;
                case 'q':
                    break;
                default:
                    Console.WriteLine("Invalid Transaction Type entered.");
                    break;
            }
        } while (transType != 'q');
    }

    /*
     * Method: ReadAmount
     * Prompts the user to enter a non-negative amount and returns it as a double.
     * The amount can represent a purchase, cash withdrawal, or payment.
     * Returns: A non-negative double value entered by the user.
     *
     * Parameters: None
     *
     * Local Variables:
     *    string userInput - holds the user’s input to convert to double.
     *    double amount - stores the validated non-negative amount.
     */
    public static double ReadAmount() { }

    /*
     * Method: BuyAnItem
     * Adds HST (13%) to the item amount and checks if there's enough credit to complete the purchase.
     * If yes, updates the credit card balance; if not, displays an error message.
     * Returns: None
     *
     * Parameters:
     *    double itemAmt - cost of the item (by value).
     *    ref double ccBalance - credit card balance (updated if purchase succeeds, by reference).
     *
     * Local Variables:
     *    const double HST_RATE - 13% sales tax.
     *    const double CREDIT_LIMIT - maximum credit card limit ($1500).
     *    double totalCost - item amount with HST.
     */
    public static void BuyAnItem(double amount, ref double balance) { }

    /*
     * Method: CashWithdrawal
     * Adds a cash withdrawal amount plus a $2.50 service charge to the credit card balance if it
     * does not exceed the $1500 limit. If it does exceed, displays an error message.
     * Returns: None
     *
     * Parameters:
     *    double cashAmt - the cash withdrawal amount (by value).
     *    ref double ccBalance - credit card balance (updated if withdrawal succeeds, by reference).
     *
     * Local Variables:
     *    const double SERVICE_CHARGE - fixed service fee of $2.50.
     *    const double CREDIT_LIMIT - maximum credit card limit ($1500).
     *    double totalWithdrawal - total amount to be added to balance, including service charge.
     */
    public static void CashWithdrawal(double amount, ref double balance) { }

    /*
     * Method: MakePayment
     * Subtracts the payment amount from the credit card balance. A negative balance is allowed.
     * Returns: None
     *
     * Parameters:
     *    double payAmt - the payment amount (by value).
     *    ref double ccBalance - credit card balance (updated after payment, by reference).
     *
     * Local Variables:
     *    None
     */
    public static void MakePayment(double amount, ref double balance) { }

    /*
     * Method: Display
     * Prints the credit card balance in a formatted style.
     * Returns: None
     *
     * Parameters:
     *    double ccBalance - the current credit card balance (by value).
     *
     * Local Variables: None
     */
    public static void Display(double balance) { }
}
