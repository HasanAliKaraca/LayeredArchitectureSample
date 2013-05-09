using System;
namespace LayeredArchitectureSample.Service
{
    interface IProductViewModel
    {
        string Discount { get; set; }
        string Name { get; set; }
        int ProductId { get; set; }
        string RRP { get; set; }
        string Savings { get; set; }
        string SellingPrice { get; set; }
    }
}
