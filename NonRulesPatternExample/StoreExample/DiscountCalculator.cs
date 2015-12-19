using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRulesPatternExample.StoreExample
{
    public class DiscountCalculator
    {
        public decimal CalculateDiscountPercentage(Customer customer)
        {
            decimal discount = 0;
            if (customer.DateOfBirth < DateTime.Now.AddYears(-65))
            {
                // Senior discount
                discount = .05m;
            }
            if (customer.DateOfBirth.Day == DateTime.Today.Day &&
                customer.DateOfBirth.Month == DateTime.Today.Month)
            {
                // birthday discount
                discount = Math.Max(discount, .1m);
            }
            if (customer.DateOfFirstPurchase.HasValue)
            {
                if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-1))
                {
                    // after 1 year, loal customers get 10%
                    discount = Math.Max(discount, .1m);

                    if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-5))
                    {
                        // after 5 years, get 12%
                        discount = Math.Max(discount, .12m);

                        if (customer.DateOfFirstPurchase.Value < DateTime.Now.AddYears(-10))
                        {
                            // after 10 year, get 20%
                            discount = Math.Max(discount, .2m);
                        }
                    }
                    if (customer.DateOfBirth.Day == DateTime.Today.Day &&
                    customer.DateOfBirth.Month == DateTime.Today.Month)
                    {
                        // birthday additional 10% discount
                        discount += .1m;
                    }
                }
            }
            else
            {
                // first time purchase discount of 15%
                discount = Math.Max(discount, .15m);
            }

            if (customer.IsVeteran)
            {
                // veterans get 10%
                discount = Math.Max(discount, .1m);
            }

            return discount;
        }
    }
}
