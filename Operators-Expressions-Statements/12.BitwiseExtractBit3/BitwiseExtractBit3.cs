using System;

class BitwiseExtractBit3
{
     static void Main()
     {
         Console.WriteLine("Enter a positive number: ");
         int number = int.Parse(Console.ReadLine());
         int nRightP = number >> 3;
         int bit = nRightP & 1;
         Console.WriteLine("The bit at position 3 is: {0}", bit);
     }
    
}
