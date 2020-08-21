using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Demo3_Exception
{
    class Employee
    {
        string name;
        string empId;
        int salary;

        public int Salary { get => salary; set => salary = value; }

        public Employee()
        {

        }
        public Employee(string name, string empId, int salary)
        {
            this.name = name;
            this.empId = empId;
            //this.Salary = salary;
        }
        public override string ToString()
        {
            return this.name + "\n" + this.empId + "\n" + this.salary;
        }
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.empId == temp.empId && this.name == temp.name)
                return true;
            else
                return false;
        }

    }
}
