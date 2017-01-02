using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName;
            string lastName;
            byte age;
            char gender;
            string IDnumber;
            uint uniqueEmployeeNumber;

            firstName = "Amanda";
            lastName = "Somerville";
            age = 36;
            gender = 'f';
            IDnumber = "7903072317";
            uniqueEmployeeNumber = 45910231;
            Console.WriteLine("First name: {0} \nLast name: {1}\nAge: {2}\nGender: {3}\nID: {4}\nUnique Employee number: {5}", firstName, lastName, age, gender, IDnumber, uniqueEmployeeNumber);
        }
    }
}
