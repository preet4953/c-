using System;
using System.Collections.Generic;
using System.Text;

namespace HsFinalExam
{
    class Batteries:Item
    {
        public String ItemName { get; set; }
        public int voltage { get; set; }
        public int ShippingPrice = 30;
    }
}
