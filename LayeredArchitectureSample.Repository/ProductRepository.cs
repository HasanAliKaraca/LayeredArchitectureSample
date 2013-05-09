using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureSample.Model;

namespace LayeredArchitectureSample.Repository
{
    public class ProductRepository : IProductRepository
    {
        #region IProductRepository Members

        public IList<Model.Product> FindAll()
        {
            using (ShopDataContext context = new ShopDataContext())
            {
                var products = from p in context.Products
                               select new Model.Product()
                               {
                                   Id = p.ProductId,
                                   Name = p.ProductName,
                                   Price = new Model.Price(p.RRP, p.SellingPrice)
                               };

                return products.ToList();
            }
        }

        #endregion
    }
}
