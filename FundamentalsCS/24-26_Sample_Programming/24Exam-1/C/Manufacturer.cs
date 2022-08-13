using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._24Exam_1.C
{
    //Immutable Class
    public class Manufacturer
    {
        private string name;
        private string country;
        private string address;
        private string phoneNumber;
        private string fax;

        public Manufacturer(string name, string country, string address, string phoneNumber, string fax)
        {
            this.name = name;
            this.country = country;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.fax = fax;
        }

        //Human-Readable string
        public override string ToString()
        {
            return this.name + " <" + this.country + "," + this.address + "," + this.phoneNumber + "," + this.fax + ">";
        }
    }
}
