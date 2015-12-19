using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternExample
{
    public class BankAccount : IAsset
    {
        public int Amount { get; set; }
        public double MonthlyInterest { get; set; }

        public void Accept(IVisitor vistor)
        {
            vistor.Visit(this);
        }
    }
}
