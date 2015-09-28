using System;

class Rectangles
{
    static void Main()
    {
        
        float width;
        Console.WriteLine("Enter the width of your rectangle: ");
        width = float.Parse(Console.ReadLine()); 

        float height;
        Console.WriteLine("Enter the height of your rectangle: ");
        height = float.Parse(Console.ReadLine());

        float area = width * height;
        float perimeter = (width + height) * 2;
                   
        Console.WriteLine("Perimeter: {0}, area: {1}", perimeter, area);
            
    }
    
}
