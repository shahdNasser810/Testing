using System;

namespace BankAccount
{
    public class MyBankAccount
    {
        private string name;
        private double balance;

        public MyBankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public string GetName() { return this.name; }
        public double GetBalance() { return this.balance; }
        public void SetName(string name) { this.name = name; }
        public void SetBalance(double balance) { this.balance = balance; }
        public void Debit(double amount)
        {
            if (this.balance-amount <= 0)
                throw new Exception(string.Format("balance less than 0"));
            else
            {
                this.balance -= amount;
                Console.WriteLine("credit done");
            }
        }
        public void Credit(double amount)
        {
                this.balance += amount;
                Console.WriteLine("debit done");
        }
        static void Main(string[] args)
        {
            MyBankAccount b = new MyBankAccount("2131", 324);
        }
    }
}
