using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureSample.Model
{
    public class TradeDiscountStrategy : IDiscountStrategy
    {
        #region IDiscountStrategy Members

        public decimal ApplyExtraDiscountsTo(decimal OriginalSalePrice)
        {
            decimal price = OriginalSalePrice;

            //make 5% discount
            price *= 0.95M;

            return price;
        }

        #endregion
    }
}
