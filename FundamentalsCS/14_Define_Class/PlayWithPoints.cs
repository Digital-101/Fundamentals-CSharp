using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._14_Define_Class
{
    class PlayWithPoints
    {
        static void PrintPoint(point2D p)
        {
            Console.WriteLine("({0}, {1})", p.X, p.Y);
        }

        static void TryChangePoint(point2D p)
        {
            p.X++;
            p.Y++;
        }

        static void ShowMn()
        {
            point2D point = new point2D(3, -2);
            PrintPoint(point);
            TryChangePoint(point); //not changing
            PrintPoint(point);
            //(3, -2)
            //(3, -2)

        }
    }
}
