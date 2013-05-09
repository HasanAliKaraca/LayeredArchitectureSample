using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureSample.Service;

namespace LayeredArchitectureSample.Presentation
{
    public class ProductListPresenter
    {
        private IProductListView _productListView;
        private Service.ProductService _productService;

        public ProductListPresenter(IProductListView ProductListView, Service.ProductService ProductService)
        {
            _productListView = ProductListView;
            _productService = ProductService;
        }

        public void Display()
        {
            ProductListRequest productListRequest = new ProductListRequest();
            productListRequest.EnmCustomerType = _productListView.EnmCustomerType;

            ProductListResponse productResponse = _productService.GetAllProductsFor(productListRequest);
            if (productResponse.Success == true)
            {
                _productListView.Display(productResponse.Products);
            }
            else
            {
                _productListView.ErrorMessage = productResponse.Message;
            }
        }
    }
}
