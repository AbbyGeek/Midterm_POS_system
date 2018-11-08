using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Terminal
{
    class MiscMethods
    {
        public static string GetInfo(string prompt)
        {
            Console.Write($"{prompt}: ");
            return Console.ReadLine();
        }

        public static bool IsOnlyDigits(string input)
        {
            return input.All(char.IsDigit);
        }

        public static string RecieptLine(string left, string right)
        {
            return($"{left}".PadRight(20) + $"{right}".PadLeft(20)); ;
        }
        
    }
}
