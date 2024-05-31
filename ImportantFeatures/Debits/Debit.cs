using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalUsingFeatures.Debits
{
    public class Debit
    {
        public int DebitedAmount(int debitedAmount)
        {
            // surcharge deducted
            return debitedAmount - 1;
        }
    }
}
