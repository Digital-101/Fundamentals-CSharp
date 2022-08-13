using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._13_String_n_Text
{
    class StringFormatting
    {
        static void STFM()
        {
            //String Format
            DateTime date = DateTime.Now;
            string name = "David Scott";
            string task = "Introduction to C# book";
            string location = "his office";
            string formattedText = String.Format("Today is {0:MM/dd/yyyy} and {1} is working on {2} in {3}.", date, name, task, location);
            Console.WriteLine(formattedText);
            // Output: Today is 01.02.2012 and David Scott is working on
            // Introduction to C# book in his office.

            //Passing Numeric Types
            string textPT = "53";
            int intValue = int.Parse(textPT);
            // intValue = 53

            string textPN = "True";
            bool boolValue = bool.Parse(textPN);
            // boolValue = true

            //Parsing Dates
            string textDT = "11/11/2001";
            DateTime parsedDate = DateTime.Parse(textDT);
            Console.WriteLine(parsedDate);
            // 11-Nov-01 0:00:00 AM

            string textDT2 = "11/12/2001";
            string format = "MM/dd/yyyy";
            DateTime parsedDate2 = DateTime.ParseExact(textDT2, format, CultureInfo.InvariantCulture);
            Console.WriteLine("Day: {0}\nMonth: {1}\nYear: {2}",
            parsedDate.Day, parsedDate.Month, parsedDate.Year);
            // Day: 12
            // Month: 11
            // Year: 2001

        }
    }
}
