using System;
using System.Collections.Generic;

namespace assignment2
{ /*
   Student name: Harpreet Singh
    Course:Mobile solutions development
    class:Section 3
    
   Description:- Dental services Scheduling program
   
   */

    class Program
    {
        static void Main(string[] args)
        {   //created the Empty Person List
            
            List<Person> pList = new List<Person>();
            
            //Creating object of class Appointment List which contains a List
            AppointmentList apl = new AppointmentList();
            
            //filling up the Person list
            PersonList(pList);
            
            int i = 8;
            
            Console.WriteLine("Welcome");
            
            bool run = true;
            
            while (run)
            {
                Console.WriteLine("");
                Console.WriteLine("1 ListOfAllPeople 2 Schedule Appointment 3 Today's schedules 4 exit");
                Console.WriteLine("--------------------------------------------------------------------");
                var input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        
                        Printall(pList);

                        break;
                    case 2:
                        Printnames(pList);
                        Console.WriteLine("Enter the lastname of person you would like to choose from list ");
                        var inpt = Console.ReadLine().ToLower();
                        foreach(Person p in pList)
                        {
                            if (p.LastName.ToLower() == inpt)
                            {
                                Appointment ap = new Appointment(Fname: p.FirstName, Lname: p.LastName, Gen: p.Gender, Bdate: p.BirthDate, Pnum: p.PatientNumber);
                                
                                int a=Calculateage(p.BirthDate);
                                string servname = services(a);
                                if (string.IsNullOrEmpty(servname))
                                    {
                                    Console.WriteLine("");
                                    Console.WriteLine("  \n ------------------Wrong input------------------");
                                    return;
                                }
                                else {
                                    ap.ServiceName = servname;
                                    ap.AppointmentTime = DateTime.Now.Date.AddHours(i);
                                    apl.appointments.Add(ap);
                                    Console.WriteLine("Appointment is booked");

                                }
                                //ap.ServiceName = services(a);
                                // Console.WriteLine("Which operation you would like to perform");


                            }


                        }
                        i++;
                        break;
                    case 3:
                        Console.WriteLine("----------------Today's schedule-------------");
                        foreach(Appointment ap in apl.appointments)
                        {
                            Console.WriteLine(" Name {0} {1} \n Gender {2} \n Birthdate {3} \n PatientNumber {4} \n {5} \n {6}", ap.FirstName, ap.LastName, ap.Gender, ap.BirthDate.ToString("dd/MM/yyyy"), ap.PatientNumber,printOperation(ap.ServiceName),ap.AppointmentTime);
                            Console.WriteLine("--------------------------------------------------------------------------------");
                        }
                        break;
                    case 4:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;


                }





            }







        }

        static String printOperation(String operationName)
        {
            return "The operation "+operationName + " is performed";
        }

        

        //Creates list for first option
        static void PersonList(List<Person> pl)
        {
            string[] firstNames = { "John", "Shawn", "Billy", "Bruce", "Clark", "Peter", "Diana", "Natasha", "Katherine", "Lena" };
            string[] lastNames = { "Conner", "Kane", "Batson", "Wayne", "Kent", "Parker", "Prince", "Romanoff", "Bewster", "Shekh" };
            string[] gender = { "Male", "Male", "Male", "Male", "Male", "Male", "Female", "Female", "Female", "Female" };
            string[] dates = { "02/28/1985", "08/08/2011", "04/28/2010", "08/15/1972", "06/10/1958", "10/10/1954", "01/01/1950", "05/15/1960", "07/22/1997", "04/18/1990" };

            for (int i = 0; i < firstNames.Length; i++)
            {
                Person person = new Person()
                {
                    FirstName = firstNames[i],
                    LastName = lastNames[i],
                    Gender = gender[i],
                    BirthDate = DateTime.ParseExact(dates[i], "MM/dd/yyyy", null),
                    PatientNumber = CreatePatientNum(10)              
                };
                pl.Add(person);
                
                
            }


        }

        //print people in first option
        static void Printall(List<Person> pList)
        {
            foreach (Person person in pList)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(" Name {0} {1} \n Gender {2} \n Birthdate {3} \n PatientNumber {4}", person.FirstName, person.LastName, person.Gender, person.BirthDate.ToString("dd/MM/yyyy"),ChangeString(person.PatientNumber));
                
            }

        }
        //calculates age of person
        static int Calculateage(DateTime Birthyear)
        {
            DateTime Nowyear = DateTime.Now;
            //DateTime Birthyear = DateTime.ParseExact(birthyear, "MM/dd/yyyy", null);
            return Nowyear.Year - Birthyear.Year;

        }

        //print names for 2nd option
        static void Printnames(List<Person> pList)
        {
            Console.WriteLine("-----------------------------------");
            foreach (Person person in pList)
            {
                
                Console.WriteLine(" Name {0} {1} ", person.FirstName, person.LastName);


            }
        }
        static String CreatePatientNum(int length)
        {
            
                var random = new Random();
                String st = "";
                for (int i = 0; i < length; i++)
                {
                    st += random.Next(0, 10);
                }
                 return st;
            
        }

        // to change the first 3 numbers in patientNumber 
        static String ChangeString(String patientnumber)
        {
            String changedString = patientnumber.Remove(0, 3);
            String replace = "XXX";
            String newString= replace + changedString;
            return newString;

        }
        // for getting services
        static string services(int a)
        {   
            string[] serviceNameChildren = { "Cleaning", "Cavityfill", "Checkup", "Xray", "Braces" };
            string[] serviceNameAdult = { "Cleaning", "Cavityfill", "Checkup", "Xray", "veeners" };
            string[] serviceNameSeniors = { "Cleaning", "Cavityfill", "Checkup", "Xray", "Dentures" };
            String st = "";
            if (a > 0 && a <= 18)
            {
                Console.WriteLine("----------Services Availale-----------");
                foreach(String s in serviceNameChildren)
                {
                    Console.WriteLine("| "+s);
                }
                Console.WriteLine("Type the Service name");
                String serviceName = Console.ReadLine().ToLower();
                foreach(String s in serviceNameChildren)
                {
                    if (serviceName == s.ToLower())
                    {
                        st = serviceName;
                        return st;
                    }
                    
                    
                }

                Console.WriteLine("Entered service is not in list");
                return st;
            }
            else if (a > 18 && a < 60)
            {
                Console.WriteLine("----------Services Availale-----------");
                foreach (String s in serviceNameAdult)
                {
                    Console.WriteLine("| "+s);
                }
                Console.WriteLine("Type the Service name");
                String serviceName = Console.ReadLine().ToLower();
                foreach (String s in serviceNameAdult)
                {
                    if (serviceName == s.ToLower())
                    {
                        st = serviceName;
                        return st;

                    }
                    
                }


                return st;

            }
            else
            {
                Console.WriteLine("----------Services Availale-----------");
                foreach (String s in serviceNameSeniors)
                {
                    Console.WriteLine("|" + s);
                }
                Console.WriteLine("Type the Service name");
                String serviceName = Console.ReadLine().ToLower();
                foreach (String s in serviceNameSeniors)
                {
                    if (serviceName == s.ToLower())
                    {
                        st = serviceName;
                        return st;

                    }
                    
                }


                return st;
            }


        }



    }
}
