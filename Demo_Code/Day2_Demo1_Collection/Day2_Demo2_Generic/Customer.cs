using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Demo2_Generic
{
    class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Customer()
        {
        }
        public Customer(string name, int id, string phone, string address)
        {
            Name = name;
            Id = id;
            Phone = phone;
            Address = address;
        }
        public override string ToString()
        {
            return (Name + " " + Id + " " + Phone + " " + Address);
        }
        public override bool Equals(object o)
        {
            Customer obj = (Customer)o;
            if (this.Id == obj.Id && this.Name == obj.Name && this.Phone == obj.Phone && this.Address == obj.Address)
                return true;

            else return false;
        }

    }
}
