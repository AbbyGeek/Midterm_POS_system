using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Terminal
{
    class CheckoutList
    {
        public static List<Item> Purchasing()
        {
            List<Item> purchasing = new List<Item>();
            while (true)
            {
                purchasing.Add(Search.SearchForCheckout());
                Console.WriteLine("Add another item? (y/n)");
                string cont = Console.ReadLine();
                if (cont != "n") { continue; }
                else
                {
                    double subTotal = Subtotal(purchasing);
                    return purchasing;
                }
            }
        }
        public static double Subtotal(List<Item> purchaceList)
        {
            double total = 0;
            foreach (Item x in purchaceList)
            {
                Console.WriteLine(x.Name.PadRight(20) + x.Price.ToString("0.00").PadLeft(20));
                total += x.Price;
            }
            Console.WriteLine($"\nSubtotal: {total.ToString("0.00")}");
            return total;
        }
        public static double JustSubtotal(List<Item> itemList)
        {
            double total = 0;
            foreach (Item x in itemList)
            {
                total += x.Price;
            }
            return total;
        }
    }
}

