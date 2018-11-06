using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POS_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Product class with Name, Category,Description, Price for each item (quantity as well?)
            ///12 items minimum. Stored in text file the program reads from
            ///Present a menu and let user choose item by number or letter
            //Allow user to choose quantity
            //Give user line total (item price * quantity)
            // add additional items to order
            //Show Subtotal, sales tax, grand total
            //Ask for payment type Cash Credit Check
            // for cash, ask for amount tendered, provide change
            // for check, get check number
            //for credit, get credit card number, expiration, and CCV
            // Display receipt with all items ordered, subtotal, grandtotal and payment info
            // return to original menu for new order
            // Provide unit test for functions
            //Utelize Git and Github for version control.

            List<Item> inventory = Item.InventoryMaker();
            while (true)
            {
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1) Display Current Inventory");
                Console.WriteLine("2) Search for item");
                Console.WriteLine("3) Checkout");
                string choice = Console.ReadLine();

                if (choice == "1") { InventoryList.DisplayCurrentInventory(inventory); }
                if (choice == "2") { Search.SearchInventory(); }
                if (choice == "3")
                {
                    CheckoutList.purchasing();
                }
            }





        



            
        }
    }
}
