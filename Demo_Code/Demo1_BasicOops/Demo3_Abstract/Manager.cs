using System;
using System.Collections.Generic;
using System.Text;

namespace Demo3_Abstract
{
    class Manager : Employee
    {
        int salary;
        string desig;
        public Manager(string name, int empId, string dept, int salary, string desig)
            : base(name, empId, dept)
        {
            this.salary = salary;
            this.desig = desig;
        }
        public override int CalcMonthlySalary()
        {
            int hra = 10000;
            int da = 20000;
            this.salary += hra + da;
            return this.salary;
        }
        public override void DispEmployee()
        {
            base.DispEmployee();

            Console.WriteLine(this.desig + " " + this.salary);
        }

    }
}
