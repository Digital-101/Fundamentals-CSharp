using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._25Exam_2.C
{
    public class SimpleExpressionEvaluator
    {
        private static int[] ExtractNumbers(string expression)
        {
            string[] splitResult = expression.Split('+', '-');
            int[] resultNumbers = new int[splitResult.Length];
            for (int i = 0; i < splitResult.Length; i++)
            {
                resultNumbers[i] = int.Parse(splitResult[i]);
            }
            return resultNumbers;
        }

        private static char[] ExtractOperators(string expression)
        {
            string operationCharacters = "+-";
            List<char> operators = new List<char>();
            foreach (char c in expression)
            {
                if (operationCharacters.Contains(c))
                {
                    operators.Add(c);
                }
            }
            return operators.ToArray();
        }

        private static long CalculateExpression(int[] numbers, char[] operators)
        {
            long result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                char operation = operators[i - 1];
                int nextNumber = numbers[i];
                if (operation == '+')
                {
                    result += nextNumber;
                }
                else if (operation == '-')
                {
                    result -= nextNumber;
                }
            }
            return result;
        }
        private static string ReadExpression()
        {
            Console.WriteLine("Enter expression:");
            string expression = Console.ReadLine();
            return expression;
        }

        static void MainEV()
        {
            try
            {
                string expression = ReadExpression();

                int[] numbers = ExtractNumbers(expression);
                char[] operators = ExtractOperators(expression);

                long result = CalculateExpression(numbers, operators);
                Console.WriteLine("{0} = {1}", expression, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid expression");
            }
        }
    }
}
