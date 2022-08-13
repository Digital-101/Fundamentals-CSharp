using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._19_Data_Structures_Algor
{
    public class PhoneSort
    {
        static void PhoneBook()
        {
            // Read the file and build the phone book
            SortedDictionary<string, SortedDictionary<string, string>> phonesByTown = new SortedDictionary<string, SortedDictionary<string, string>>();
            StreamReader reader = new StreamReader("PhoneBook.txt");
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] entry = line.Split(new char[] { '|' });
                    string name = entry[0].Trim();
                    string town = entry[1].Trim();
                    string phone = entry[2].Trim();

                    SortedDictionary<string, string> phoneBook;
                    if (!phonesByTown.TryGetValue(town, out phoneBook))
                    {
                        //This town is new. Create a phone book for it
                        phoneBook = new SortedDictionary<string, string>();
                        phonesByTown.Add(town, phoneBook);
                    }
                    phoneBook.Add(name, phone);
                }
            }

            //Print the phone book by towns
            foreach (string town in phonesByTown.Keys)
            {
                Console.WriteLine("Town "+town+":");
                SortedDictionary<string, string> phoneBook = phonesByTown[town];
                foreach (var entry in phoneBook)
                {
                    string name = entry.Key;
                    string phone = entry.Value;
                    Console.WriteLine("\t{0} - {1}", name, phone);
                }
            }

            //Expected Result:
            //Town Portland:
            //              Mary - 1 - 234 - 765 - 1983
            //Town San Antonio:
            //              Laura - 1 - 454 - 345 - 2345
            //              Paul - 1 - 535 - 675 - 6745
            //Town Virginia Beach:
            //              Donna - 1 - 387 - 387 - 2389
            //              Kenneth - 1 - 541 - 754 - 3010

        }
    }
}
