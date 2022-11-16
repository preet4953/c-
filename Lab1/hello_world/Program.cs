using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the airport");
            Console.WriteLine("Which country you arrived from? Enter");
            String CountryName = Console.ReadLine();
            Console.WriteLine("how many bag you have?");
            int Bags = Int32.Parse(Console.ReadLine());
            Console.WriteLine("total weight of luggage");
            int totalWeight = Int32.Parse(Console.ReadLine());
            float average = (Bags + totalWeight) / Bags;
            Console.WriteLine("hello");
            Console.WriteLine("I flew from {0} having {1} bags with average weight of {2}", CountryName, Bags, average);
            Console.ReadLine();

        }
    }
}
