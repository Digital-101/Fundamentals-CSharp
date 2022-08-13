using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._25Exam_2.C
{
    class PerFomTest
    {
        static void HJU()
        {
            //Perfomance Test

            StringBuilder expression = new StringBuilder();
            expression.Append("0");
            for (int i = 0; i < 1000000; i++)
            {
                expression.Append("+");
                expression.Append("1");
            }
            string expr = expression.ToString();
            //int[] numbers = ExtractNumbers(expr);
            //char[] operators = ExtractOperators(expr);
            //int result = CalculateExpression(numbers, operators);
            //Console.WriteLine(result);
        }
    }
}
