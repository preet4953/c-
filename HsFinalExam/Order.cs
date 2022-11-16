using System;
using System.Collections.Generic;
using System.Text;

namespace HsFinalExam
{
    class Order:Item
    {   
        public String OrderName { get; set; }
        public String ItemName { get; set; }
        public int ShippingPrice { get; set; }
        public int Total { get; set; } 
        public string HomeDelivery { get; set; }
    }
}
