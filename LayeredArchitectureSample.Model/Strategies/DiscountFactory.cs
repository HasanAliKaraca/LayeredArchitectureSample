using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureSample.Model
{
    public static class DiscountFactory
    {
        public static IDiscountStrategy GetDiscountStrategyFor(EnmCustomerType enmCustomerType)
        {
            switch (enmCustomerType)
            {
                case EnmCustomerType.Trade:
                    return new TradeDiscountStrategy();
                default:
                    return new NullDiscountStrategy();
            }
        }
    }
}
