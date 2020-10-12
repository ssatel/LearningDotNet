using System;
using System.Collections.Generic;

namespace AbstractClass.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Account acc1 = new BusinessAccount(1, "AAA", 200, 500);
            Account acc3 = new SavingsAccount(3, "CCC", 200, .5);
            Account acc2 = new BusinessAccount(2, "BBB", 200, 500);
            Account acc4 = new SavingsAccount(3, "DDD", 200, .5);


            List<Account> list = new List<Account>();
            list.Add(acc1);
            list.Add(acc2);
            list.Add(acc3);
            list.Add(acc4);

            foreach (Account acc in list)
            {
                Console.WriteLine("Balance Account " + acc.Holder + " => " + acc.Balance.ToString("F2"));
                acc.WithdrawAmount(10);

            }
            double sum = 0;
            foreach (Account acc in list)
            {
                Console.WriteLine("Balance Account After WithDraw" + acc.Holder + " => " + acc.Balance.ToString("F2"));

                sum += acc.Balance;
            }

            Console.WriteLine("Total Amount: " + sum.ToString("F2"));

            


        }

    }
}
