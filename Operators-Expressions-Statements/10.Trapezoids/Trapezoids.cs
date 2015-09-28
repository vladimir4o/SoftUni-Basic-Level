using System;

class Trapezoids
{
    static void Main()
    {                     
        Console.Write("Now we are going to calculate the area of trapezoid. \nSide a is: ");
        float sideA = float.Parse(Console.ReadLine());
        Console.Write("Side b is: ");
        float sideB = float.Parse(Console.ReadLine());
        Console.Write("Height: ");
        float height = float.Parse(Console.ReadLine());
        float area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The area of your trapezoid is: {0}", area);
    }
    
}
