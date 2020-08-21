using System;

namespace Day2_Demo3_Exception
{
    public class salaryException : Exception
    {
        public salaryException(string s) : base(s)
        { }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Mala", "100", 0);
            try
            {
                if (emp.Salary == 0) throw new salaryException("Salary cannot be zero");
            }
            catch (salaryException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }


            //try
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine(num / 2);
            //    try
            //    {
            //        int[] a = new int[] { 1, 2, 3 };
            //        Console.WriteLine(a[3]);
            //    }
            //    catch(IndexOutOfRangeException e)
            //    {

            //        Console.WriteLine("inner\n"+e.Message + " " + e.Source + " " + e.StackTrace);

            //    }
            //}

            //catch (DivideByZeroException e)
            //{

            //    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);

            //}
            //finally
            {
                Console.WriteLine("Program ended");
            }
            Console.ReadLine();
        }
    }
}
