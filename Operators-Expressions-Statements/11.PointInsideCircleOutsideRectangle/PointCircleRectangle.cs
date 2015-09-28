using System;

class PointCircleRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter position x: ");
        float x = float.Parse(Console.ReadLine());
        

        Console.WriteLine("Enter position y: ");
        float y = float.Parse(Console.ReadLine());
        

        float radius = 1.5f;

        bool isInCircle = ((x - 1) * (x - 1) + ((y - 1) * (y - 1)) <= radius * radius);
        bool inRectangle = (x >= -1 && x <= 5 && y >= -1 && y <= 1); 
        
        if(isInCircle && !inRectangle)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
    
}
