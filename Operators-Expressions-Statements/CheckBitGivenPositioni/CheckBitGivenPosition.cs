using System;

class CheckBitGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the desired position of the bit: ");
        int p = int.Parse(Console.ReadLine());
        
        bool hasValue1 = true;

        int nRightP = number >> p;
        int bit = nRightP & 1;
        if (bit == 1)
            Console.WriteLine(hasValue1);
        else
            Console.WriteLine(!hasValue1);
        
    }
    
}
