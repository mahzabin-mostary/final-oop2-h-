using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounnt
{
    abstract class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public double Balance { get; set; }

        public Account() { }
        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("your account credited by {0}. Current balance: {1}", amount, Balance);
        }

        public void ShowInfo()
        {
            Console.WriteLine("\tAccount Name: " + AccName);
            Console.WriteLine("\tAccount Number: " + AccNo);
            Console.WriteLine("\tCurrent Balance: " + Balance);
            Console.WriteLine();
        }

        public abstract void Withdraw(double amount);
        public abstract void Transfer(Account acc, double amount);
    }
    class Current : Account
    {
        public Current(string AccName, string AccNo, double balance) : base(AccName, AccNo, balance) { }

        public override void Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("Your account debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public override void Transfer(Account acc, double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("your account transfer by {0} to the account {1}({2})", amount, acc.AccName, acc.AccNo);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
             class Customer
        {
            public string Name { get; set; }
            Account[] accounts;
            public int AccCount;
            public Customer(string name)
            {
                Name = name;
                accounts = new Account[10];
            }

            public void AddAccount(params Account[] accounts)
            {
                foreach (Account acc in accounts)
                {
                    this.accounts[AccCount++] = acc;
                }
            }

            public void AccDetails()
            {
                Console.WriteLine("Customer name: " + Name);

                for (int i = 0; i < AccCount; i++)
                {
                    accounts[i].ShowInfo();
                }
            }

            public Account findAccount(string accNo)
            {
                Account acc = null;
                for (int i = 0; i < AccCount; i++)
                {
                    if (accNo.Equals(accounts[i].AccNo))
                    {
                        acc = accounts[i];
                        break;
                    }
                }
                return acc;
            }
            class Fixed : Account
            {
                public int openingYear { get; set; }
                public int fixedYear { get; set; }

                public Fixed(string accName, string accNo, double balance, int openingYear, int fixedYear) : base(accName, accNo, balance)
                {
                    this.openingYear = openingYear;
                    this.fixedYear = fixedYear;
                }

                public override void Withdraw(double amount)
                {
                    int today = DateTime.Now.Year;
                    if (today - openingYear > fixedYear)
                    {
                        Balance -= amount;
                    }
                    else
                    {
                        Console.WriteLine("this account is not valid for withdrawn");
                    }
                }

                public override void Transfer(Account acc, double amount)
                {
                    int today = DateTime.Now.Year;
                    if (today - openingYear > fixedYear)
                    {
                        Balance -= amount;
                        acc.Balance += amount;
                    }
                    else
                    {
                        Console.WriteLine("this account is not valid for Transfer");
                    }
                    class Overdraft : Account
                {
                    public int limit { get; set; }

                    public Overdraft() { }
                    public Overdraft(string accName, string accNo, double balance, int limit) : base(accName, accNo, balance)
                    {
                        this.limit = limit;
                    }

                    public override void Withdraw(double amount)
                    {
                        if (amount <= Balance + limit)
                        {
                            Balance -= amount;
                        }
                        else
                        {
                            Console.WriteLine("Not sufficient fund.");
                        }
                    }
                    public override void Transfer(Account acc, double amount)
                    {
                        if (amount <= Balance + limit)
                        {
                            Balance -= amount;
                            acc.Balance += amount;
                        }
                        else
                        {
                            Console.WriteLine("Not sufficient fund.");
                        }
                        class Savings : Account
                    {

                        public Savings(string AccName, string AccNo, double balance) : base(AccName, AccNo, balance) { }

                        public override void Withdraw(double amount)
                        {
                            if (amount <= Balance - 500)
                            {
                                Balance -= amount;
                                Console.WriteLine("Your account debited by {0} to self", amount);
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance, min balance 500");
                            }

                        }

                        public override void Transfer(Account acc, double amount)
                        {
                            if (amount <= Balance - 500)
                            {
                                Balance -= amount;
                                acc.Balance += amount;
                                Console.WriteLine("your account transfer by {0} to the account {1}({2})", amount, acc.AccName, acc.AccNo);
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance, min balance 500");
                            }
                            public static void Main(string[] args)
                            {
                                Account alif = new Savings("mahzabin, "111", 500.0f);
                                Account utsho = new Current("mostary", "112", 2000f);
                                Account rakib = new Fixed("monisha", "113", 1000f, 2015, 10);

                                Account ss = new SuperSavings("kjjor",0 "114", 100f);
                                ss.Withdraw(80);
                                ss.ShowInfo();

                                Account overdraft = new Overdraft("monisha", "005", 100f, 5000);
                                overdraft.Transfer(ss, 5000);
                                overdraft.ShowInfo();

                                Customer customer = new Customer("monisha");

                            }



                        } } 
              