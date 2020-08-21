using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2_Inheritance
{
    class Account
    {
        protected int accId;
        protected string name;
        protected int balance;
        public Account()
        {
            Console.WriteLine("Parent Constructor");
        }
        public Account(int accId, string name, int balance)
        {
            this.accId = accId;//this key word is used for refering to current object property
            this.name = name;
            this.balance = balance;
        }
        public void showaccount()
        {
            Console.WriteLine(this.accId + " " + this.name + " " + this.balance);
        }
    }
}
