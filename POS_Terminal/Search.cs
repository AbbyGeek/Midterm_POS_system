using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Terminal
{
    class Search
    {
        public static void SearchInventory()
        {
            List<Item> InventoryList = Item.InventoryMaker();
            Console.WriteLine("Enter search term");
            string searchTerm = Console.ReadLine().ToLower();

            foreach (Item x in InventoryList)
            {
                if (x.Name.ToLower().Contains(searchTerm) || x.Category.ToLower().Contains(searchTerm) ||x.Description.ToLower().Contains(searchTerm))
                {
                    Console.WriteLine($"Name: {x.Name}");
                    Console.WriteLine($"Category: {x.Category}");
                    Console.WriteLine($"Description: {x.Description}");
                    Console.WriteLine($"Price: {x.Price}");
                    Console.WriteLine($"Quantity: {x.Quantity}");
                    Console.WriteLine($"Serial Number: {x.SerialNum}\n"); 
                }      
            }
        }

        public static Item SearchForCheckout()
        {
            while (true)
            {
                Search.SearchInventory();
                Console.WriteLine("Enter Item's serial number");
                string itemSelection = Console.ReadLine();
                foreach (Item x in Item.InventoryMaker())
                {
                    //Console.WriteLine(x.SerialNum);
                    if (x.SerialNum == itemSelection && x.Quantity > 0)
                    {
                        return x;
                    }
                    else if (x.Quantity <= 0 && x.SerialNum == itemSelection) { Console.WriteLine("Item is out of stock"); break; }
                    
                    
                }
                Console.WriteLine("IF YOU DID EVERYTHING RIGHT, YOU SHOULD NOT BE SEEING THIS");
            }
        }


        //enter search term
        // iterate through list of items, checking if characteristics of each object contain search term.

    }
}
