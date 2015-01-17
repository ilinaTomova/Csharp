using System;

class EmployeeData
{
    static void Main()
    {
        
        string firstName = "Ilina";
        string LastName = "Tomova";
        byte age = 26;
        char gender = 'f';
        string IDnumber = "8711150000";
        uint uniqueEmployeeNumber = 27561234;

        Console.WriteLine("Employee data :\nfirstname: {0}\nlastname: {1}\nage: {2}\ngender: {3}\nID number: {4}\nUnique Emploee number: {5}",
           firstName,LastName,age, gender,IDnumber, uniqueEmployeeNumber );
       
    }
}

