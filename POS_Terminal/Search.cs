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
                
                Console.WriteLine("Enter Item's serial number or any other entry to start searching for an item");
                string itemSelection = Console.ReadLine();
                if (int.TryParse(itemSelection, out int i))
                {
                    foreach (Item x in Item.InventoryMaker())
                    {

                        if (x.SerialNum == itemSelection && x.Quantity > 0)
                        {
                            Console.WriteLine($"{x.Name} added to list");
                            //ADJUST QUANTITY... somehow
                            return x;
                        }
                        else if (x.Quantity <= 0 && x.SerialNum == itemSelection) { Console.WriteLine("Item is out of stock"); break; }


                    }
                }
                else { Search.SearchInventory(); }
                
            }
        }




    }
}
