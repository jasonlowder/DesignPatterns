using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// State Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BankAccountExample.BankAccountExample bankAccount = new BankAccountExample.BankAccountExample();
            bankAccount.Run();

            GumballExample.GumballExample gumballExample = new GumballExample.GumballExample();
            gumballExample.Run();
        }
    }
}
