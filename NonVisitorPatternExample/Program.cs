using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonVisitorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.BankAccounts.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01 });
            person.BankAccounts.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            person.RealEstates.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            person.Loans.Add(new Loan { Owed = 40000, MonthlyPayment = 500 });

            int networth = 0;
            foreach (var bankAccount in person.BankAccounts)
                networth += bankAccount.Amount;
            foreach (var realEstate in person.RealEstates)
                networth += realEstate.EstimatedValue;
            foreach (var loan in person.Loans)
                networth -= loan.Owed;

            Console.WriteLine(networth);
            Console.ReadKey();
        }
    }
}
