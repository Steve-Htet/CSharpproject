using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sololearn
{
    class BankAccount
    {
        private double balance = 0;

        public void Deposit(double n)
        {
            balance += n;
        }
        public void Withdraw(double n)
        {
            balance -= n;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
    class Program
    {
        public static void Main(String[] args)
        {
            BankAccount b = new BankAccount();
            b.Deposit(596);
            b.Withdraw(200);
            Console.WriteLine(b.GetBalance());
            Console.ReadKey();
        }
    }
}