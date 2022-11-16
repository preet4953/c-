using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Appointment:Person
    {
       public String ServiceName { get; set; }
        public DateTime AppointmentTime { get; set; }


       public Appointment(String Fname,String Lname,String Gen,DateTime Bdate,String Pnum)
        {
            FirstName = Fname;
            LastName = Lname;
            Gender = Gen;
            BirthDate = Bdate;
            PatientNumber = Pnum;

        }
    }
}
