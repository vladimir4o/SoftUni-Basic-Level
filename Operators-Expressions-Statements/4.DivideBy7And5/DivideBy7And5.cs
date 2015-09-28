using System;


class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Write a number you wish to check if its divided by 5 or 7 without reminder: ");
        int num01 = int.Parse(Console.ReadLine());

        bool canBeDividedBy5 = num01 % 5 == 0;
        bool canBeDividedBy7 = num01 % 7 == 0;

        Console.WriteLine(canBeDividedBy5 && canBeDividedBy5);

    }
    
}
