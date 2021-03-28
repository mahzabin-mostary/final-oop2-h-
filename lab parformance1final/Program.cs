using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banckaccount11
{
    class Account
    {
        public string AccName { get; set; }
        public string Accid { get; }
        public double Balance { get; set; }

        public Account()
        {
            Console.WriteLine("defult constructor");
        }
        public Account(string accName, string accid, double balance)
        {
            AccName = accName;
            Accid = accId;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc id: " + AccId);
            Console.WriteLine("Balance: " + Balance);

        }
        static void Main(string[] args)
        {

            Account obj = new Account("mahzabin", "1111", 50000);
            obj.ShowInfo();
        }
    }
