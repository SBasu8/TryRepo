using System;

namespace Demo3_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee wFargo = new Manager("Raj", 1000, "Accounts", 100000, "Finance Manager");
            wFargo.GetDepartment();
            Console.WriteLine(wFargo.CalcMonthlySalary());
            wFargo.DispEmployee();
            wFargo = new Clerk("Ajay", 1234, "Accounts", 40000, "A");
            wFargo.GetDepartment();
            Console.WriteLine(wFargo.CalcMonthlySalary());
            wFargo.DispEmployee();
            
        }
    }
}
