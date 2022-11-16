using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{ 
    class Program
    {   
        enum Luggage { Bag1, Bag2, ComputerBag, HandBag }
        static void Main(string[] args)
        {
            String countryName, answer;
            int total = 0; 
            int weight; 
            Console.WriteLine("Welcome");
            Console.WriteLine("Which country you arrived from?");
            countryName = Console.ReadLine();
            
            foreach (String lug in Enum.GetNames(typeof(Luggage)))
            {
                Console.WriteLine("Did you bring {0}?", lug);
                answer = Console.ReadLine().ToLower();
                if (answer == "yes")    
                {
                    Console.WriteLine("Please enter the weight of {0} in kg", lug);
                    weight = Int32.Parse(Console.ReadLine());
                    total = total + weight;
                }

            }
            Console.WriteLine("I flew from {0} with {1} kg of luggage", countryName, total);


            Console.ReadLine();


        }


        // Here i tried making this program using While loop
        /*
        int i = 0;
        while (i <Enum.GetValues(typeof(Luggage)).Length)
        {
            Console.WriteLine("Did you bring {0} ????",(Luggage)i);
            answer=Console.ReadLine().ToLower();
            if (answer == "yes") 
            {
                Console.WriteLine("Please enter the weight(Kg)");
                weight=int.Parse(Console.ReadLine());
                total = total + weight;
            }
            i++;
        }
        Console.WriteLine("I flew from {0} with {1} kg of luggage", countryName, total);
        Console.ReadLine();
        */

        
        //Here i made code using For loop

        /*var names = Enum.GetNames(typeof(Luggage));
        Console.WriteLine(names);
        for (int i=0; i<names.Length; i++)
        {
            var a = (Luggage)i;
            Console.WriteLine("Did you bring {0}", a);
             answer=Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("please enter the weight of {0}", a);
                weight = Int32.Parse(Console.ReadLine());
                total = total + weight;
            }
        }
        Console.WriteLine("I flew from {0} with {1} kg of luggage", countryName, total);
        Console.ReadLine();

         */


        //Here i made this using Foreach Loop







    }
}
