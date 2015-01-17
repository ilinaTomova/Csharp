using System;

class PrintCompanyInformation
{
    static void Main()
    {

        Console.Write("Company name :");
        string companyName = Console.ReadLine();
        Console.Write("Company address :");
        string address = Console.ReadLine();
        Console.Write("Phone number :");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter Company fax :");
        string fax = Console.ReadLine();
        Console.Write("Enter Company web site :");
        string webSite = Console.ReadLine();      
        Console.Write("Manager first name :");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name :");
        string lastName = Console.ReadLine();
        Console.Write("Manager age :");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Manager phone :");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0}", companyName);
        Console.WriteLine("{0}", address);
        Console.WriteLine("Tel. {0}", companyPhone);
        if (fax == null)
        {
            Console.WriteLine("No fax");
        }
        else
        {
            Console.WriteLine("Fax: {0}", fax);
        }
        Console.WriteLine(" ");
        Console.WriteLine("Web site: {0}" , webSite);
        Console.WriteLine("Manager: {0} {1} ({2}, tel. {3})", firstName, lastName, age, managerPhone);

    }
}
