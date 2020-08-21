using System;
using System.Text;
using  static System.Console;
namespace Demo7_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] technology = { 'M', 'I', 'C', 'R', 'O', 'S','O','F','T' };
            string strtechnology = new string(technology); //initializing the cosntructor
            WriteLine($"{technology }");
            string repeatString = new string('*', 5);
            WriteLine($"{repeatString}");
            string[] members = { "Wells", "Fargo" };
            string name = string.Join(" ", members); //method returning string
            WriteLine($"{name}");
            string str = "welcome";
            Console.WriteLine(str.Length + " " + str.Replace("e", "k") + " " + str.ToLower());
            Console.WriteLine(str.Contains("lc"));
            Console.WriteLine(String.Compare("Hello", "hello"));
            string str2 = "WELCOME";
            Console.WriteLine(str.Equals(str2, StringComparison.InvariantCultureIgnoreCase));
            string s1 = "India";
            string s = "welcome";
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1);
            int n = string.Compare("welCome", 3, "come", 0, 4, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine("compare " + n);
            n = string.Compare(s, "welcome to chennai", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(n);
            n = s.CompareTo("welcome");
            Console.WriteLine(n);
            Console.WriteLine(s.Contains("ab"));
            Console.WriteLine(s.Equals("welcome to chennai", StringComparison.InvariantCultureIgnoreCase));
            int n1 = s.IndexOf('c');
            Console.WriteLine(n1);
            char[] c = { 's', 'c' };
            int i = s.IndexOfAny(c);
            Console.WriteLine(i);
            Console.WriteLine(n);
            s = "welcome";
            WriteLine("Remove");//string immutable
            Console.WriteLine(s);
            s.Remove(3);
            Console.WriteLine(s);
            s = s.Remove(3);
            Console.WriteLine(s);
            s = s.Replace('e', 'd');
            Console.WriteLine(s);
            s = string.Concat(s, " India");
            Console.WriteLine(s);
            //Console reading and spliting the string based on aspecific character
            string input = Console.ReadLine();
            string[] data = input.Split(' ', '/');
            foreach(var val in data) { WriteLine(val); }
            StringBuilder sb = new StringBuilder("Suresh");

            sb.Append(", Rohini");

            sb.Append(", Trishika");

            Console.WriteLine(sb);//mutable string
             sb = new StringBuilder("Welcome Wells Fargo");

            sb.Insert(8, "to ");

            Console.WriteLine(sb);
        }
    }
}
