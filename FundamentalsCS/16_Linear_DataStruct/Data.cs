using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._16_Linear_DataStruct
{
    class Data
    {
        //data structures – a set of data organized on the basis of logical and mathematical laws.
        static void LinearDS()
        {
            //Converting a List to Array and Vice Versa
            int[] arr = new int[] { 1, 2, 3};
            List<int> list = new List<int>(arr);
            int[] convertedArray = list.ToArray();
        }
    }
}
