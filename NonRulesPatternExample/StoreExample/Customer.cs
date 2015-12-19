using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NonRulesPatternExample.StoreExample
{
    class Customer
    {
        public bool IsVeteran { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateOfFirstPurchase DateOfFirstPurchase { get; set; }
    }

    class DateOfFirstPurchase
    {
        public DateTime Value { get; set; }
        public bool HasValue { get; set; }
    }
}
