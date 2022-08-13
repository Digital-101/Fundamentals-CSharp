using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._18_Dict_Hash_Sets
{
    class SortedSetsExample
    {
        static void SortedSets()
        {
            SortedSet<string> bandsBradLikes = new SortedSet<string>(new[]
            {
                "Manowar", "Blind Guardian", "Dio", "Kiss",
                "Dream Theater", "Megadeth", "Judas Priest",
                "Kreator", "Iron Maiden", "Accept"           });

            SortedSet<string> bandsAngelinaLikes = new SortedSet<string>(new[]
            {
                "Iron Maiden", "Dio", "Accept", "Manowar", "Slayer",
                "Megadeth", "Running Wild", "Grave Gigger", "Metallica"
            });

            Console.WriteLine("Brad Pitt likes these bands: ");
            Console.WriteLine(String.Join(", ", bandsBradLikes));

            Console.WriteLine("Angelina Jolie likes these bands: ");
            Console.WriteLine(String.Join(", ", bandsAngelinaLikes));

            SortedSet<string> intersectBands = new SortedSet<string>(bandsBradLikes);
            intersectBands.IntersectWith(bandsAngelinaLikes);

            Console.WriteLine(String.Format("Does Brad Pitt like Angelina Jolie? {0}", intersectBands.Count >= 5 ? "Yes!" : "No!"));

            Console.WriteLine("Because Brad Pitt and Angelina Jolie both like: ");
            Console.WriteLine(String.Join(", ", intersectBands));

            SortedSet<string> unionBands = new SortedSet<string>(bandsBradLikes);
            unionBands.UnionWith(bandsAngelinaLikes);

            Console.Write("All bands that Brad Pitt or Angelina Jolie like: ");
            Console.WriteLine(string.Join(", ", unionBands));

            //Output:
            //Brad Pitt likes these bands: Accept, Blind Guardian, Dio, Dream
            //Theater, Iron Maiden, Judas Priest, Kiss, Kreator, Manowar, 
            //Megadeth
            //Angelina Jolie likes these bands: Accept, Dio, Grave Gigger,
            //Iron Maiden, Manowar, Megadeth, Metallica, Running Wild, Slayer
            //Does Brad Pitt like Angelina Jolie? Yes!
            //Because Brad Pitt and Angelina Jolie both like: Accept, Dio, 
            //Iron Maiden, Manowar, Megadeth
            //All bands that Brad Pitt or Angelina Jolie like: Accept, Blind
            //Guardian, Dio, Dream Theater, Grave Gigger, Iron Maiden, Judas
            //Priest, Kiss, Kreator, Manowar, Megadeth, Metallica, Running
            //Wild, Slayer
        }
    }
}
