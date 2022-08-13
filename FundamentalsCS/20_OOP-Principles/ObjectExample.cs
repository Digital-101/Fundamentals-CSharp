using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class ObjectExample
    {
        static void OEG()
        {
            AfricanLion africanLion = new AfricanLion(true, 80);
            // Up/Implicit casting
            object obj = africanLion;

            try
            {
                // Down/Explicit casting
                AfricanLion castedLion = (AfricanLion)obj;
            }
            catch (InvalidCastException ice)
            {

                Console.WriteLine("Obj cannot be downcasted to AfricanLion");
            }
        }
    }
}
