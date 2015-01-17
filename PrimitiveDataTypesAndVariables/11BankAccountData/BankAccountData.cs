using System;
class BankAccountData
{
    static void Main()
    {
        
        //available amount of money (balance), bank name, IBAN, 3 credit card numbers 
        //associated with the account. Declare the variables needed to keep the 
        //information for a single bank account using the appropriate data types and descriptive names.

        string firstName = "Ilina";
        string middleName = "Ivanova";
        string lastName = "Tomova";
        object accountHolder = (string)firstName + " " + middleName + " " + lastName;
        string bankName = "Procredit Bank EAD";
        string bIC = "PRCBBGSF";
        object bankinfo = (string)bankName + " " + bIC;
        string Ibanfirst = "BG23PRCB92301034287623";
        long cardfirst = 4260820087654321;
        decimal amountFirst = 34.0987m;
        string IbanSecond = "BG23PRCB92301234566237";
        long cardSecond = 4260898755324654;
        decimal amountSecond = 100000.98754m;
        string IbanThird = "BG23PRCB92309876543623";
        long cardThird = 4267654437898765;
        decimal amountThird = 98279.98798794m;
       
        Console.WriteLine(bankinfo);
        Console.WriteLine(accountHolder);
        Console.WriteLine("\nIban : {0}\nCard Number : {1}\nAmount : {2}", Ibanfirst, cardfirst, amountFirst);
        Console.WriteLine("\nIban : {0}\nCard Number : {1}\nAmount : {2}", IbanSecond, cardSecond, amountSecond);
        Console.WriteLine("\nIban : {0}\nCard Number : {1}\nAmount : {2}", IbanThird, cardThird, amountThird);


         


    }
}

