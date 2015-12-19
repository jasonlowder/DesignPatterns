using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample
{
    public class Person : IAsset
    {
        public List<IAsset> Assets = new List<IAsset>();
        //public List<RealEstate> RealEstates = new List<RealEstate>();
        //public List<BankAccount> BankAccounts = new List<BankAccount>();
        //public List<Loan> Loans = new List<Loan>();

        public void Accept(IVisitor vistor)
        {
            foreach (IAsset asset in Assets)
                asset.Accept(vistor);
        }
    }
}
