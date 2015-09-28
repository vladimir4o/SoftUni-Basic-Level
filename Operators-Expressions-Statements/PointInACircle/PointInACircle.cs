using System;

class PointInACircle
{
    static void Main()
    {
        
        Console.WriteLine("Enter position x: ");
        float x = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter position y: ");
        float y = float.Parse(Console.ReadLine());

        int radius = 2;
        Console.WriteLine((x * x) + (y * y) <= radius * radius ? "True" : "False");

    }
    
}
