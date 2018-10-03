﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperativeToObjectOriented
{
    class Account
    {
        public string Name;
        public int Balance;

        public void Withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Money withdrawn");
            }
            else
            {
                Console.WriteLine("Balance too low to withdraw");
            }
        }

        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Money deposited");
        }

        public void Transfer(Account toAccount, int amount)
        {
            if (Balance >= amount)
            {
                Withdraw(amount);
                toAccount.Deposit(amount);
                Console.WriteLine("Money transfered");
            }
            else
            {
                Console.WriteLine("Balance too low to transfer");
            }
        }
    }

    class Share
    {
        public string Company;
        public int Amount;
        public int Price;

        public void BuyShare(int amount, Account account)
        {
            int totalPrice = Price * amount;
            if (account.Balance >= totalPrice)
            {
                account.Withdraw(totalPrice);
                Amount += amount;
                Console.WriteLine("Shares bought");
            }
            else
            {
                Console.WriteLine("Balance too low to buy shares");
            }
        }

        public void SellShare(int amount, Account account)
        {
            if (amount <= Amount)
            {
                int totalPrice = Price * amount;
                account.Deposit(totalPrice);
                Amount -= amount;
                Console.WriteLine("Shares sold");
            }
            else
            {
                Console.WriteLine("Number of shares too low to sell");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts =
            {
                new Account
                {
                    Name = "Spar",
                    Balance = 90000
                },
                new Account
                {
                    Name = "Kort",
                    Balance = 5000
                },
                new Account
                {
                    Name = "Resor",
                    Balance = 22000
                }
            };

            Share[] shares =
            {
                new Share
                {
                    Company = "Ericsson",
                    Price = 72,
                    Amount = 20
                },
                new Share
                {
                    Company = "H&M",
                    Price = 129,
                    Amount = 50
                },
                new Share
                {
                    Company = "AstraZeneca",
                    Price = 713,
                    Amount = 5
                }
            };

            while (true)
            {
                Prompt(accounts, shares);
                Console.WriteLine();
            }
        }

        static void Prompt(Account[] accounts, Share[] shares)
        {
            Console.WriteLine("What do you want to do?");

            Console.WriteLine();
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Transfer");
            Console.WriteLine("4. Buy shares");
            Console.WriteLine("5. Sell shares");
            Console.WriteLine("6. Exit");

            Console.WriteLine();
            Console.Write("Select option: ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (option == 1)
            {
                ShowAccounts(accounts);

                Console.WriteLine();
                Console.Write("Select account: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Account account = accounts[accountNumber - 1];

                Console.Write("Select amount: ");
                int amount = int.Parse(Console.ReadLine());

                Console.WriteLine();
                account.Deposit(amount);

                Console.WriteLine();
                ShowAccounts(accounts);
            }
            else if (option == 2)
            {
                ShowAccounts(accounts);

                Console.WriteLine();
                Console.Write("Select account: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Account account = accounts[accountNumber - 1];

                Console.Write("Select amount: ");
                int amount = int.Parse(Console.ReadLine());

                Console.WriteLine();
                account.Withdraw(amount);

                Console.WriteLine();
                ShowAccounts(accounts);
            }
            else if (option == 3)
            {
                ShowAccounts(accounts);

                Console.WriteLine();
                Console.Write("Select 'from' account: ");
                int fromNumber = int.Parse(Console.ReadLine());
                Account fromAccount = accounts[fromNumber - 1];

                Console.Write("Select 'to' account: ");
                int toNumber = int.Parse(Console.ReadLine());
                Account toAccount = accounts[toNumber - 1];

                Console.Write("Select amount: ");
                int amount = int.Parse(Console.ReadLine());

                Console.WriteLine();
                fromAccount.Transfer(toAccount, amount);

                Console.WriteLine();
                ShowAccounts(accounts);
            }
            else if (option == 4)
            {
                ShowShares(shares);

                Console.WriteLine();
                Console.Write("Select share to buy: ");
                int shareNumber = int.Parse(Console.ReadLine());
                Share share = shares[shareNumber - 1];

                Console.Write("Select amount to buy: ");
                int shareAmount = int.Parse(Console.ReadLine());

                Console.WriteLine();
                ShowAccounts(accounts);

                Console.WriteLine();
                Console.Write("Select account: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Account account = accounts[accountNumber - 1];

                Console.WriteLine();
                share.BuyShare(shareAmount, account);

                Console.WriteLine();
                ShowShares(shares);

                Console.WriteLine();
                ShowAccounts(accounts);
            }
            else if (option == 5)
            {
                ShowShares(shares);

                Console.WriteLine();
                Console.Write("Select share to sell: ");
                int shareNumber = int.Parse(Console.ReadLine());
                Share share = shares[shareNumber - 1];

                Console.Write("Select amount to sell: ");
                int shareAmount = int.Parse(Console.ReadLine());

                Console.WriteLine();
                ShowAccounts(accounts);

                Console.WriteLine();
                Console.Write("Select account: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Account account = accounts[accountNumber - 1];

                Console.WriteLine();
                share.SellShare(shareAmount, account);

                Console.WriteLine();
                ShowShares(shares);

                Console.WriteLine();
                ShowAccounts(accounts);
            }
            else if (option == 6)
            {
                Environment.Exit(0);
            }
        }

        static void ShowAccounts(Account[] accounts)
        {
            Console.WriteLine("Your accounts: ");
            Console.WriteLine();

            for (int i = 0; i < accounts.Length; i++)
            {
                Account account = accounts[i];
                Console.WriteLine((i + 1) + ": " + account.Name + " (" + account.Balance + " kr)");
            }
        }

        static void ShowShares(Share[] shares)
        {
            Console.WriteLine("Your shares: ");
            Console.WriteLine();

            for (int i = 0; i < shares.Length; i++)
            {
                Share share = shares[i];
                Console.WriteLine((i + 1) + ": " + share.Company + " (" + share.Amount + " at " + share.Price + " kr)");
            }
        }
    }
}