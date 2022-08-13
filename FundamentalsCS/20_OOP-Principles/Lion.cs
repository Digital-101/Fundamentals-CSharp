using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class Lion : Felidae, Reproducible<Lion>
    {
        private int weight;

        public Lion(bool male, int weight) : base(male)
        {
            this.weight = weight;
        }
        public int Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }

        Lion[] Reproducible<Lion>.Reproduce(Lion mate)
        {
            return new Lion[] { new Lion(true, 12), new Lion(false, 10)};
        }

        private Paw frontLeft;
        private Paw frontRight;
        private Paw bottomLeft;
        private Paw bottomRight;

        private void MovePaw(Paw paw)
        {

        }

        public override void Walk()
        {
            this.MovePaw(frontLeft);
            this.MovePaw(frontRight);
            this.MovePaw(bottomLeft);
            this.MovePaw(bottomRight);
        }

        protected void Ambush()
        {

        }
        public override bool CatchPrey(object prey)
        {
            base.Hide();
            this.Ambush();
            base.Run();

            return false;
        }

        //Virtual Method
        //public override void CatchPreyA(object prey)
        //{
        //    Console.WriteLine("Lion.CatchPrey");
        //}

        //Lion doesn’t publicly disclose information about its inner workings(it encapsulates certain behavior).
    }

    public class Paw { }
}
