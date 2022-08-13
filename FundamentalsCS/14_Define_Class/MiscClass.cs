using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._14_Define_Class
{
    class MiscClass<K>
    {
        void MscDef()
        {
            Console.WriteLine(SqrtPrecalculated.GetSqrt(254));
            //Result: 15

            //Normal Swap
            int num1 = 3;
            int num2 = 5;

            //Generic Swap2
            Console.WriteLine("Before swap: {0} {1}", num1, num2);
            // Invoking the method with concrete type (int)
            Swap<int>(ref num1, ref num2);
            Console.WriteLine("After swap: {0} {1}\n", num1, num2);
            string str1 = "Hello";
            string str2 = "There";
            Console.WriteLine("Before swap: {0} {1}!", str1, str2);
            // Invoking the method with concrete type (string)
            Swap<string>(ref str1, ref str2);
            Console.WriteLine("After swap: {0} {1}!", str1, str2);
        }

        static void EnmCoff()
        {
            Coffee normalCoffee = new Coffee(CoffeeSize.Normal);
            Coffee doubleCoffee = new Coffee(CoffeeSize.Double);
            Console.WriteLine("The {0} coffee is {1} ml.",
            normalCoffee.Size, (int)normalCoffee.Size);
            Console.WriteLine("The {0} coffee is {1} ml.",
            doubleCoffee.Size, (int)doubleCoffee.Size);

            //The Normal coffee is 150 ml.
            //The Double coffee is 300 ml.        }

        //GENERICS
        //It allows us to declare parameters of this class, by indicating an unknown type that the class will work eventually with.
        
        //Generic Swap
        public void Swap<K>(ref K a, ref K b)
        {
            K oldA = a;
            a = b;
            b = oldA;
        }

        static void TestAnimal()
        {
            AnimalShelter22<Dog> shelter = new AnimalShelter22<Dog>();
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            Dog d = shelter.Release(1); // Release the second dog
            Console.WriteLine(d);
            d = shelter.Release(0);//Release the first dog
            Console.WriteLine(d);
            d = shelter.Release(0);//Release the third dog
            Console.WriteLine(d);
            d = shelter.Release(0);//Exception: invalid cell index
        }

    }
}
