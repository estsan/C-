using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session19Exercise2
{
    class Account
    {
        private int amount = 0;

        public void Deposit(int x)
        {
            amount += x;
        }
        public void Withdraw(int y)
        {
            if (y <= amount)
            {
                amount -= y;
            }
            else
            {
                Console.WriteLine("Insufficient funds, no withdrawl");
            }
        }
        public int GetAmount()
        {
            return amount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            bool inBusiness = true;

            while (inBusiness)
            {
                Console.WriteLine("You have {0}kr in your account. Would you like to ", account.GetAmount());
                Console.WriteLine("1. Deposit Money,");
                Console.WriteLine("2. Withdraw Money, or");
                Console.WriteLine("3. Exit bank?");

                int a = int.Parse(Console.ReadLine());
                if (a == 3)
                {
                    inBusiness = false;
                }
                else
                {
                    Console.WriteLine("How Much?");
                    int b = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        account.Deposit(b);
                    }
                    else if (a == 2)
                    {
                        account.Withdraw(b);
                    }
                }
            }
        }
    }
}
