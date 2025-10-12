using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Exams
{
    public class StringReversal
    {
        public static string ReverseWords(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}
