using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._17_Trees_n_Graphs
{
    /// <summary>
    /// Sample class, which traverses given directory
    /// based on the Breadth-First Search (BFS) algorithm
    /// </summary>
    public static class DirectoryTraverserBFS
    {

        /// <summary>
        /// Traverses and prints given directory with BFS
        /// </summary>
        /// <param name="directoryPath">the path to the directory 
        /// which should be traversed</param>
        static void TraverseDir(string directoryPath)
        {
            Queue<DirectoryInfo> visitedDirsQueue = new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));
            while (visitedDirsQueue.Count > 0)
            {
                DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
                Console.WriteLine(currentDir.FullName);

                DirectoryInfo[] children = currentDir.GetDirectories();
                foreach (DirectoryInfo child in children)
                {
                    visitedDirsQueue.Enqueue(child);
                }
            }
        }

        static void MainTB()
        {
            TraverseDir("C:\\");
        }

        //Output:
        //*******************************
        //C:\
        //C:\Config.Msi
        //C:\Documents and Settings
        //C:\Inetpub
        //C:\Program Files
        //C:\RECYCLER
        //C:\System Volume Information
        //C:\WINDOWS
        //C:\wmpub
        //C:\Documents and Settings\Administrator
        //C:\Documents and Settings\All Users
        //C:\Documents and Settings\Default User
        //...
    }
}
