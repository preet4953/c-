using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    interface IPerson:IComparable
    {
        String Firstname { get; set; }
        String Lastname { get; set; }
        DateTime Age { get; set; }

        int CalculateAge();

    }
}
