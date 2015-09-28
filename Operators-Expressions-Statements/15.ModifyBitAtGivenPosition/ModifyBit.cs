using System;

class ModifyBit
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit posiion: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit value you want to set (0 or 1) at the desired position: ");
        int v = int.Parse(Console.ReadLine());

        int mask = ~(1 << p);
        int result1 = number & mask;
        if (v == 0)
        {
            Console.WriteLine("Result: {0}\nBinary result: {1}", result1, Convert.ToString(result1, 2).PadLeft(16, '0'));
        }
        else
        {
            int anotherMask = 1 << p;
            int result2 = result1 | anotherMask;
            Console.WriteLine("Result: {0}\nBinary result: {1}", result2, Convert.ToString(result2, 2).PadLeft(16, '0'));
        }
        
    }
    
}
