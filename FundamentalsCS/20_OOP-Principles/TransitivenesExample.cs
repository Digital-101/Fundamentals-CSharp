using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class TransitivenesExample
    {
        static void TREG()
        {
            AfricanLion africanLion = new AfricanLion(true, 15);
            //Property defined in Felidae
            bool male = africanLion.Male;
            africanLion.Male = true;
        }
    }
}
