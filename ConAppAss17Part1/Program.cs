using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAss17Part1
{
   
    class Program
    {
        static void Main()
        {
            BankAccount myAccount = new BankAccount("Rojashree");

            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Account Holder: {myAccount.AccountHolderName}");
            Console.WriteLine($"Initial Balance: ${myAccount.Balance}");

            myAccount.Deposit(1000);
            myAccount.Withdraw(500);

            Console.WriteLine($"Final Balance: ${myAccount.Balance}");
            Console.ReadKey();
        }
    }

} 