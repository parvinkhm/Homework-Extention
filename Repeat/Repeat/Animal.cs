using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    internal class Animal
    {
        public void GetAge(int? age = null)
        {
            if (age == null)
            {
                Console.WriteLine("Age not found");
                return;
            }



            Console.WriteLine(age);
        }
    }
}
