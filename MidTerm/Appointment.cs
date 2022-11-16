using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Appointment:Person
    {
        //public Services ServiceName { get; set; }
        public DateTime AppointmentTime { get; set; }
        public List<Services> servicelist = new List<Services>();
        public Appointment(String Fname, String Lname, String email, DateTime appointmentTime)
        {
            FirstName = Fname;
            LastName = Lname;
            Email = email;
           // ServiceName = servicename;
            AppointmentTime = appointmentTime;
        }
        public Appointment()
        {

        }

    }
}
