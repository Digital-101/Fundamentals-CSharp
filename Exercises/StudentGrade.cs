using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Exams
{
    public class StudentGrade
    {
        public static string Grade()
        {
            int mark = 0;
            string grade = "";

            Console.Write("Enter Student Mark?: ");
            mark = int.Parse(Console.ReadLine());


            if (mark < 0 || mark > 100)
            {
                Console.WriteLine("Grade cannot be negative");
                grade = "Invalid";
            }
            if (mark >= 90)
            {
                grade = "A+";
            }
            else if (mark >= 80)
            {
                grade = "A";
            }
            else if (mark > 69 || mark < 80)
            {
                grade = "B";
            }
            else if (mark > 59 || mark < 70)
            {
                grade = "C";
            }
            else if (mark > 49 || mark < 60)
            {
                grade = "D";
            }
            else if (mark > 39 || mark < 50)
            {
                grade = "E";
            }
            else
            {
                grade = "F";
            }

            return "Grade "+grade;
        }
    }
}
