using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._15_Text_Files
{
    class Write
    {
        static void Writer()
        {
            //Create StreamWriter instance
            StreamWriter writer = new StreamWriter("Numbers.txt");

            //Ensure the writer  will be closed when no longer used
            using (writer)
            {
                //Loop through the numbers form 1 to 20 and Write them
                for (int i = 1; i <= 20; i++)
                {
                    writer.WriteLine(i);
                }
            }
        }
    }
}
