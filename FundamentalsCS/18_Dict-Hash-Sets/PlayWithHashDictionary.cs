using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._18_Dict_Hash_Sets
{
    class PlayWithHashDictionary
    {
        static void Play()
        {
            HashDictionary<Point3D, int> dict = new HashDictionary<Point3D, int>(3, 0.9f);

            dict[new Point3D(1, 2, 3)] = 1; //Put a key-value pair
            Console.WriteLine(dict[new Point3D(1, 2, 3)]);// Get value

            //Overwrite the previous value for the same key
            dict[new Point3D(1, 2, 3)] += 1;

            //Now this point will cause a collision with the previous one n the elements will be chained
            dict[new Point3D(3, 2, 3)] = 42;

            Console.WriteLine(dict[new Point3D(3, 2, 3)]);

            // Test if the chaining works as expected, i.e.
            // elements with equal hash-codes are not overwritten
            Console.WriteLine(dict[new Point3D(1, 2, 3)]);
           
            // Creation of another entry in the internal table
            // This will cause the internal table to expand
            dict[new Point3D(4, 5, 6)] = 1111;
            Console.WriteLine(dict[new Point3D(4, 5, 6)]);
           
            // Delete an existing by its key
            dict.Remove(new Point3D(3, 2, 2));
            //Iterate via the dictionary entries and print them
            foreach (KeyValuePair<Point3D, int> entry in dict)
            {
                Console.WriteLine("Key: "+entry.Key +"; Value: "+entry.Value);
            }

            //Output:
            //1
            //2
            //42
            //2
            //1111
            //Key: (1, 2, 3); Value: 2
            //Key: (4, 5, 6); Value: 1111        }
    }
}
