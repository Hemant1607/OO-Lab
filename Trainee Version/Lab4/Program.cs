using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter max cache value:");
            int value=CustomConsole.ReadInt();
            Cache.Set_MAX_CAPACITY(value);
            Console.WriteLine("MAX_CAPACITY is " + Cache.GetMaxCapacity());
		    
		    Cache.Set_MAX_CAPACITY();
		    Console.WriteLine("MAX_CAPACITY is " + Cache.GetMaxCapacity());

		    Cache.Set_MAX_CAPACITY();
            Console.WriteLine("MAX_CAPACITY is " + Cache.GetMaxCapacity());

            Console.ReadLine();
        }
    }
}
