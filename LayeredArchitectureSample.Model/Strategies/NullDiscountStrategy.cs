using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureSample.Model
{
    public class NullDiscountStrategy : IDiscountStrategy
    {
        #region IDiscountStrategy Members

        public decimal ApplyExtraDiscountsTo(decimal OriginalSalePrice)
        {
            return OriginalSalePrice;
        }

        #endregion
    }
}
