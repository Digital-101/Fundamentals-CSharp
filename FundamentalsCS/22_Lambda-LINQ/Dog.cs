using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._22_Lambda_LINQ
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }

        static void Mainly()
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog{Name = "Rex", Age = 4},
                new Dog{Name = "Sean", Age = 0},
                new Dog{Name = "Stacy", Age = 3}
            };
            var names = dogs.Select(x => x.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Result:
            //Rex
            //Sean
            //Stacy

            //Lambda AnonTypes
            var newDogsList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
            foreach (var item in newDogsList)
            {
                Console.WriteLine(item);
            }

            //Result: 
            //{ Age = 4, FirstLetter = R }
            //{ Age = 0, FirstLetter = S }
            //{ Age = 3, FirstLetter = S }

            //Sorting with Lambda
            var sortedDogs = dogs.OrderByDescending(x=>x.Age);
            foreach (var dog in sortedDogs)
            {
                Console.WriteLine(string.Format("Dog {0} is {1} years old.", dog.Name, dog.Age));
            }

            //Result:
            //Dog Rex is 4 years old.
            //Dog Stacy is 3 years old.
            //Dog Sean is 0 years old.
            
        }
    }
}
