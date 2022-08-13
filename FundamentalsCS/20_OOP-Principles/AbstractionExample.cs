using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class AbstractionExample
    {
        static void ABEG()
        {
            Lion lion = new Lion(true, 150);
            Felidae bigCat1 = lion;

            AfricanLion africanLion = new AfricanLion(true, 80);
            Felidae bigCat2 = africanLion;

            ///
            Animal cat = new Cat();
            cat.PrintInformation();

            //Result
            //I am a Cat.
            //Meoooow!
        }
    }
}
