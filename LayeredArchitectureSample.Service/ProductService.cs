using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureSample.Service
{
    public class ProductService
    {
        private Model.ProductService _productService;

        public ProductService(Model.ProductService ProductService)
        {
            _productService = ProductService;
        }

        public ProductListResponse GetAllProductsFor(ProductListRequest productListRequest)
        {
            ProductListResponse productListResponse = new ProductListResponse();

            try
            {
                IList<Model.Product> productEntities = _productService.GetAllProductsFor(productListRequest.EnmCustomerType);

                productListResponse.Products = productEntities.ConvertToProductListViewModel();
                productListResponse.Success = true;
            }
            catch (Exception ex)
            {
                //log the ex
                productListResponse.Success = false;
                //return err msg
                productListResponse.Message = "An error occured.";
            }

            return productListResponse;
        }
    }
}
