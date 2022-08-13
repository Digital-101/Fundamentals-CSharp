using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._18_Dict_Hash_Sets
{
    class StudentListSetsExample
    {
        static void SetEG()
        {
            HashSet<string> aspNetStudents = new HashSet<string>();
            aspNetStudents.Add("S. Jobs");
            aspNetStudents.Add("B. Gates");
            aspNetStudents.Add("M. Dell");

            HashSet<string> silverlightStudents = new HashSet<string>();
            silverlightStudents.Add("M. Zuckerberg");
            silverlightStudents.Add("M. Dell");

            HashSet<string> allStudents = new HashSet<string>();
            allStudents.UnionWith(aspNetStudents);
            allStudents.UnionWith(silverlightStudents);

            HashSet<string> intersectStudents = new HashSet<string>(aspNetStudents);
            intersectStudents.IntersectWith(silverlightStudents);

            Console.WriteLine("ASP.NET Students: "+String.Join(", ", aspNetStudents));
            Console.WriteLine("Silverlight Students: " + String.Join(", ", silverlightStudents));
            Console.WriteLine("All Students: " + String.Join(", ", allStudents));
            Console.WriteLine("Students in both ASP.NET and Silverlight: " + String.Join(", ", intersectStudents));

            //Output:
            //ASP.NET students: S.Jobs, B.Gates, M.Dell
            //Silverlight students: M.Zuckerberg, M.Dell
            //All students: S.Jobs, B.Gates, M.Dell, M.Zuckerberg
            //Students in both ASP.NET and Silverlight: M.Dell

        }
    }
}
