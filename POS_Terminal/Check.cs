using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Terminal
{
    class Check
    {
        public static void CheckPay()
        {
            while (true)
            {

                string ActNum = MiscMethods.GetInfo("Enter annount number");
                string RoutNum = MiscMethods.GetInfo("Enter routing number");
                if (MiscMethods.IsOnlyDigits(ActNum) == false || MiscMethods.IsOnlyDigits(RoutNum) == false)
                {
                    Console.WriteLine("Incorrect entry. Try again"); continue;
                }
                Console.WriteLine("Payment Accepted");
            }
        }

    }
}
