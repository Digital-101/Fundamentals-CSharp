using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._21_High_Quality_Code
{
    public class Assertion
    {
        void LoadTemplates(string fileName)
        {
            bool templateFileExist = File.Exists(fileName);
            Debug.Assert(templateFileExist, "Can't load templates file: " + fileName);
        }
    }
}
