using System;

class BitExchange
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        //Get the bit at position 3
        int bit3 = (number >> 3) & 1;

        //Get the bit at positioin 24
        int bit24 = (number >> 24) & 1;

        //Set bit from position 3 to position 24
        number = number & (~(1 << 24)) | (bit3 << 24);

        //Set bit from position 24 to position 3
        number = number & (~(1 << 3)) | (bit24 << 3);

        int bit4 = (number >> 4) & 1;
        int bit25 = (number >> 25) & 1;
        number = number & (~(1 << 25)) | (bit4 << 25);
        number = number & (~(1 << 4)) | (bit25 << 4);

        int bit5 = (number >> 5) & 1;
        int bit26 = (number >> 26) & 1;
        number = number & (~(1 << 26)) | (bit5 << 26);
        number = number & (~(1 << 5)) | (bit26 << 5);

        Console.WriteLine(number);
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
