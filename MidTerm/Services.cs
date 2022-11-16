using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    class Services
    {
        public string ServiceName { get; set; }
        public double Price { get; set; }

        public Services(String sName, double pr)
        {
            ServiceName = sName;
            Price = pr;
        }



    }
}
