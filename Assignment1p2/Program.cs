using System;
using System.Collections.Generic;

namespace Assignment1p2
{/*
  * Full Name : Harpreet Singh
Student # 8715459
Section :Section 3
Date :june 4 3:04 Am
Description simple purchasing system in my case its simple shoe shop system
 
  */
    class Program
    {
        static void Main(string[] args)
        {  // created a List of type kart (kart is a class)
            List<Kart> usritems = new List<Kart>();
            //called crateItems method
            var ItemList=createItems();
            Console.WriteLine("--------List of shoes/sneakers/sportShoes available at our shop--------");
            Console.WriteLine("ItemName           Price");
            //iterating through each item in itemlist and printing out
            foreach (Item item in ItemList){
                
                Console.WriteLine("{0}            ${1}", item.Name,item.Price);
            }
            Console.WriteLine("type e to exit the program");
            //here called another method named as ask to enter
            AskToEnter(ItemList,usritems);
            
        }
        //creating shop items
        static List<Item> createItems()
        {
            List<Item> Itemlist = new List<Item>();
            String[] NameArray = { "Nike", "Adidas", "Puma", "NewBalance", "Converse", "Jordans" };
            double[] price = { 500.49, 1200.80, 700.9, 800.90, 60.5, 2000.56 };

            for (int i = 0; i < NameArray.Length; i++)
            {   //created the onject of item class for each item
                Item item = new Item()
                {
                    Name = NameArray[i],
                    Price = price[i]
                    //item.Name = NameArray[i];
                    //item.Price = price[i];
                };
                //adding items in itemlist that was created in main method
                Itemlist.Add(item);

            }
            //this method is of type List of Item so it returns the Itemlist;
            return Itemlist;

        }

        //The main logic of program
        static void AskToEnter(List<Item> Li, List<Kart> usrkart)
        { bool run = true;
            String name;
            while (run)
            {
                //NaMe  naME NAME name name 
                Console.WriteLine("Please enter the name of sneakers you would like to buy");
                name = Console.ReadLine().ToLower().Trim();
                if (name.Equals("e"))
                {
                    Console.WriteLine("Exiting");
                    printall(usrkart);
                    return;
                }
                else
                {
                    while (String.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("please enter a valid name");
                        name = Console.ReadLine().ToLower().Trim();
                        if (name.Equals("e")) { Console.WriteLine("Exit the program");printall(usrkart); return; }
                    }
                    if (CheckString(name) && CheckStringInList(name, Li))
                    {
                        //how many pair user would like to buy
                        Console.WriteLine("Enter number of pairs you would like to buy");
                        String howmany = Console.ReadLine();

                        if (int.TryParse(howmany, out int pair))
                        {
                            foreach (Item item in Li)
                            {
                                if (item.Name.ToLower() == name)
                                {
                                    Kart item1 = new Kart()
                                    {
                                        ItemName = name,
                                        Price = item.Price,
                                        TotalPair = pair,
                                        Total = item.Price * pair
                                    };
                                    usrkart.Add(item1);
                                    break;

                                }

                            }
                        }
                        else { Console.WriteLine("Wrong input Try adding Int only"); }
                        //else { Console.WriteLine("wrong input Try adding Int only");printall(usrkart); return; }
                    }
                    //else { Console.WriteLine("Wrong Name you have entered"); printall(usrkart); return; }
                    else { Console.WriteLine("Wrong Name you have entered");  }
                }
           }
                
        }   //i have a question here but will ask later on
        //nike12112
        static bool CheckString(String name) {
            bool success = false;
            for(int i = 0; i < name.Length; i++) {
                if (Char.IsLetter(name, i))
                {
                    success = true;
                }
                else { return false; }
            }
            

            return success;
        }
        static bool CheckStringInList(String name,List<Item> ilist)
        {
            bool Success=false;

            foreach(Item item in ilist)
            {
               
                if (String.Equals(item.Name.ToLower(),name) )
                {
                    Success = true;
                    return Success;// Had to return it because otherwise the program keeps on running and return success false
                }
                else { Success = false; }

            }

            return Success;
        }
        //printing logic
        static void printall(List<Kart> usrkart)
        {
            int itemCount = 0;
            double totalCostOfItems = 0;
            double tax = 0;
            foreach (Kart usritem in usrkart)
            {
                //itemCount=itemCount+usritem.Totoalpair;
                itemCount+= usritem.TotalPair;
                totalCostOfItems += usritem.Total;
            
                //Console.WriteLine("here is item name={0},item price {1},totalpair={2},Total price{3}",
                  //  usritem.ItemName, usritem.Price, usritem.TotalPair, usritem.Total);
            }
            tax = totalCostOfItems + (totalCostOfItems * 0.13);
            Console.WriteLine("-------------------Bill--------------------");
            Console.WriteLine("Total Items Purchased ------  {0}", itemCount);
            Console.WriteLine("SubTotal Cost----  ${0}", totalCostOfItems);
            Console.WriteLine("a 13% tax is applicable");
            Console.WriteLine("grandTotal:-------  ${0}", Math.Round(tax,2));
            //333.45

        }



    }
}
