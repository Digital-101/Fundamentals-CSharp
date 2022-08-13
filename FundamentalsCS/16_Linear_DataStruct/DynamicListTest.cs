using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._16_Linear_DataStruct
{
    class DynamicListTest
    {
        //Shopping List E.g -> using Linked List
        static void Main334()
        {
            DynamicList<string> shoppingList = new DynamicList<string>();

            shoppingList.Add("Milk");
            shoppingList.Remove("Milk"); //Empty list
            shoppingList.Add("Honey");
            shoppingList.Add("Olives");
            shoppingList.Add("Water");
            shoppingList[2] = "A lot of " + shoppingList[2]; //Water
            shoppingList.Add("Fruits");
            shoppingList.RemoveAt(0); // Removes "Honey" (first)
            shoppingList.RemoveAt(2); // Removes "Fruits" (last)
            shoppingList.Add(null);
            shoppingList.Add("Beer");
            shoppingList.Remove(null);
            Console.WriteLine("We need to buy:");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(" - "+shoppingList[i]);
            }
            Console.WriteLine("Position of 'Beer' = {0}", shoppingList.IndexOf("Beer"));
            Console.WriteLine("Position of 'Water' = {0}", shoppingList.IndexOf("Water"));
            Console.WriteLine("Do we have to buy Bread? "+ shoppingList.Contains("Bread"));


        }
    }
}
