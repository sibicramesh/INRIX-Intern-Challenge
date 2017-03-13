using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankMain
    {
        static void Main()
        {
            Bank bankAccount = new Bank();
           
            bankAccount.deposit(800);
            bankAccount.deposit(200);
            bankAccount.getBalance();

            bankAccount.addInterest();
            bankAccount.getBalance();

            bankAccount.withdraw(20);
            bankAccount.getBalance();

            bankAccount.interestRate = 10;
            bankAccount.addInterest();
            bankAccount.getBalance();

        }

    }
    public class Bank
    {
        static double currBal = 0;              //Current Balance
        public int interestRate = 2;            //Default interest rate set to 2

        /*Deposit Function*/
        public void deposit(int amt)
        {
            currBal += amt;
            Console.WriteLine("Amount deposited is "+ amt);
        }

        /*Withdraw Function*/
        public void withdraw(int amt)
        {
            currBal -= amt;
            Console.WriteLine("Amount withdrawed is "+ amt);
        }

        /*Balance Function*/
        public void getBalance()
        {
            Console.WriteLine("Account Balance is "+ currBal);
        }

        /*Interest Function*/
        public void addInterest()
        {
            currBal = currBal+(currBal*interestRate/100);
            Console.WriteLine("Interest Rate is "+ interestRate);
        }

    }
}
