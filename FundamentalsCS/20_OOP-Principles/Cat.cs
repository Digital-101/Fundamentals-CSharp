using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class Cat : Animal
    {
        protected override string GetTypicalSound()
        {
            return "Meoooow!";
        }
    }
}
