using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            int factorial = 1;
            if (n < 0)
            {
                throw new ArgumentException("Cannot calculate factorial of a negative number");
            }
            else
            {
                for(int i = 2; i <= n; i++)
                {
                    factorial *= i;
                }
            }
            return factorial;
        }

        public static string FormatSeparators(params string[] items) 
        {
            string finalString = String.Join(", ", items, 0, items.Length - 1) + " and " + items.LastOrDefault();

            return finalString;
  
        }
    }
}