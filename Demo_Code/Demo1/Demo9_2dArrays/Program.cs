using System;

namespace Demo9_2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] subject = new int[5, 3];
            Console.WriteLine(subject.Length);
            Console.WriteLine(subject.Rank);
            Console.WriteLine("Enter the marks details");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the marks for Candidate " + (i + 1));
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter marks for subject " + (j + 1));
                    subject[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(subject[i, j] + " ");
                }
                Console.WriteLine();
            }

            foreach (int x in subject)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
    }

