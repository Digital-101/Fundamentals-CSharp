using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FundamentalsCS._18_Dict_Hash_Sets
{
    public class MiscDSA
    {
        static void Leap()
        {
            IDictionary<string, double> studentMarks = new Dictionary<string, double>();

            studentMarks["Paul"] = 3.00;
            Console.WriteLine("Paul's mark: {0:0.00}", studentMarks["Paul"]);

        }

        //
        static void IEqulaCompr()
        {
            IEqualityComparer<Point3D> comparer = new Point3DEqualityComparer();
            Dictionary<Point3D, int> dict = new Dictionary<Point3D, int>(comparer);

            dict[new Point3D(4, 2, 5)] = 5;
            dict[new Point3D(1, 2, 3)] = 1;
            dict[new Point3D(3, 1, -1)] = 3;
            dict[new Point3D(1, 2, 3)] = 10;
            foreach (var entry in dict)
            {
                Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
            }
        }
            //

            //public override unsafe int GetHashCode()
            //{
            //    fixed (char* str = ((char*)this))
            //    {
            //        char* chPtr = str;
            //        int num = 352654597;
            //        int num2 = num;
            //        int* numPtr = (int*)chPtr;
            //        for (int i = this.Length; i > 0; i-=4)
            //        {
            //            num = (((num << 5) + num) + (num >> 27)) ^ numPtr[0];
            //            if (i <= 2)
            //            {
            //                break;
            //            }
            //            num2 = (((num2 << 5) + num2) + (num2 >> 27)) ^ numPtr[1];
            //            numPtr += 2;
            //        }
            //        return (num + (num2 * 1566083941));
            //    }
            //}

            //public override int GetHashCode()
            //{
            //    return 42;
            //}
        }

        class CaseInsensitiveComparer : IComparer<string>
        {
            public int Compare(string s1, string s2)
            {
                return string.Compare(s1, s2, true);
            }
        }
}

