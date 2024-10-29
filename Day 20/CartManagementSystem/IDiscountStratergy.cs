using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementSystem
{
    public interface IDiscountStratergy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }
    public  class PercentageDiscount : IDiscountStratergy
    {
        private readonly decimal _percentage;
        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - (totalAmount * _percentage / 100);

    }
}
