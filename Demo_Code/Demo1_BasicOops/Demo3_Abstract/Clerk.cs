using System;
using System.Collections.Generic;
using System.Text;

namespace Demo3_Abstract
{
    class Clerk : Employee
    {
        int salary;
        string performance;
        public Clerk(string name, int empId, string dept,
            int salary, string performance)
            : base(name, empId, dept)
        {
            this.salary = salary;
            this.performance = performance;
        }
        public override int CalcMonthlySalary()
        {
            int hra = 5000;

            this.salary += hra;
            return this.salary;
        }
        public override void DispEmployee()
        {
            base.DispEmployee();

            Console.WriteLine(this.performance + " " + this.salary);
        }
    }

}
