using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class Country
    {
        ///<summary>Country's capital - association</summary>
        ///
        private Capital capital;

        public Capital Capital
        {
            get { return capital; }
            set { this.capital = value; }
        }
    }
}
