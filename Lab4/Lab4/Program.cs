using System;
using System.Collections.Generic;

namespace Lab4
{      /*
        Student Name:Harpreet Singh
        Student id:8715459    
        Section: 3
        Date:8 june 2021
        Description:-A simple program that shows how to use inheritance and display the output by overriding to string method
       
        */

    class Program
    {//Note:-Since program uses sample data ,data can be wrong eg:- birhdate,age etc;
        static void Main(string[] args)
        {
            sampleData();
        }
        static void sampleData()
        {   //created a list of sport class type
            List<Sport> playerList = new List<Sport>();
            //creating object and adding some dummy data and also adding the object to the list 
            playerList.Add(new Sport() {FirstName="John",LastName="conner",Age= 25,BirthDate= "23/04/1996",Country= "Canada",SportName ="Baseball", TeamName="westCoast",PlayerNumber=001 });
            playerList.Add(new Sport() { FirstName = "Dominic", LastName = "toretto", Age = 23, BirthDate = "23/04/1997", Country = "Canada", SportName = "cricket", TeamName = "Coast", PlayerNumber = 007 });
            playerList.Add(new Sport() { FirstName = "Vince", LastName = "garcia", Age = 28, BirthDate = "23/04/1994", Country = "US", SportName = "Formula1", TeamName = "Ferrari", PlayerNumber = 002 });
            playerList.Add(new Sport() { FirstName = "Chris", LastName = "nolan", Age = 27, BirthDate = "23/04/1993", Country = "England", SportName = "iceHockey", TeamName = "Theboys", PlayerNumber = 008 });
            playerList.Add(new Sport() { FirstName = "James", LastName = "gunn", Age = 21, BirthDate = "23/04/1996", Country = "NewZealand", SportName = "Hockey", TeamName = "kings11Punjab", PlayerNumber = 006 });
            playerList.Add(new Sport() { FirstName = "John", LastName = "decaprio", Age = 26, BirthDate = "23/04/1991", Country = "Austria", SportName = "Baseball", TeamName = "dunkinDonuts", PlayerNumber = 003 });

            //looping through the list of players
            foreach(Sport player in playerList)
            {    //calling to string method for each player inside console.writeline;
                Console.WriteLine(player.ToString());
            }
        }
    }
}
