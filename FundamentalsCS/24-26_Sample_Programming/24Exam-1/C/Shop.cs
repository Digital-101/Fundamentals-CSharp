using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._24Exam_1.C
{
    public class Shop
    {
        private string name;
        private List<Part> parts;

        public Shop(string name)
        {
            this.name = name;
            this.parts = new List<Part>();
        }

        public void AddPart(Part part)
        {
            this.parts.Add(part);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Shop: "+this.name+"\n\n");
            foreach (Part part in this.parts)
            {
                result.Append(part);
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}
