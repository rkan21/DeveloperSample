using System;
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

            //Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));
            StringBuilder sb = new StringBuilder();
            
            string separtor = ", ";

            for (int c = 0; c < items.Length; c++)
            {
                if (items[c].Length > 0)
                {
                    if (c == 0)
                        separtor = ", ";
                    else if (c < (items.Length - 1))
                        separtor = " and ";
                    else
                        separtor = "";

                    sb.Append(items[c]);
                    sb.Append(separtor);
                }
            }

            var s = sb.ToString();
            return s;
        }
    }
}