using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Vladimir";
        string lastName = "Todorov";
        byte age = 33;
        char gender = 'm';
        long ucn = 7312018865;
        int employeeNumber = 27560000;

        Console.WriteLine ("Employee name: {0} {1} \nAge: {2} \nGender: {3} \nUnique citizenship number: {4} \nEmloyee number: {5}", firstName, lastName, age, gender, ucn, employeeNumber);
        
    }
    
}
