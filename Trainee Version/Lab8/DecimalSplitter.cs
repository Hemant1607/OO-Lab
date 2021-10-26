using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class DecimalSplitter
    {
        public static int GetWhole(double Number)
        {
            int num=Convert.ToInt32(Number);
            return num;
        }

   
        public static double GetFraction(double Number)
        {
            double frac=Number-GetWhole(Number);
            return frac;
        }

       
        public static bool IsOdd(double Number)
        {
            return true;
        }
    }
}
