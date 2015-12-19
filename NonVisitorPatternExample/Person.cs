using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonVisitorPatternExample
{
    public class Person
    {
        public List<RealEstate> RealEstates = new List<RealEstate>();
        public List<BankAccount> BankAccounts = new List<BankAccount>();
        public List<Loan> Loans = new List<Loan>();
    }
}
