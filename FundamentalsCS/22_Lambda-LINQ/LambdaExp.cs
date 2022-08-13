using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._22_Lambda_LINQ
{
    class LambdaExp
    {
        static void Lambda1()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            foreach (var num in evenNumbers)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            //Result:
            //2 4 6

            //Statements in Lambda
            List<int> list2 = new List<int>() { 20, 1, 4, 8, 9, 44};
            //Process each arg with code statements
            var evenNumbers2 = list2.FindAll((i) => 
            {
                Console.WriteLine("Value of i is: {0}",i);
                return (i % 2) == 0;
            });

            //Lambda as Delegates
            //A delegate is a data type which holds a reference to method with compatible signature. 
            Func<bool> boolFunc = () => true;
            Func<int, bool> intFunc = (x) => x < 10;
            if (boolFunc() && intFunc(5))
            {
                Console.WriteLine("5 < 10");
            }

            //Result:
            //5 < 10
        }

    }
}
