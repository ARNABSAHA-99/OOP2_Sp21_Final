using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Arnab", "245", 50000);
            Account a2 = new Account("Arnab Saha", "246", 50000);

            a1.Withdraw(5000);
            a1.Deposit(1000);
            a2.Transfer(a2, 10000);
            Console.WriteLine("**************************************");
            a1.ShowAllTransaction();
            a2.ShowAllTransaction();
            a1.ShowInfo();
            a2.ShowInfo();
        }
    }
}
