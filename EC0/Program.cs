using System;
using System.Collections.Generic;

namespace EC0
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("that works");
            List<int> numbers = new List<int>() {1, 2, 3};

            foreach (int number in numbers)
            {
                Console.WriteLine($"number : {number}");
            }
            

        }

    }

}
