using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList
{
    internal class CreaditCard
    {
        public long CardNumber;
        public int ExpiryMonth;
        public int ExpiryYear;
        public int Cvc;

        public override string ToString()
        {
            return $"Number:{CardNumber},Expiry:{ExpiryMonth}/{ExpiryYear},CVC:{Cvc}";

        }
    }
    
}
