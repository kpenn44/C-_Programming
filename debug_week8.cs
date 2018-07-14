﻿using System;

namespace ConsoleApp5
{
    class Program
    {
       
        public class BankAccount
        {
            private int acctNum;
            private double balance;
            public event EventHandler BalanceAdjusted;
            public BankAccount(int acct)
            {
                acctNum = acct;
                balance = 0;
            }
            public int AcctNum
            {
                get
                {
                    return AcctNum;
                }
            }
            public double Balance
            {
                get
                {
                    return balance;
                }
            }
            public void MakeDeposit(double amt)
            {
                balance += amt;
                OnBalanceAdjusted(EventArgs.Empty);
            }
            public void MakeWithdrawal(double amt)
            {
                balance -= amt;
                OnBalanceAdjusted(EventArgs.Empty);
            }

            public void OnBalanceAdjusted(EventArgs e)
            {
                BalanceAdjusted(this, e);
            }
        }
        class EventListener
        {
            private BankAccount acct;
            public EventListener(BankAccount account)
            {
                acct = account;
                acct.BalanceAdjusted += new EventHandler
                  (BankAccountBalanceAdjusted);
            }
            private void BankAccountBalanceAdjusted(object sender, EventArgs e)
            {
                Console.WriteLine("The account balance has been adjusted.");
                Console.WriteLine("   Account# {0}  balance {1}",
                  acct.AcctNum, acct.Balance.ToString("C2"));
            }
        }
        class DemoBankAccountEvent
        {
            public static void Main()
            {
                const int TRANSACTIONS = 5;
                char code;
                double amt;
                BankAccount acct = new BankAccount(334455);
                EventListener listener = new EventListener
                  (acct);
                for (int x = 0; x < TRANSACTIONS; ++x)
                {
                    Console.Write("Enter D for deposit or W for withdrawal ");
                    code = Convert.ToChar(Console.ReadLine());
                    Console.Write("Enter dollar amount ");
                    amt = Convert.ToDouble(Console.ReadLine());
                    if (code == 'D')
                        acct.MakeDeposit(amt);
                    
                        acct.MakeWithdrawal(amt);
                }

            }
        }
    }
}
