using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class Singleton
    {
        //The single instance
        private static Singleton instance;

        //Initialize the single instance
        static Singleton()
        {
            instance = new Singleton();
        }

        //The property for retrieving the single instance
        public static Singleton Instance
        {
            get { return instance; }
        }

        //Private constructor: protects against direct instantiation
        private Singleton() { }
    }
}
