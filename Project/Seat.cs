using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Project
{
    class Seat:IComparable<Seat>
    {

        public String CustomerName { get; set; }
        public String SeatNumber { get; set; }

        public int CompareTo(Seat other)
        {
            return CustomerName.CompareTo(other.CustomerName);
        }
    }
}
