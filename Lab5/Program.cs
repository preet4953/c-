using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person()
            {
                Firstname = "John",
                Lastname = "conner",
                Age = DateTime.ParseExact("28/02/1985", "dd/MM/yyyy", null)
            };

            Person p2 = new Person()
            {
                Firstname = "Katherine",
                Lastname = "Bewster",
                Age = DateTime.ParseExact("21/05/1990", "dd/MM/yyyy", null)
            };

            Person p3 = new Person()
            {
                Firstname = "John",
                Lastname = "conner",
                Age = DateTime.ParseExact("28/02/1985", "dd/MM/yyyy", null)
            };

            Printdata(p1);
            Printdata(p2);
            Printdata(p3);

            if (p1.CompareTo(p2)==1)
            {
                Console.WriteLine("P1 and p2 are equal");
            }else { Console.WriteLine("p1 and p2 are not equal"); }

            if (p2.CompareTo(p3)==1)
            {
                Console.WriteLine("p2 and p3 are equal");
            }
            else { Console.WriteLine("p2 and p3 are not equal"); }
            
            if (p1.CompareTo(p3)==1)
            {
                Console.WriteLine("p1 and p3 are equal");
            }
            else { Console.WriteLine("p1 and p3 are not equal"); }






        }
        static void Printdata(Person p)
        {
            Console.WriteLine("person name {0} Age {1}",p.Firstname,p.CalculateAge());

        }

        





    }
}
