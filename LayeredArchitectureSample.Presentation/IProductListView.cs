using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureSample.Service;

namespace LayeredArchitectureSample.Presentation
{
    public interface IProductListView
    {
        Model.EnmCustomerType EnmCustomerType { get; }
        string ErrorMessage { set; }

        void Display(IList<ProductViewModel> products);
    }
}
