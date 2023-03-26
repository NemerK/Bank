using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account_class_QA
{
    public class Program
    {
        public class BankAccount
        {
            public double balance;
            public string name;

            public BankAccount(double balance, string name)
            {
                this.balance = balance;
                this.name = name;
            }
            public double GetBalance()
            {
                return balance;  
            }
            public string GetName() { return name; }
            public void SetName(string name) { this.name = name; }
            public void SetBalance(double balance) { this.balance = balance; }
            public void Debit(double amount) 
            {
                if (this.balance <= 0 || amount <= 0 || this.balance - amount < 0) 
                    throw new Exception("Transaction incomplete, please check your credentials.");
                else this.balance -= amount;
            }
            public void Credit(double amount) 
            {
                if (amount <= 0)
                    throw new Exception("Transaction incomplete, please insert a valid sum");
                this.balance += amount; 
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
