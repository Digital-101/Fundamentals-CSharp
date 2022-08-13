using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._11_Create_Obj
{
    class MiscObj
    {
        static void ObjMisc()
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tony";
            firstCat.SayMiau();

            Cat secondCat = new Cat("Pepy", "red");
            secondCat.SayMiau();
            Console.WriteLine("Cat {0} is {1}.", secondCat.Name, secondCat.Color);

            //Output:
            //Cat Tony said: Miauuuuuu!
            //Cat Pepy said: Miauuuuuu!
            //Cat Pepy is Red.
        }

        static void Sequencial()
        {
            Console.WriteLine("Sequence[1...3]: {0}, {1}, {2}", Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());

            //Results:
            //Sequence[1...3]: 1, 2, 3
        }

        static void MathOO()
        {
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E); // Eulers number
            //Output:
            //3.141592653589793
            //2.718281828459045
        }

        static void randomNum()
        {
            Random random = new Random();
            for (int number = 1; number <=6; number++)
            {
                int rands = random.Next(49) + 1;
                Console.Write("{0} ", rands);
            }

            //Output:
            //12 27 39 18 35 37
        }
    }
}
