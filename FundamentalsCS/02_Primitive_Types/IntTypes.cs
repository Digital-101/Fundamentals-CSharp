using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._2_Primitive_Types
{
    class IntTypes
    {
        static void ITEGG()
        {
            // Declare some variables
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;
            // Print the result on the console
            Console.WriteLine(centuries + " centuries are " + years +
            " years, or " + days + " days, or " + hours + " hours.");
            // Console output:
            // 20 centuries are 2000 years, or 730480 days, or 17531520
            // hours.
            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine(maxIntValue); // 18446744073709551615
            //Real Floating
            double nan = Double.NaN;
            Console.WriteLine(nan); // NaN
            double infinity = Double.PositiveInfinity;
            Console.WriteLine(infinity); // Infinity

            //Characters
            // Declare a variable
            char ch = 'a';
            // Print the results on the console
            Console.WriteLine(
            "The code of '" + ch + "' is: " + (int)ch);
            ch = 'b';
            Console.WriteLine(
            "The code of '" + ch + "' is: " + (int)ch);
            ch = 'A';
            Console.WriteLine(
            "The code of '" + ch + "' is: " + (int)ch);
            // Console output:
            // The code of 'a' is: 97
            // The code of 'b' is: 98
            // The code of 'A' is: 65


            ///OBJECTs
            ///// Declare some variables
            object container1 = 5;
            object container2 = "Five";
            // Print the results on the console
            Console.WriteLine("The value of container1 is: " + container1);
            Console.WriteLine("The value of container2 is: " + container2);
            // Console output:
            // The value of container1 is: 5
            // The value of container2 is: Five.


            //NULLS
            int i = 5;
            int? ni = i;
            Console.WriteLine(ni); // 5
                                   // i = ni; // this will fail to compile
            Console.WriteLine(ni.HasValue); // True
            i = ni.Value;
            Console.WriteLine(i); // 5
            ni = null;
            Console.WriteLine(ni.HasValue); // False
                                            //i = ni.Value; // System.InvalidOperationException
            i = ni.GetValueOrDefault();
        }
    }
}
