using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Terminal
{
    class Receipt
    {
        public static void PrintReciept(double subtotal, double tax, string paymentMethod, List<Item> PurchaseList)
        {
            Console.WriteLine("****************Thank you for shopping at Derby Central****************");
            foreach (Item x in PurchaseList)
            {
                Console.WriteLine(MiscMethods.RecieptLine(x.Name, x.Price.ToString()));
            }
            Console.WriteLine("\n\n" + MiscMethods.RecieptLine("SUBTOTAL", subtotal.ToString()));
            Console.WriteLine("\n" + MiscMethods.RecieptLine("TAX", tax.ToString()));
            Console.WriteLine("\n" + MiscMethods.RecieptLine("GRAND TOTAL", (tax + subtotal).ToString()));
            Console.WriteLine("\n" + MiscMethods.RecieptLine("PAYMEND METHOD", paymentMethod));
            Console.WriteLine("****************Thank you for shopping at Derby Central****************");
        }
    }
}
