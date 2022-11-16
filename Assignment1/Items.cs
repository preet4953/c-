using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Items
    {
        // private String name;
        // private float Baseprice, Weight;
        public float Baseprice{get;set;}
        public String Name{get;set;}
        public float Weight{get;set;}
        
        public Items(String iname, float iWeight)
        { 
            Name = iname;
            Weight = iWeight;
            switch (Name.ToLower())
            {
                case "apples":
                    if (Weight > 20)
                    {
                        Console.WriteLine("Since you have bought more than 20kg we gave you 10% discount \n");
                        Baseprice = 0.79f - (0.1f * 0.79f);
                        Console.WriteLine("your Baseprice effectevly ${0} \n", Baseprice);
                    }
                    else {
                        Baseprice = 0.79f;
                        Console.WriteLine("Baseprice is ${0}",Baseprice);
                    }

                    break;

                case "oranges":
                    if (Weight > 20)
                    {
                        Console.WriteLine("Since you have bought more than 20kg we gave you 10% discount \n");
                        Baseprice = 1.19f - (0.1f * 1.19f);
                        Console.WriteLine("your Baseprice effectevly ${0} \n", Baseprice);

                    }
                    else {
                        Baseprice = 1.19f;
                        Console.WriteLine("Baseprice is ${0}", Baseprice);
                    }
                    
                    break;

                case "lemons":
                    if (Weight > 20)
                    {
                        Console.WriteLine("Since you have bought more than 20kg we gave you 10% discount \n");
                        Baseprice = 0.39f - (0.1f * 0.39f);
                        Console.WriteLine("your Baseprice effectevly ${0} \n", Baseprice);

                    }
                    else {
                        Baseprice = 0.39f;
                        Console.WriteLine("Baseprice is ${0} \n", Baseprice);
                    }
                    
                    break;

                case "limes":
                    if (Weight > 20)
                    {
                        Console.WriteLine("Since you have bought more than 20kg we gave you 10% discount \n");
                        Baseprice = 0.99f - (0.1f * 0.99f);
                        Console.WriteLine("your Baseprice effectevly ${0} \n", Baseprice);

                    }
                    else {
                        Baseprice = 0.99f;
                        Console.WriteLine("Baseprice is ${0} \n", Baseprice);
                    }
                    
                    break;
            }

        }

        

    }


}
