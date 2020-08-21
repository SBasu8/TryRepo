using System;

namespace Demo10_JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] tdetail = new string[5][];//jagged array 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter no of candidates for training " + (i + 1));
                int size = int.Parse(Console.ReadLine());
                tdetail[i] = new string[size];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < tdetail[i].Length; j++)
                {
                    Console.WriteLine("Enter candidate name");
                    tdetail[i][j] = Console.ReadLine();
                }
            }
        
            foreach (string[] x in tdetail)
            {
                foreach (string y in x)
                    Console.WriteLine(y + " ");
            }
        }
    }
}
