using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("How much do you weigh?");
        int weight = int.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on the Moon will be: " + ((float)17 / 100) * weight);
    }
    
}
