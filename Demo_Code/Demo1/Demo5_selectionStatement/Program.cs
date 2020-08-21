using System;

namespace Demo5_selectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
           // SelectIfelse();
           SwitchCase();
        }
        static void SwitchCase()
        {
            char option;
            Console.WriteLine("Enter your option ");
            Console.WriteLine("A.Insert\nB.Update\n C.Delete\n D.Exit");
            option = char.Parse(Console.ReadLine());
            switch (option)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("Data got inserted");
                    break;
                case 'B':
                    Console.WriteLine("Data got updated");
                    break;
                case 'C':
                    Console.WriteLine("Data got deleted");
                    break;
                case 'D':
                    Console.WriteLine("Thank you");
                    break;
                default: Console.WriteLine("Not a valid option"); break;
            }
        }
        static void SelectIfelse()
        {

            int mark = int.Parse(Console.ReadLine());
            if (mark >= 50 && mark < 60)
            { Console.WriteLine("You passed the Exam and your grade is D"); }
            else if (mark >= 60 && mark < 70)
                Console.WriteLine("You passed the Exam and your grade is C");
            else if (mark >= 70 && mark < 80)
                Console.WriteLine("You passed the Exam and your grade is B");
            else if (mark >= 80 && mark < 90)
                Console.WriteLine("You passed the Exam and your grade is A");
            else if (mark >= 90 && mark <= 100)
                Console.WriteLine("You passed the Exam and your grade is A+");
            else
                Console.WriteLine("Sorry---You failed the Exam");
        }
    }
}
