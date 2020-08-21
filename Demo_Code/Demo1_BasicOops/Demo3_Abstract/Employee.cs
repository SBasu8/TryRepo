using System;
using System.Collections.Generic;
using System.Text;

namespace Demo3_Abstract
{
    abstract class Employee
    {
        string name;
        int empId;
        string dept;
        public Employee(string name, int empId, string dept)
        {
            this.name = name;
            this.empId = empId;
            this.dept = dept;
        }
        public void GetDepartment()//normal method
        {
            Console.WriteLine(this.dept);
        }
        public abstract int CalcMonthlySalary();
        public virtual void DispEmployee()
        { Console.WriteLine(this.empId + " " + this.name + " " + this.dept); }
    }
}
