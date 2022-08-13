using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._14_Define_Class
{
    public class AnimalShelter22<T>
    {
        private const int DefaultPlacesCount = 20;
        private T[] animalList;
        private int usedPlaces;
        private int defaultPlacesCount;

        public AnimalShelter22() : this(DefaultPlacesCount)
        {

        }

        public AnimalShelter22(int placesCount)
        {
            this.animalList = new T[placesCount];
            this.usedPlaces = 0;
        }

        public void Shelter(T newAnimal)
        {
            if (this.usedPlaces >= this.animalList.Length)
            {
                throw new InvalidOperationException("Shelter is full.");
            }
            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;
        }

        public T Release(int index)
        {
            if (index < 0 || index >= this.usedPlaces)
            {
                throw new ArgumentOutOfRangeException("Invalid cell index: " + index);
            }
            T releasedAnimal = this.animalList[index];
            for (int i = index; i < this.usedPlaces -1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }
            // this.animalList[this.usedPlaces - 1] = null;            this.animalList[this.usedPlaces - 1] = default(T);
            this.usedPlaces--;

            return releasedAnimal;
        }
    }
}
