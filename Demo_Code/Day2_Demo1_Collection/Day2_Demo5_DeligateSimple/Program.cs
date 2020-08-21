using System;

namespace Day2_Demo5_DeligateSimple
{
    public delegate void deligatePointer();//deligate defnition
    public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //deligatePointer mydeligate = new deligatePointer(p.print);
            deligatePointer mydeligate = p.print;
            mydeligate += p.display;//multicast deligate
            mydeligate();
            mydeligate -= p.print;
            mydeligate();
            Calculate c = new Calculate();
            calAreaPointer cptr = c.calArea;//create a deligate object

            cptr += c.caldistance;//multiple return only last method value is returned
            double area = cptr(20);
            Console.WriteLine(area);
            Console.ReadLine();
        }
        public void print()
        {
            Console.WriteLine("Welcome to deligate");
        }
        public void display()
        {
            Console.WriteLine("Welcome to multicast deligate");
        }
    }
}
