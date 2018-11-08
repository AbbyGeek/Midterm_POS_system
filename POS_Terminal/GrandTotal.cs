using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Terminal
{
    class GrandTotal
    {
        public static double FinalTotal(double subtotal, double tax)
        {
            double finalTotal = (subtotal + tax);
            Console.WriteLine(MiscMethods.RecieptLine("Grand Total", finalTotal.ToString("0.00")));
            return finalTotal;
        }
    }
}
