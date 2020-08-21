using System;

namespace Demo4_Enum
{
    class Program
    {
        enum weekdays { Sunday = 10, Monday, TuesDay, WednesDay, ThursDay, FriDay, SaturDay };
        static void Main(string[] args)
        {
            Console.WriteLine(weekdays.Sunday);
            Console.WriteLine((int)weekdays.TuesDay);
            Console.ReadLine();
        }
    }
}
