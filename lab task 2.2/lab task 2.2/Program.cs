using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_2._2
{
    class Banking
    {
        abstract class Account : Banking
        {
            public string AccName { get; set; }
            public string AccNo { get; set; }
            public int balance { get; set; }

            public Account(string accName, string accNo, int balance)
            {
                this.AccName = accName;
                this.AccNo = accNo;
                this.balance = balance;
            }


            public void showInfo()
            {
                Console.WriteLine("Account name: " + AccName);
                Console.WriteLine("Account no: " + AccNo);
                Console.WriteLine("Balance: " + balance);
            }

            public abstract void Deposit(int amount);
            public abstract void Withdraw(int amount);
        }
        class Current : Account, Banking
        {
            public int amount { get; set; }
            public Current(string AccName, string AccNo, int balance) : base(AccName, AccNo, balance)
            {
            }

            public override void Deposit(int amount)
            {
                balance += amount;
            }

            public override void Withdraw(int amount)
            {
                if (amount < balance)
                {
                    balance -= amount;
                }
                 class Overdraft : Account, Banking
            {
                public int amount { get; set; }
                public int overdraftLimit { get; set; }
                public Overdraft(string AccName, string AccNo, int balance, int overdraftLimit) : base(AccName, AccNo, balance)
                {
                    this.overdraftLimit = overdraftLimit;
                }

                public override void Deposit(int amount)
                {
                    balance += amount;
                }

                public override void Withdraw(int amount)
                {
                    if (amount < balance + overdraftLimit)
                    {
                        balance -= amount;
                    }
                    class Savings : Account, Banking
                {
                    public int amount { get; set; }
                    public Savings(string AccName, string AccNo, int balance) : base(AccName, AccNo, balance)
                    {
                    }

                    public override void Deposit(int amount)
                    {
                        balance += amount;
                    }

                    public override void Withdraw(int amount)
                    {
                        if (amount < balance - balance * 20 / 100)
                        {
                            balance -= amount;
                        }
                    }
        }
    static void Main(string[] args)
        {
                    {
                        Account acc1 = new Current("monisha", "000", 0000);
                        acc1.showInfo();
                        acc1.Deposit(50000);
                        acc1.showInfo();

                    }
                }
    }
}
