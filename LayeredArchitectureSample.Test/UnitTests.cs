using System;
using LayeredArchitectureSample.Model;
using LayeredArchitectureSample.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LayeredArchitectureSample.Test
{
    [TestClass]
    public class UnitTests
    {
        ProductRepository pr;

        public UnitTests()
        {
            pr = new ProductRepository();
        }

        [TestMethod]
        public void ConnectionTest()
        {
            var a = pr.FindAll();

            Assert.IsTrue(a.Count > 0);
        }

        [TestMethod]
        public void ProductServiceTest()
        {
            ProductService ps = new ProductService(pr);
            var result = ps.GetAllProductsFor(EnmCustomerType.Trade);

            Assert.IsTrue(result.Count > 0);
        }
    }
}
