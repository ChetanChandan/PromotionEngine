using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineBLL.PromotionService;

namespace PromotionEngineUnitTests
{
    [TestClass]
    public class ProductTest
    {        
        [TestMethod]
        public void test_get_products()
        {
            //Arrange
            var product = new ProductService();

            //Act
            var result = product.getProducts();

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
