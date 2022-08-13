using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._11_Create_Obj
{
    class RandomPassword
    {
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTWXYZ";
        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars = "~!@#$%^&*()_+=`{}\\|':;.,/?<>";
        private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;

        private static Random rnd = new Random();

        static void MainMM()
        {
            StringBuilder password = new StringBuilder();

            //Generate 2 random capitalLetters
            for (int i = 1; i <=2; i++)
            {
                char capitalLetter = GenerateChar(CapitalLetters);
                InsertAtRandomPosition(password, capitalLetter);
            }

            //Generate 2 random small Letters
            for (int i = 1; i <= 2; i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                InsertAtRandomPosition(password, smallLetter);
            }

            //Generate one random digit
            char digit = GenerateChar(Digits);
            InsertAtRandomPosition(password, digit);

            //Generate 3 random special characters
            for (int i = 1; i <= 3; i++)
            {
                char specialChar = GenerateChar(SpecialChars);
                InsertAtRandomPosition(password, specialChar);
            }

            //Generate few random characters (between 0 and 7)
            int count = rnd.Next(8);
            for (int i = 1; i <=count; i++)
            {
                char specialChar = GenerateChar(AllChars);
                InsertAtRandomPosition(password, specialChar);
            }
            Console.WriteLine(password);
            //Output:
            //6vvYc@u=FBF%
        }

        private static void InsertAtRandomPosition(StringBuilder password, char character)
        {
            int randomPosition = rnd.Next(password.Length + 1);
            password.Insert(randomPosition, character);
        }

        private static char GenerateChar(string availableChars)
        {
            int randomIndex = rnd.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }
    }
}
