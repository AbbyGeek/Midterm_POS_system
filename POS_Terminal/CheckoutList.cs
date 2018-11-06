using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Terminal
{
    class CheckoutList
    {
        public static List<Item> purchasing()
        {
            while (true)
            {
                List<Item> purchasing = new List<Item>();
                purchasing.Add(Search.SearchForCheckout());
                Console.WriteLine("Add another item? (y/n)");
                string cont = Console.ReadLine();
                if (cont == "y") { continue; }
                else
                {
                    int itemcount = 0;
                    double total = 0.00;
                    Console.WriteLine($"SUBTOTAL");
                    foreach (Item x in purchasing)
                    {
                        
                        Console.WriteLine(x.Name.PadLeft(20) + x.Price.ToString("0.00").PadRight(20));
                        total += x.Price;
                        itemcount++;
                        x.Quantity -= 1;
                    }
                    return purchasing;
                }

            }
        }
    }
}
