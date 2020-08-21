using System;

namespace Demo8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            string[] names = new string[] { "Arun", "priya", "Ram" };
            char[] alph = new char[] { 'a', '2', 'r' };
            Console.WriteLine(alph[1] + " " + names[0]);
            arr[0] = 10;
            arr[1] = 23;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
            foreach (var x in alph)
            {
                Console.WriteLine(x);
            }
            foreach (var x in names)
            {
                Console.WriteLine(x);
            }

        }
    }
}
