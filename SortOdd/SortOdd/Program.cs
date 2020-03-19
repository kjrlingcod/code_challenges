using System;
using System.Collections.Generic;

namespace SortOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Inputs:");
            int no = Convert.ToInt32(Console.ReadLine());
            List<int> num = new List<int>();
            Console.WriteLine($"Enter {no} numbers:");
            for (int i = 0; i < no; i++)
            {
                num.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int[] kl = SortOdd(num.ToArray());
            Console.WriteLine("Result:");
            for (int b = 0;b < kl.Length;b++)
            {
                Console.WriteLine(kl[b]);
            }
            Console.ReadKey();
        }
        public static int[] SortOdd(int[] x)
        {
            List<int> newArr = new List<int>(), evenArr = new List<int>(), indexArr = new List<int>();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 != 0)
                {
                    newArr.Add(x[i]);
                }
                else
                {
                    indexArr.Add(i);
                    evenArr.Add(x[i]);
                }
            }
            newArr.Sort();
            for (int c = 0; c < indexArr.Count; c++)
            {
                newArr.Insert(indexArr[c], evenArr[c]);
            }
            return newArr.ToArray();
        }
    }
}
