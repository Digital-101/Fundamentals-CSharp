using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._24Exam_1.B
{
    class LabyTest
    {
        static void IOFR()
        {
            Maze maze = new Maze();
            maze.ReadFromFile("Problem2.in");
            int pathLength = maze.FindShortestPath();
            maze.SaveResult("Problem2.out", pathLength);
            //Console.WriteLine(maze.FindShortestPath());
        }

        //Complete Solution
        //Input     Output  Input   Output  Input   Output  Input   Output
        //0         -1      2       -1      3       -1      3       1
        //                  00              0x0             000
        //                  xx              x*x             000 
        //                                  0x0             00*


    }
}
