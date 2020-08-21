using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static System.Console;
namespace Day2_Demo1_Collection
{
    class Collection
    {

        public static void DemoArrayList()
        {
            ArrayList al = new ArrayList();

            al.Add(5);
            al.Add("Annie");
            al.Add(2.33);
            al.Add('d');
            al.Remove(2.33);
            al.Add(new Customer("Ram", 25, "9876543", "Amazon"));
            foreach (var val in al) WriteLine(val);
        }
        public static void DemoQueue()
        {
            Queue qlist = new Queue();
            qlist.Enqueue(1);
            qlist.Enqueue("Arun");
            qlist.Enqueue('c');
            WriteLine(qlist.Dequeue());
            qlist.Enqueue(new Customer("Ram", 25, "9876543", "Amazon"));
            foreach (var val in qlist) WriteLine(val);
        }
        public static void DemoStack()
        {
            Stack slist = new Stack();
            slist.Push(new Customer("Ram", 25, "9876543", "Amazon"));
            slist.Push(23);
            slist.Push("hello");
            slist.Push(23.123);
            Console.WriteLine(slist.Pop());
            Console.WriteLine(slist.Peek());
            foreach (var s in slist) WriteLine(s);
        }
        public static void DemoHashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Wells Fargo");
            ht.Add(2, new Customer("Ram", 25, "9876543", "Amazon"));
            ht.Add('a', 1000);
            ht.Add("t1", 30);
            foreach (var val in ht.Keys)
            {
                WriteLine(val);
               WriteLine(ht[val]);
            }
        }
        public static void DemoSorted()
        {
            SortedList ht = new SortedList();
            ht.Add(1, "Wells Fargo");
            ht.Add(2, new Customer("Ram", 25, "9876543", "Amazon"));
            ht.Add('a', 1000);
            ht.Add("t1", 30);
            foreach (var val in ht.Keys)
            {
                WriteLine(val);
               WriteLine(ht[val]);
            }
            WriteLine(ht[1]);
        }
    }
}
