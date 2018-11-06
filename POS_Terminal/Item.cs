using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POS_Terminal
    //This class converts the lines in the text file into an Array, and makes that array into an object with the item's properties.
{
    class Item
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string SerialNum { get; set; }

        public Item(string name, string category, string description, float price, int quantity, string serialNum)
        {
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            Quantity = quantity;
            SerialNum = serialNum;
        }

        public static List<Item> InventoryMaker()
        {
            List<Item> inventory = new List<Item>();
            string line;
            StreamReader file = new StreamReader(@"Inventory.txt");

           

            while ((line = file.ReadLine()) != null)
            {
                // splits text line to array
                string[] x = line.Split(',');
                string Name = x[0];
                string Category = x[1];
                string Description = x[2];
                float Price = float.Parse(x[3]);
                int Quantity = int.Parse(x[4]);
                string SerialNum = x[5];

                Item item = new Item(Name, Category, Description, Price, Quantity, SerialNum);
                inventory.Add(item);
            }
            file.Close();
            return inventory;
            
        }
    }
}

