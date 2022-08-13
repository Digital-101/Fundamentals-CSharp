using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._16_Linear_DataStruct
{
    class StackUsage
    {
        static void stEG()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("1. John");
            stack.Push("2. Nicolas");
            stack.Push("3. Mary");
            stack.Push("4. George");
            Console.WriteLine("Top =  " +stack.Peek());
            while (stack.Count > 0)
            {
                string personName = stack.Pop();
                Console.WriteLine(personName);
            }
        }

        //Correct Bracket Check
        static void BrackEG()
        {
            string expression = "1 + (3 + 2 - (2+3)*4 - ((3+1)*(4-2)))";
            Stack<int> stack = new Stack<int>();
            bool correctBrackets = true;

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];
                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        correctBrackets = false;
                        break;
                    }
                    stack.Pop();
                }
            }
            if (stack.Count != 0)
            {
                correctBrackets = false;
            }
            Console.WriteLine("Are the brackets correct? "+correctBrackets);
        }
    }
}
