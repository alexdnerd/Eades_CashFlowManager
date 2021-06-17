using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eades_CashFlowManager
{
    class Invoice : iPayable
    {
        private decimal Price = 2343.29M;
        private int Quantity = 2;
        private string PartNumber = "A054";
        private string PartDescription = "Barrel of Uranium";


        public decimal GetPayableAmmount()
        {
            return Price;
        
        }

    }
}
