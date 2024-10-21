using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joins
{
    internal class Program
    {
        class Account
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Balance { get; set; }
        }
        class Transaction
        {
            public int Id { get; set; }
            public int fromAccId { get; set; }
            public int toAccId { get; set; }
            public int Amount { get; set; }
            public DateTime DateTime { get; set; }
        }
        static void Main(string[] args)
        {
            var accounts = new List<Account>()
            {
                new Account{Id=1,Name="A",Balance=5000},
                new Account{Id=2,Name="B",Balance=3000},
                new Account{Id=3,Name="C",Balance=50000},
                new Account{Id=4,Name="D",Balance=1000}

            };
            var transactions = new List<Transaction>()
            {
                new Transaction{Id=101,fromAccId=1,toAccId=2,Amount=500,DateTime=DateTime.Now},
                new Transaction{Id=102,fromAccId=3,toAccId=4,Amount=2000,DateTime=DateTime.Now}
            };
            var transactionDetails = transactions
                .Join(
                accounts,
                t => t.fromAccId,
                a => a.Id,
                (transaction, account) => new { Transaction = transaction, FromAccount = account })
                .Join(
                accounts,
                res => res.Transaction.toAccId,
                a => a.Id,
                (res, toAccount) => new
                {
                   Transaction=res.Transaction.Id,
                   FromAccountName=res.FromAccount.Name,
                   ToAccountNmae=toAccount.Name,
                   Amount=res.Transaction.Amount,
                   Date=res.Transaction.DateTime

                });
            foreach(var item in transactionDetails)
            {
                Console.WriteLine($"From :{item.FromAccountName},To:{item.ToAccountNmae},Amount:{item.Amount}");
            }

        }
    }
}
