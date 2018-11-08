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
            while (true)
            {
                try
                {
                    double tendered = double.Parse(MiscMethods.GetInfo("Enter amount tendered"));
                    if (tendered >= total)
                    {
                        Console.WriteLine($"Change: {(tendered - total).ToString("0.00")}\n");
                        break;
                    }
                    else
                    {
                        total = total - tendered;
                        Console.WriteLine($"{total} is still owed.");
                        continue;
                    }
                }
                catch { Console.WriteLine("Incorrect Entry. Try again."); continue; }
            }
        }
    }
}