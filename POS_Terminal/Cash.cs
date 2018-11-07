using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Terminal
{
    class Cash
    {

        public static void PayInCash(double total)
        {
            string paymentMethod = "cash";
            double tendered = double.Parse(MiscMethods.GetInfo("Enter amount tendered"));
            Console.WriteLine($"Change: {tendered - total}\n");            
        }
    }
}