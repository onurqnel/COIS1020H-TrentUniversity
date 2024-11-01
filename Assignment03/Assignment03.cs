﻿/*
* Onur (Honor) Onel
* Student Number: 0865803
* Student Email: onuronel@trentu.ca
* Date: 2024-11-01
*
* `Assignment02.cs`
*  Description: 
*
*
* Data Dictionary:
******************
*
*
*/
public static class Assignment03
{
    public static void Main()
    {
        const char 
            BUY = 'b',
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
        }
        while (transType != 'q');
    }

    public static double ReadAmount()
    {

    }

    public static void BuyAnItem(double amount, ref double balance)
    {

    }

    public static void CashWithdrawal(double amount, ref double balance)
    {

    }

    public static void MakePayment(double amount, ref double balance)
    {

    }

    public static void Display(double balance)
    {
    }
}
