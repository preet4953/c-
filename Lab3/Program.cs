using System;
using System.Collections.Generic;
/*
Full Name :Harpreet Singh
Student # :
Section :3
Date : 3June 2021 time 6:12pm
Description : Trip program that asks for number of people for trip and save each person's details seperately in a list
*/
namespace Lab3
{
    class Program
    {       //Caution! This program is not 100% exception proof but is tried to make it safe using null checks and other tricks
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter the number of people are in group for trip");
            String userinput = Console.ReadLine();//Notice i saved Int value in String
            int numberOfPeople;
            //Int.parse takes our String (That contains digit) and try to parse it into Int value
            //if string contains the digit only then that digit will be store in numberOfPeople that is of type Int
            //else the program will say wrong input enter only digit and exit 
            if (int.TryParse(userinput, out numberOfPeople))
            {
                int i = 0;
                //Here i created the list of type person
                List<Person> personlist = new List<Person>();
                //while i is less than the number of people given as input
                //The program will create the person object for each person
                while (i < numberOfPeople) {
                    //here it creates person obj
                    Person person = CreatePersonObj();
                    //here we are checking null check in case any value in person is null
                    if (person != null)
                    {
                        personlist.Add(person);
                    }
                    else {
                        Console.WriteLine("The person Object was null");
                        break;
                    }
                    i++;

                }
                //here for each person program calls print every detail method
                foreach(Person p in personlist)
                {
                    printall(p);
                }
                



            }
            else { Console.WriteLine("you have entered wrong input.Please try again and add a number only"); }
        }

        static Person CreatePersonObj()
        {
            Console.WriteLine("please enter Person Name");
            String name = Console.ReadLine();
            Console.WriteLine("Please enter the City Name");
            String CityName = Console.ReadLine();
            Console.WriteLine("please enter the passport Number(it should be in format for eg:-(TT121234)");
            String PassportNumber = Console.ReadLine();
            //Checking if passport Number format is correct
            if (checkPassportLetter(PassportNumber) && checkPassportNumber(PassportNumber))
            {
                Console.WriteLine("Please eneter the number of bags Person has");
                String Bags = Console.ReadLine();
                int Countbags;
                //Here again trying to parse number of bags from string into the int
                //if it fails todo so it will return null and then we are checking null in main method
                //program will give an error and will return
                if (int.TryParse(Bags, out Countbags))
                {
                    Console.WriteLine("Enter the total luggage weight");
                    String lug = Console.ReadLine();
                    //since weight can be in decimal so here program tries to parse the double value if its in string
                    if (double.TryParse(lug, out double Luggage))
                    {
                        //creates the person object for specific person
                        //data thats a person has is written in the person class
                        Person person = new Person();
                        {   //all details of person entered into person object
                            person.Name = name;
                            person.CityName = CityName;
                            person.PassportNumber = PassportNumber;
                            person.NumberOfBags = Countbags;
                            person.TotalWeight = Luggage;

                        }//program returns a person object
                        return person;

                    }//if user entered wrong weight program will return this and exit
                    else { Console.WriteLine("Enter valid weight (digits only)"); return null; }
                }
                else
                {
                    Console.WriteLine("Please enter the valid count of bags "); return null;
                }


            }
            //if passport number is incorrect program will return null
            else { return null; }
            
        }
        //This method Checks if passport Number Starts with 2 letters
        //checks passportNum letters
        static bool checkPassportLetter(String passnumber)
        {
            bool success = false;
            for(int i=0; i < 2; i++)
            {
                if (Char.IsLetter(passnumber, i)) 
                { success = true; }
                else
                {
                     success=false;
                    return success;
                }
            }

            return success;
        }
        // For checking Passport Number Format
        //This Method checks if Passport Number has digits in it
        static bool checkPassportNumber(String passnumber)
        {
            bool success = false;
            for (int i = 2; i < passnumber.Length; i++)
            {
                if (Char.IsDigit(passnumber, i))
                { success = true; }
                else
                {
                    success = false;
                }
            }

            return success;
        }

        //This method prints all person info
        static void printall(Person person)
        {
            Console.WriteLine("-----------person data--------");
            Console.WriteLine("Name: {0}", person.Name);
            Console.WriteLine("City Name: {0}", person.CityName);
            //Console.WriteLine("PassportNumber:",);
            Console.WriteLine("Number of Bags: {0}",person.NumberOfBags);
            Console.WriteLine("Average weight Carrying :{0}", person.TotalWeight / person.NumberOfBags);
            Console.WriteLine("passport Number: {0}", printPassport(person));
        }

        //this method will replace first 3 Characters of passport Number so we can print Passport Number
        //Here we passed Person object in printpassort method So we can manipulate the passport Number
        static String printPassport(Person person)
        {   
            String originalpass = person.PassportNumber;
            //Here i removed the first 3 Characters or 2 letters and 1 digit
            //This method String.Remove(index ,length) takes index number and the length to which you want it to remove the characters
            //Here it removes from 0th index to length 3.Lets say passport number was TT114455
            String CharRemoved = originalpass.Remove(0, 3);
            //After String.Remove passport number will be 14455
            //This is the new string that will replace those First 3 digits
            String replace = "XXX";
            //Here i concatinated the Strings
            String newpass = replace + CharRemoved;
            return newpass;
           
            
         
        }



    }





            
            

        }




