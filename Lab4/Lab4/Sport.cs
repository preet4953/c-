using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{   
    // Inheriting the features of person class such as name age birthdate and more
    class Sport : Person
    {
        public string SportName { get; set; }
        public string TeamName { get; set; }
        public int PlayerNumber { get; set; }
        
        //overriding the TOString method to return a String of data that is unique for each object
    public override string ToString()
        {
            string info="------------------- \n" +" FirstName: " + FirstName + "\n LastName: " + LastName + "\n Age: " + Age + "\n Birthdate: " + BirthDate + "\n Country: " + Country+"\n SportName: "+SportName+"\n TeamName: "+TeamName+"\n PlayerNumber: "+PlayerNumber;
            return info; 

        }
    }
}
