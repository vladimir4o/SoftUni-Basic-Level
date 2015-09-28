using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class OddsOrEven
    {
        static void Main()
        {
            int num01;
            Console.WriteLine("Write a integer number you want to check if its odd: ");
            num01 = int.Parse(Console.ReadLine());
            Console.WriteLine(num01 % 2 == 1 ? "The number is odd." : "The number is even.");

        }
    }
}
