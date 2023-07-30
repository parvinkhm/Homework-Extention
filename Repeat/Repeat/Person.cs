using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    //internal class Person
    //{
    //public static string Name { get; set; }  

    //public static void Test()
    //{
    //    Console.WriteLine("Tets method");
    //}

    //static Person()
    //{
    //    Console.WriteLine("Static constructor");
    //}

    //public Person()
    //{
    //    Console.WriteLine("No static constructor");
    //}

    internal static class Person
    {
        public static string Name { get; set; }

        public static void Test()
        {
            Console.WriteLine("Tets method");
        }

        static Person()
        {
            Console.WriteLine("Static constructor");
        }


    }

        

}
