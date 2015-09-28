using System;

class FourDigitNumber
{
    static void Main()
    {
        label :
        Console.WriteLine("Enter a 4-digit number: ");
        int fourDigitNumber = int.Parse(Console.ReadLine());
        bool zeroCheck = (fourDigitNumber / 1000) % 10 == 0;

        if (zeroCheck == true)
        {
            Console.WriteLine("Your number can't start with a zero. Please try again.");
            goto label;
        }
        else
        {

            int a = (fourDigitNumber / 1000) % 10;
            int b = (fourDigitNumber / 100) % 10;
            int c = (fourDigitNumber / 10) % 10;
            int d = fourDigitNumber % 10;

            Console.WriteLine("The sum of your digits is: " + (a + b + c + d));
            Console.WriteLine("Your digits in reverse: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Your number with last digit in first position: {0}{1}{2}{3}", d, b, c, a);
            Console.WriteLine("Your number with exchanged second and third digits: {0}{1}{2}{3}", a, c, b, d);
        }
    }
    
}
