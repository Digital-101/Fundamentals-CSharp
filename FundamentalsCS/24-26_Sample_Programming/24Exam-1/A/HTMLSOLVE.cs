using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming.Exam_1
{
    class HTMLSOLVE
    {
        static void SLV11()
        {
            string line = string.Empty;
            StreamReader reader = new StreamReader("Problem1.html");
            while ((line = reader.ReadLine()) !=  null)
            {
                //Find what we need and save it in the result
            }
            reader.Close();
        }

    }
}
