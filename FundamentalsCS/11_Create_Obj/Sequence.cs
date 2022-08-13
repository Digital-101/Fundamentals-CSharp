using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._11_Create_Obj
{
    //Utility Class
    public class Sequence
    {
        //Static field, holding the current sequence value
        private static int currentValue = 0;

        //Intentionally deny instantiation of this class
        private Sequence()
        {

        }

        //static method for taking the next sequence value
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}
