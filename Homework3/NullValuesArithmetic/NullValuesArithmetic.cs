using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? num01 = null;
            Console.WriteLine("The null value of num01 is: " + num01);
            num01 = 10;
            Console.WriteLine("This is the integer num01 with value 10 -> " + num01);

            double? num02 = null;
            Console.WriteLine("The null value of num02 is: " + num02);
            num02 = 10.5;
            Console.WriteLine("This is the real number num02 with value 10.5 -> " + num02);

        }
    }
}
