using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._16_Linear_DataStruct
{
    class ProgrArrayListEG
    {
        static void ARLS()
        {
            ArrayList list = new ArrayList();
            list.Add("Hello");
            list.Add(5);
            list.Add(3.14159);
            list.Add(DateTime.Now);

            for (int i = 0; i < list.Count; i++)
            {
                object value = list[i];
                Console.WriteLine("Index={0}; value={1} ", i, value);
            }

            //ArrayList of Numbers – Example
            ArrayList list1 = new ArrayList();
            list1.Add(2);
            list1.Add(3.5f);
            list1.Add(25u);//uint
            list1.Add(" EUR");
            dynamic sum = 0; //special type variable

            for (int i = 0; i < list1.Count; i++)
            {
                dynamic value = list1[i];
                sum = sum + value;
            }
            Console.WriteLine("Sum = "+sum);
            //Output: Sum = 30.5 EUR
        }
    }
}
