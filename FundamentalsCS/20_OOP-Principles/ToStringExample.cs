using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class ToStringExample
    {
        static void TSEG()
        {
            Console.WriteLine(new object());
            //Console.WriteLine(new Felidae(true));
            Console.WriteLine(new Lion(true, 80));

            //The result is:
            //System.Object
            //Chapter_20_OOP.Felidae
            //Chapter_20_OOP.Lion
        }
    }
}
