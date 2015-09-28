using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a positive number between 0 and 100 you wish to check if it's prime or not: ");
        int number = int.Parse(Console.ReadLine());
        int k = 0;
        for (int i = 1; i <= number; i++)
			{
			 if (number % i == 0)
                 k++;
			}
        if (k == 2)
            Console.WriteLine("True");

        else if (number > 100 || number < 0)
            Console.WriteLine("False.");

        else
            Console.WriteLine("False");
                        
               
            
    }
    
}
