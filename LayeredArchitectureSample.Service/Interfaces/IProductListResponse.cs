using System;
using System.Collections.Generic;
namespace LayeredArchitectureSample.Service
{
    interface IProductListResponse
    {
        string Message { get; set; }
        IList<ProductViewModel> Products { get; set; }
        bool Success { get; set; }
    }
}
