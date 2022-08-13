using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._12_Except_Handle
{
    class MiscExept
    {
        static void ExpHand()
        {
            try
            {
                string fileName = "WrongFileName.txt";
                ReadFile(fileName);
            }
            catch (Exception e)
            {

                throw new ApplicationException("Bad thing happened", e);
            }
        }

        private static void ReadFile(string fileName)
        {
            try
            {
                TextReader reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("The file {0} does not exist!", fileName); 
            }
        }

        //Dont catch all exceptions
        static void DCEH()
        {
            try
            {
                ReadFile("CorrectTextFile.txtx");
            }
            catch (Exception)
            {

                Console.WriteLine("File Not found."); 
            }
        }

        //
    }
}
