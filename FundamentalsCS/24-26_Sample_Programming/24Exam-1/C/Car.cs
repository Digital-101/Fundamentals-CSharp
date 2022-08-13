using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._24Exam_1.C
{
    public class Car
    {
        private string brand;
        private string model;
        private int productionYear;

        public Car(string brand, string model, int productionYear)
        {
            this.brand = brand;
            this.model = model;
            this.productionYear = productionYear;
        }

        public override string ToString()
        {
            return "<" + this.brand + "," + this.model + "," + this.productionYear + ">";
        }

        //Equals(...) and GetHashCode(..) methods for the class Car
        public override bool Equals(object obj)
        {
            Car otherCar = obj as Car;
            if (otherCar == null)
            {
                return false;
            }
            bool equals = object.Equals(this.brand, otherCar.brand) &&
                object.Equals(this.model, otherCar.model) &&
                object.Equals(this.productionYear, otherCar.productionYear);
            return equals;
        }

        public override int GetHashCode()
        {
            const int prime = 31;
            int result = 1;
            result = prime * result + ((this.brand == null) ? 0 : this.brand.GetHashCode());
            result = prime * result + ((this.model == null) ? 0 : this.model.GetHashCode());
            result = prime * result + this.productionYear;

            return result;
        }
    }
}
