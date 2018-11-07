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
                Console.WriteLine(x.Name.PadRight(30) + x.Price.ToString("0.00"));
                total += x.Price;
            }
            Console.WriteLine($"\nSubtotal: {total.ToString("0.00")}");
            return total;
        }
                //    int itemcount = 0;
                //    double total = 0.00;
                //    Console.WriteLine($"SUBTOTAL");
                //    foreach (Item x in purchasing)
                //    {
                        
                //        Console.WriteLine(x.Name.PadRight(30) + x.Price.ToString("0.00"));
                //        total += x.Price;
                //        itemcount++;
                //        x.Quantity -= 1;
                //    }
                //    Console.WriteLine($"\nSubtotal: {total.ToString("0.00")}");
                //    return total;
  
                }

            }

