using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponBar.Strategy
{
    public class Bill
    {
        
        private static  int FIRST_LIMIT = 1000;
        private static  int SECOND_LIMIT = 2000;
        private int mQuantity;

      /* public void setQuantity(int quantity)
        {
            mQuantity = quantity;
        }*/

        public double getTotal(int quantity)

        {
            mQuantity = quantity;
            IBillingStrategy strategy;
            if (mQuantity >= SECOND_LIMIT)
            {
                strategy = new BigDiscountStrategy();
            }
            else if (mQuantity >= FIRST_LIMIT)
            {
                strategy = new SmallDiscountStrategy();
            }
            else
            {
                strategy = new NormalStrategy();
            }
            return  strategy.getActualPrice(mQuantity);
        }

        
    }
}
