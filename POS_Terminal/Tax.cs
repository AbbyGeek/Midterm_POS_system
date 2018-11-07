using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Terminal
{
    class Tax
    {
        public static double TaxNum(double subtotal)
        {
            string tax = (subtotal * .06).ToString();
            Console.WriteLine(MiscMethods.RecieptLine("Tax:", tax));
            return (subtotal * .06);
        }
    }
}
