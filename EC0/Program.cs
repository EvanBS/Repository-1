using System;
using System.Collections.Generic;

namespace EC0
{
    
    class Program
    {
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public static void Main(string[] args)
        {

            int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                Swap(ref arr[i], ref arr[arr.Length - i - 1]);
            }
            
            foreach (int i in arr)
            {
                Console.Write($"{i} \t");
            }
        }

    }

}
