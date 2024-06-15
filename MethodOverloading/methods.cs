using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class methods
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool withDollars)
        {
            if (withDollars && (a + b) != 1)
            {
                return $"{a + b} dollars";
            }
            else if (withDollars && (b + a) == 1)
            {
                return $"{a + b} dollar";
            }
            else
            {
                return $"{a + b}";
            }
        }
    }
}
