using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Person : IPerson
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Age { get; set; }


        public int CalculateAge()
        {
            return DateTime.Now.Year - this.Age.Year;
        }

        public int CompareTo(Object obj)
        {
            Person p = obj as Person;

            if (Firstname.Equals(p.Firstname))
            {
                if (Lastname.Equals(p.Lastname))
                {
                    if (Age.Equals(p.Age))
                    {
                        return 1;
                    }
                    else { return 0; }
                }
                else { return 0; }
            }
            else { return 0; }
        }
    }
}
