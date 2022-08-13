using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._22_Lambda_LINQ
{
    class AnonTypes
    {
        static void Anon22()
        {
            var myCar = new { Color = "Red", Brand = "BMW", Speed = 180 };
            Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Brand);
            Console.WriteLine("It runs {0} km/h.", myCar.Speed);

            //Output:
            //My car is a Red BMW.
            //It runs 180 km / h.

            //############################################################################

            //Arrays of anon Types
            var arr = new[] {
                new { X = 3, Y = 5 },
                new { X = 1, Y = 2 },
                new { X = 0, Y = 7 }
            };
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
            //Result:
            //{ X = 3, Y = 5 }
            //{ X = 1, Y = 2 }
            //{ X = 0, Y = 7 }

            //############################################################################

            

        }
    }
}
