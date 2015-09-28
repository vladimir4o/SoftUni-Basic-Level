using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.WriteLine("Write the first float number you wish to compare: ");
            double num01 = double.Parse(Console.ReadLine());
            Console.WriteLine("Write anothe float number: ");
            double num02 = double.Parse(Console.ReadLine());
            double difference = 0.000001d;
            double result = Math.Abs(num01 - num02);
                 if (result < difference)
                 Console.WriteLine("True");
                 
                 else if
                 (result == difference)
                 Console.WriteLine("False");

                 else
                 Console.WriteLine("False");  
                 
            


        }
    }
}
