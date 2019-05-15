using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponBar.Strategy
{
    class NormalStrategy : IBillingStrategy
    {
        public double getActualPrice(double rawPrice)
        {
            return rawPrice;
        }
    }
}
