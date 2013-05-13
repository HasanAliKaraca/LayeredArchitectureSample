using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureSample.Repository;
using LayeredArchitectureSample.Service;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace LayeredArchitectureSample.WebUI
{
    public class Bootstrapper
    {
        public static void ConfigureStructureMap()
        {
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<ProductRegistry>();
            });
        }
    }

    public class ProductRegistry : Registry
    {
        public ProductRegistry()
        {
            ForRequestedType<Model.IProductRepository>().TheDefaultIsConcreteType<ProductRepository>();
        }
    }
}
