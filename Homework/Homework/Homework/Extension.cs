using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Homework
{
    internal static class Extension
    {
        public static int Sum(this int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++) 
            {
                result *= i;
            }
         
            return result;
        }
         
    }
}

