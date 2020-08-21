using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2_Inheritance
{
    
        class SavingsAccount : Account
        {
            public int Intrest { get; set; }
            public SavingsAccount()
            { Console.WriteLine("In savings"); }
            public SavingsAccount(int accid, string name, int balance, int intrest) : base(accid, name, balance)
        {
                this.Intrest = intrest;
            }
            public void calculateBalance()
            {
                this.balance += (this.balance * this.Intrest);
            }
            public void showsavings()
            {
                
                Console.WriteLine(this.accId+" "+this.balance+" "+this.name+" "+this.Intrest);
            }
        }
    }
