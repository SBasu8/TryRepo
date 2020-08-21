using System;
using static System.Console;
using static System.Convert;
namespace Demo6_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            //while loop
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            //do--while loop
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 10);
            //for loop
            WriteLine("Enter the number for multiplication table");
            int num = int.Parse(Console.ReadLine());
            for (int x = 1; x <= 10; x++)
            { Console.WriteLine($"{x}*{num}={x * num}"); }
            //use of break and continue keyword
            for (var k = 1; k <= 10; k++)
            {
                if (k == 5) continue;
                Console.WriteLine(k);
            }
            //nested for loop
            for (int a = 1; a < 4; a++)
            {
                for (int b = 0; b < a; b++)
                {
                    Console.Write("*" + "\t");
                   
                }
                Console.WriteLine();
            }
        }
    }
}
