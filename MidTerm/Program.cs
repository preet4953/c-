using System;
using System.Collections.Generic;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Appointment> aplist = new List<Appointment>();
            enterDummyData(aplist);
            
            var servicelist = createServices();
           
            while (true)
            {
                Console.WriteLine("\n \n Hello welcome to the shop");
                Console.WriteLine(" 1 list of appointments \n 2 create new appointment \n 3 reset schedule \n 4 exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Printall(aplist);
                        break;
                    case 2:
                        
                        int time = 11;
                        Console.WriteLine("Enter your FirstName");
                        String fname = Console.ReadLine();
                        Console.WriteLine("Enter your LastName");
                        String lname = Console.ReadLine();
                        Console.WriteLine("Enter your Email");
                        String email = Console.ReadLine();
                        var appointmentTime= DateTime.Now.Date.AddHours(time);
                        Appointment apObject = new Appointment(fname, lname, email, appointmentTime);
                        Console.WriteLine("Choose service from below");

                        

                   
                        for (int i= 0;i < servicelist.Count;i++)
                        {
                            Console.WriteLine(" {0} ServiceName  {1} \n  ServicePrice {2}",i,servicelist[i].ServiceName,servicelist[i].Price);
                            
                        }
                        Console.WriteLine("Enter 3 to exit");
                        bool run = true;
                        while (run)
                        {
                            Console.WriteLine("Please enter the service number");
                            int userinput = int.Parse(Console.ReadLine());
                            switch (userinput)
                            {
                                case 0:

                                    apObject.servicelist.Add(servicelist[0]);

                                    break;

                                case 1:
                                    apObject.servicelist.Add(servicelist[1]);

                                    break;
                                case 2:
                                    apObject.servicelist.Add(servicelist[2]);
                                    break;
                                case 3:
                                    run = false;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input");
                                    break;
                            }
                        }
                        aplist.Add(apObject);
                        time++;

                        break;
                    case 3:
                        if (aplist.Count == 0)
                        {

                            Console.WriteLine("THe list is empty");

                        }
                        else
                        {
                            for (int i = 0; i < aplist.Count; i++)
                            {
                                Console.WriteLine(aplist[i].FirstName);
                            }
                            aplist.Clear();

                            Console.WriteLine("Schedule reset");
                            Console.WriteLine(aplist.Count);

                        }

                        break;
                    case 4:
                        Console.WriteLine("Exiting the program");
                        return;

                    default:
                        break;

                }
            }

            


        }
        static List<Services> createServices()
        {
            List<Services> servicelist = new List<Services>();
            string[] NameArray = { "HAIRCUT", "HAIRCOLOR", "SHAMPOO/WASH" };
            double[] price = { 15.99, 34.99, 9.99 };
            for(int i = 0; i < NameArray.Length; i++)
            {
                Services service = new Services(NameArray[i],price[i])
                {
                    ServiceName = NameArray[i],
                    Price = price[i]

                };
                servicelist.Add(service);
            }
            return servicelist;



        }
        static void enterDummyData(List<Appointment> aplist)
        {
            String[] fname = { "John", "Clark", "Bruce" };
            String[] lname = { "conner", "kent", "wayne" };
            String[] emails = { "connerjohn@gmail.com", "kentclark@protonmail.com", "waynebruce@protonmail.com" };
            DateTime[] apTime = { DateTime.Now.Date.AddHours(8), DateTime.Now.Date.AddHours(9), DateTime.Now.Date.AddHours(10) };
            Services[] services = { new Services("Haircut", 15.99), new Services("Hair-color", 34.99), new Services("shampoo/wash", 9.99) };
            for(int i = 0; i < fname.Length; i++)
            {
                Appointment ap = new Appointment(Fname:fname[i],Lname:lname[i],email:emails[i],appointmentTime: apTime[i]);
                ap.servicelist.Add(services[i]);
                aplist.Add(ap);             
            }

        }


        static void Printall(List<Appointment> apList)
        {
            foreach (Appointment person in apList)
            {
                Console.WriteLine("\n \n ====================================================================================================");
                Console.WriteLine(" Name        || Email             || AppointmentDate || Service Name    || Price    || After Tax   ");
                Console.WriteLine(" {0} {1}  {2,20}  {3}  {4,30} ", person.FirstName, person.LastName, person.Email, person.AppointmentTime, loopOverServices(lservices: person.servicelist));
            }


        }
        /*static void Printall2(List<Appointment> aplist)
        {
            for(int i = 0; i<aplist.Count) { }
        }
*/

        static String loopOverServices(List<Services> lservices)
        {
            String someString="";
            for(int i=0; i < lservices.Count; i++)
            {

               String sname= lservices[i].ServiceName.ToString();
               String price= lservices[i].Price.ToString();
               String tax= calculateTax(lservices[i].Price).ToString();
               someString += sname + price + tax + " \n ";
            }
            return someString;
            
            
        }


        static double calculateTax(double price)
        {

            double total = price;
            double tax = price * 0.13;
            total += tax;
            return Math.Round(total,1);


        }
        
       


    }
}
