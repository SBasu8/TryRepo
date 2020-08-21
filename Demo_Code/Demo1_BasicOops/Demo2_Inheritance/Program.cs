using System;

namespace Demo2_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(12, "Raj", 2000);
            SavingsAccount sbc001 = new SavingsAccount(12, "Jay", 10000, 2);
            sbc001.showsavings();
        }
    }
}
