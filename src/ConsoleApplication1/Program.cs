using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static String Name;
        public static String LastName;
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta palun oma eesnimi");
            Name = Console.ReadLine();
            Console.WriteLine("Sisesta palun oma perekonnanimi");
            LastName = Console.ReadLine();
            Console.WriteLine("Hello" + " " + Name +" "+LastName+" and welcome to room 503!");
        }
    }
}
