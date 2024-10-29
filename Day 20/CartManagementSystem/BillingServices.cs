using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementSystem
{
    public class BillingService
    {
        private readonly Cart _cart;
        private readonly PercentageDiscount _percentageDiscount;

        public BillingService(Cart cart, PercentageDiscount percentageDiscount)
        {
            _cart = cart;
            _percentageDiscount = percentageDiscount;
        }

        public decimal CalculateFinalTotal()
        {
            decimal total = _cart.CalculateTotalWithoutDiscount();
            return _percentageDiscount.ApplyDiscount(total);
        }
    }

}
