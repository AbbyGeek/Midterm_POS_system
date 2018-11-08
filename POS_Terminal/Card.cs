using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Terminal
{
    class Card
    {
        public static void CreditCard()
        {
            while (true)
            {
                try
                {
                    string cardNum = MiscMethods.GetInfo("Enter Card Number");
                    string cardExp = MiscMethods.GetInfo("Enter Card Exp (mm/yy)");
                    if (MiscMethods.IsOnlyDigits(cardNum) == false) { Console.WriteLine("Card Number is not all digits. Try again"); continue; }
                    if (cardNum.Length != 16) { Console.WriteLine("Card number is not the right number of digits. Try again"); continue; }
                    int month = int.Parse(cardExp.Substring(0, 2));
                    int year = int.Parse(cardExp.Substring(3, 2));
                    if (month > 12 || month <= 0 || year < int.Parse(DateTime.Now.ToString("yy"))) { Console.WriteLine("Incorrect date. Please try agian"); continue; }
                    Console.WriteLine("Payment Accepted");
                    break;
                }
                catch { Console.WriteLine("Incorrect entry. Try again"); continue; }
            }

        }
    }
}
