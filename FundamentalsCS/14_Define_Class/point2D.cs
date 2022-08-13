using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._14_Define_Class
{
    //- Classes are reference types (references to some address in the heap 
    //which holds their members).
    
    //- Structures(structs) are value types(they directly hold their
    //members in the program execution stack).
    struct point2D
    {
        private double x;
        private double y;

        public point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}
