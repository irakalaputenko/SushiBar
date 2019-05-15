using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponBar.Strategy
{
    interface IBillingStrategy
    {
        double getActualPrice(double rawPrice);
    }
}
