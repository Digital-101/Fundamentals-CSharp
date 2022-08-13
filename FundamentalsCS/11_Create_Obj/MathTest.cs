using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._11_Create_Obj
{
    class MathTest
    {
        static void Maths()
        {
            //Changes , to .
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.WriteLine("Length of the first side: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Length of the second side: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Size of the angle in degrees:: ");
            int angle = int.Parse(Console.ReadLine());

            double angleInRadians = Math.PI * angle / 180.0;
            Console.WriteLine("Area of the triangle: {0}", 0.5 * (a * b) * Math.Sin(angleInRadians));

            //Output:
            //Area of the triangle: 1,73205080756888
        }
    }
}
