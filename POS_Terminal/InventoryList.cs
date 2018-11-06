using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POS_Terminal
{
    class InventoryList
        // This class lists out a complete list of the shop's inventory
    {
        public static void DisplayCurrentInventory(List<Item> inventory)
        {
            Console.WriteLine("Name".PadRight(25) + "Category".PadRight(25) + "Description".PadRight(25) + "Price".PadRight(25) + "Quantity".PadRight(25) + "Serial Number".PadRight(25));
            foreach (Item x in inventory)
            {
                string name = x.Name;
                if (name.Length > 23) { name = name.Substring(0,20) + "..."; }
                string category = x.Category;
                if (category.Length > 23) { category = category.Substring(0,20) + "..."; }
                string description = x.Description;
                if (description.Length > 23) { description = description.Substring(0,20) + "..."; }
                //string price = x.Price.ToString();
                //string quantity = x.Quantity.ToString();
                //string serialNum = x.SerialNum.ToString();


                Console.WriteLine(name.PadRight(25) + category.PadRight(25) + description.PadRight(25) + x.Price.ToString().PadRight(25) + x.Quantity.ToString().PadRight(25) + x.SerialNum.PadRight(25));
            }
            
        }
    }
}
//iterate through text file
//split each line into an array
//assign each item in this line array to an attribute of the item class
//store each item to its own separate array