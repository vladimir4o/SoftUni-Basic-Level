using System;


namespace AgeCalc
{
    class AgeCalc
    {
        static void Main()
        {
            DateTime CurrentDate = DateTime.Today;
            DateTime BirthDay;

            Console.WriteLine("Please, enter your birthday (dd/mm/yyyy): ");
            BirthDay = DateTime.Parse(Console.ReadLine());

            int age = CurrentDate.Year - BirthDay.Year;

            if (BirthDay > CurrentDate.AddYears(-age)) age--;

            Console.WriteLine("You are {0} years old. In 10 years you will be {1}", age, age+10);
          
        }
    }
}
