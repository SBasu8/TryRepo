using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Day2_Demo1_Collection
{
    class GenericCollection
    {
        public static void DemoList()
        {
            Console.WriteLine("list");
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(34);
            list.Add(390);
            list.Add(34);
            foreach (int val in list)
                Console.WriteLine(val);
            List<Customer> clist = new List<Customer>();
            clist.Add(new Customer("Ram", 25, "9876543", "Amazon"));
            clist.Add(new Customer("Radha", 50, "9876543789", "Amazon"));
            foreach (var val in clist)
                Console.WriteLine(val);
        }
        public static void DemoHashSet()
        {
            HashSet<int> hs = new HashSet<int>();
            Console.WriteLine("hashset");
            hs.Add(100);
            hs.Add(23);
            hs.Add(32);
            hs.Add(100);
            foreach (int val in hs)
                Console.WriteLine(val);
        }
        public static void DemoQueue()
        {
            Queue<string> gqlist = new Queue<string>();
            gqlist.Enqueue("1");
            gqlist.Enqueue("Arun");
            gqlist.Enqueue("c");
            Console.WriteLine(gqlist.Dequeue());
            foreach (var val in gqlist) Console.WriteLine(val);
        }
        public static void DemoStack()
        {
            Stack<float> gslist = new Stack<float>();
            gslist.Push(23);
            gslist.Push(12.345f);
            gslist.Push(23.123f);
            Console.WriteLine(gslist.Pop());
            Console.WriteLine(gslist.Peek());
            foreach (var s in gslist) Console.WriteLine(s);
        }
        public static void DemoDictionary()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();

            dt.Add(1, "Raj");
            dt.Add(2, "radha");
            dt.Add(3, "Lakshmi");
            foreach (KeyValuePair<int, string> kl in dt)
            {
                Console.WriteLine(kl.Key);
                Console.WriteLine(kl.Value);

            }
        }
        public static void DisplayHighest()
        {
            Console.WriteLine("Enter the number of employees");
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, int> empDetails = new Dictionary<string, int>();
            string name; int salary;
            for (int c = 0; c < count; c++)
            {
                Console.WriteLine("Enter the name of the employee");
                name = Console.ReadLine();
                Console.WriteLine("Enter the salary of the employee");
                salary = int.Parse(Console.ReadLine());
                empDetails.Add(name, salary);
            }

            int hsalary = 0;
            string hname = "";
            foreach (KeyValuePair<string, int> emp in empDetails)
            {
                if (emp.Value > hsalary) { hsalary = emp.Value; hname = emp.Key; }
            }
            Console.WriteLine("The highest paid employee is " + hname);
           
        }
    }
}
       
