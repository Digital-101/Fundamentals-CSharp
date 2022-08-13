using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._24Exam_1.B
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Distance { get; set; }

        //constructor simplify how class is used
        public Cell(int row, int column, int distance)
        {
            this.Row = row;
            this.Column = column;
            this.Distance = distance;
        }
    }
}
