using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_creditCard_
{
    internal class CreditCard
    {
        public string AccountHolderName;
        public long CardNumber;
        public byte Expiry;
        public int Cvc;

        public override string ToString()
        {
            return $" CardHolderName: {AccountHolderName},\nCardNo: {CardNumber},\nExpiry: {Expiry},\nCVC: {Cvc}";

        }
    }
}
