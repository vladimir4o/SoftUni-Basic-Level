using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Enter a number you wish to check: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine((number / 100) % 10 == 7 ? "True" : "False");
    }
    
}
