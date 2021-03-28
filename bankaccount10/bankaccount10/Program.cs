using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount10
{
    public class transaction
    {
        public string sender;
        public string receiver;
        public int amount;
        string additionalinfo;
        public transaction(){
             Console.WriteLine(" this is a defult constructor");

            }
        public transaction(string sender, string receiver, int amount, string additionalinf)
        { 
            this.amount = amount;
            this.sender = sender;
            this.receiver = receiver;
            this.additionalinfo = additionalinfo;
            Console.WriteLine(" this is a parametarized constructor");
        }

        
        public void ShowInfo()
        {
            Console.WriteLine("==========");
            Console.WriteLine("Account sender: " + sender);
            Console.WriteLine("Account reciver: " + receiver);
            Console.WriteLine("Current additional info: " + additionalinfo);
            Console.WriteLine("Current amount: " + amount);
            Console.WriteLine("==========");
        }
        public void showDetails()
        {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc amount: " + amount);
            Console.WriteLine("Balance: " + Balance);

        }
        public void Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("Your acc has been debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance: Min Balance 500")


       public void Transfer(Account amount, double amount)
                {
                    if (Balance - amount >= 500)
                    {
                        this.Balance -= amount;
                        acc.Balance += amount;
                        Console.WriteLine("Your acc has been debited by {0} to {1}({2})", amount, acc.AccName, acc.AccNo);
                    }
                    public void add account(){
                        Console.WriteLine("added all acounts", obj + obj1 +obj2);

                    }
                }

                static void Main(string[] args)
                {

                    transaction a1 = new transaction("monisha", " mon", 500000, "null");



                    transaction obj = new transaction("mostary11", "145", 50000);
                    transaction obj1 = new Withdraw("mostary1111", "145", 50000);
                     transaction obj2 = new Transfer("monisha11111", "146", 50000);


                     a1.ShowInfo();
                    obj.ShowInfo();
                    obj2.showDetails();
                    obj1.showDetails();



        transaction c = new transaction();
                    c.AddAccount(obj,obj1,obj2);
                    var acc = c.GetAccount("146");
                    acc.Withdraw(49600);
                }


        }
}
}
