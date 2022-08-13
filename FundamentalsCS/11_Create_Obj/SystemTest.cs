using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._11_Create_Obj
{
    class SystemTest
    {
        static void SysTest()
        {
            int sum = 0;
            int startTime = Environment.TickCount;

            //The code fragment to be tested
            for (int i = 0; i < 10000000; i++)
            {
                sum++;
            }

            int endTime = Environment.TickCount;
            Console.WriteLine("The time elapsed is {0} sec.", (endTime - startTime) / 1000.0);
            //Result:
            //The time elapsed is 0.016 sec.
        }
    }
}
