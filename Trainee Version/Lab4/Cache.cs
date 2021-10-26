using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Cache
    {
        private static int MAX_CAPACITY = 0;

        public static void Set_MAX_CAPACITY(int value=0)
        {
            Console.WriteLine("Enter max capacity value:");
            MAX_CAPACITY=value;
        }

      
        public static int GetMaxCapacity() 
        {
            
		    Console.WriteLine("Returning MAX_CAPACITY");
		    return MAX_CAPACITY;
	    }
    }
}
