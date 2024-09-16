/*
* Onur (Honor) Onel
* Student Number: 0865803
* Student Email: onuronel@trentu.ca
* Date: 2024-09-10
*
* `TaxCalculator.cs`
* Description: This class encapsulates the logic and properties for calculating the tax owed by a person based on their total income.
* The `TaxCalculator` class follows Object Oriented Programming principles. Direct manipulation of the class logic and properties is not allowed.
* However, public getters and setters provide controlled access to the properties. 
* The class also contains private logic to determine the tax rate based on the total income to calculate the total tax owed.
*
* Variable List:
* _lastName (string) - Stores the last name of the person. Default value is an empty string.
* _socialInsuranceNumber (int) - Stores the person's social insurance number.
* _totalIncome (int) - Represents the person's total income in integer format.
* _taxRate (double) - Holds the tax rate based on the total income.
* _taxOwed (double) - The final calculated tax owed by the person.
*/
public class TaxCalculator
{
    private string _lastName = "";
    private int _socialInsuranceNumber;
    private int _totalIncome;
    private double _taxRate;
    private double _taxOwed;

    public TaxCalculator() { }

    public string LastName // Getter and setter for the last name
    {
        get => _lastName;
        set => _lastName = value;
    }

    public int SocialInsuranceNumber // Getter and setter for the social insurance number
    {
        get => _socialInsuranceNumber;
        set => _socialInsuranceNumber = value;
    }

    public int TotalIncome // Getter and setter for the total income
    {
        get => _totalIncome;
        set => _totalIncome = value;
    }


    private void CalculateTaxRate()
    {
        if (_totalIncome >= 0 && _totalIncome <= 15000) // Income between $0 and $15,000
        {
            _taxRate = 0.00;
        }
        else if (_totalIncome > 15000 && _totalIncome <= 50000) // Income between $15,000 and $50,000
        {
            _taxRate = 0.20;
        }
        else if (_totalIncome > 50000 && _totalIncome <= 110000) // Income between $50,000 and $110,000
        {
            _taxRate = 0.28;
        }
        else if (_totalIncome > 110000 && _totalIncome <= 150000) // Income between $110,000 and $150,000
        {
            _taxRate = 0.30;
        }
        else if (_totalIncome > 150000 && _totalIncome < 200000) // Income between $150,000 and $200,000
        {
            _taxRate = 0.33;
        }
        else if (_totalIncome >= 200000) // Income greater than $200,000
        {
            _taxRate = 0.33 + 0.05; // 5% surcharge applied to the portion of income above $200,000
        }
    }

    public double TotalOwe()
    {
        CalculateTaxRate(); // Calls the function for calculate the tax rate based on the total income
        double flatTax = 100; // Flat tax of $100
        _taxOwed = _totalIncome * _taxRate; // Calculate the tax owed based on the tax rate
        return _taxOwed + flatTax; // Return the total tax owed with additional flat tax
    }
}
