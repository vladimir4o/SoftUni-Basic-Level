using System;


namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the desired position of the bit: ");
            int p = int.Parse(Console.ReadLine());
            int nRightP = number >> p;
            int bit = nRightP & 1;
            Console.WriteLine("The bit at position {0} is: {1}", p, bit);
        }
    }
}
