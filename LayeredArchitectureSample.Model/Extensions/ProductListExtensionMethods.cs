using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureSample.Model
{
    // Service class needs to be able to apply a given discount strategy to a collection of products
    public static class ProductListExtensionMethods
    {
        public static void Apply(this IList<Product> products, IDiscountStrategy discountStrategy)
        {
            foreach (Product p in products)
            {
                // just setting discount strategy property
                p.Price.SetDiscountStrategyTo(discountStrategy);
            }
        }
    }
}
