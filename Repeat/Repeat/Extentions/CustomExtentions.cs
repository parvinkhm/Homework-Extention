using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repeat.Extentions
{
    internal static class CustomExtentions
    {
        public static int Sum(this int number, int num2)
        {
            return number + num2;
        }

        public static bool HasStr(this string text, string search)
        {
            return text.Contains(search);
        }

        public static bool CheckDigiOfString(this string str, string patter)
        {
            return Regex.IsMatch(str, patter);
        }

        public static void Test(this Book book)
        {
            Console.WriteLine(book.Name);
        }
        
    }
}
