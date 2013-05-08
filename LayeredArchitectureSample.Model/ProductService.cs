using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureSample.Model
{
    public class ProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // this method takes care of discount job for products
        public IList<Product> GetAllProductsFor(EnmCustomerType enmCustomerType)
        {
            IDiscountStrategy discountStrategy = DiscountFactory.GetDiscountStrategyFor(enmCustomerType);

            IList<Product> products = _productRepository.FindAll();

            products.Apply(discountStrategy);

            return products;
        }

    }
}
