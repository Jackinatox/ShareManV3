using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareManV3.DataHandling.DataStructs
{
    internal class SPH
    {
        public SPH(String TelName, DateTime Date, double Price)
        {
            teleName = TelName;
            date = Date;
            price = Price;
        }
        public String teleName { get; set; }
        public DateTime date { get; set; }
        public double price { get; set; }
    }
}
