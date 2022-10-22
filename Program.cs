using System;
using System.Globalization;

namespace AlgorithmPrograms
{
    public class Program
    {
        public static String swapString(String a, int i, int j)
        {
            char[] b = a.ToCharArray();
            char ch;
            ch = b[i];
            b[i] = b[j];
            b[j] = ch;
            return string.Join("", b);
        }

        public static void Main(String[] args)  // main method
        {
            String str = "ABC";
            int len = str.Length;
            Console.WriteLine("All the permutations of the string are: ");
            generatePermutation(str, 0, len);

        }

        public static void generatePermutation(String str, int start, int end)
        {
           
            if (start == end - 1)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i < end; i++)
                {
                    str = swapString(str, start, i);
                    generatePermutation(str, start + 1, end);
                    str = swapString(str, start, i);
                }
            }
        }

    }
}