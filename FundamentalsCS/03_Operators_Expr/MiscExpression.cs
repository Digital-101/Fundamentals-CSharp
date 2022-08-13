using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._3_Operators_Expr
{
    class MiscExpression
    {
        static void Miscexr()
        {


            string quotation = "\"Hello, Queen\", he said.";
            Console.WriteLine(quotation);
            string path = "C:\\Windows\\notepad.exe";
            Console.WriteLine(path);
            string verbatim = @"The \ is not escaped as \\.
                                I am at a new line.";
            Console.WriteLine(verbatim);
            Console.ReadKey();

            float a = 0, b = 0;
            bool equal = Math.Abs(a - b) < 0.000001;

        }
    }
}
