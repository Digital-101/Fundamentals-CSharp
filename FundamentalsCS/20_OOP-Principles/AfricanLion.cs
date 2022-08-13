using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class AfricanLion : Lion
    {
        // If we comment out the ": base(male, weight)" line
        // the class will not compile. Try it.
        public AfricanLion(bool male, int weight) : base(male, weight)
        {
        }

        //Overriding ToString()
        public new string ToString()
        {
            return string.Format("AfricanLion, male: {0}, weight: {1}", this.Male, this.Weight);
        }

        //Virtual Method
        //public override void CatchPreyA(object prey)
        //{
        //    Console.WriteLine("AfricanLion.CatchPrey");
        //    Console.WriteLine("calling base.CatchPrey");
        //    Console.Write("\t");
        //    base.CatchPreyA(prey);
        //    Console.WriteLine("...end of call.");

        //    //AfricanLion.CatchPrey
        //    //calling base.CatchPrey
        //    //Lion.CatchPrey...end of call.
        //}


    }
}
