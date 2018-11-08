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
            
            //Allow user to choose quantity
            
            // Provide unit test for functions
            // Utelize Git and Github for version control.

            //Either through the menu or a separate question, allowthem to re-display the menu and to complete thepurchase.


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
                    List<Item> purchaceList = CheckoutList.Purchasing(); //creates the list of items and lists them
                    double subtotal = CheckoutList.JustSubtotal(purchaceList); //lists items, prices, and subtotal before returning subtotal
                    double tax = Tax.TaxNum(subtotal); //prints and returns tax
                    double grandTotal = GrandTotal.FinalTotal(subtotal, tax); //prints and stores grand total
                    Console.WriteLine("\n\n");

                    while (true)
                    {
                        Console.WriteLine("Choose payment method:");
                        Console.WriteLine("1) Cash");
                        Console.WriteLine("2) Credit");
                        Console.WriteLine("3) Check");

                        choice = Console.ReadLine();
                        string payMethod = "";

                        if (choice == "1") { Cash.PayInCash(grandTotal); payMethod = "Cash"; } //uses grand total to determine change
                        else if (choice == "2") { Card.CreditCard(); payMethod = "Credit"; }
                        else if (choice == "3") { Check.CheckPay(); payMethod = "Check"; }
                        else { Console.WriteLine("Incorrect entry. Try again"); payMethod = "error"; continue; }
                        Receipt.PrintReciept(subtotal, tax, payMethod, purchaceList); //prints reciept
                        break;
                    }
                }
            }
        }
    }
}
            

