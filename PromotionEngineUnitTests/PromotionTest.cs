using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineBLL.PromotionService;
using PromotionEngineDTO;

namespace PromotionEngineUnitTests
{
    [TestClass]
    public class PromotionTest
    {

        [TestMethod]
        public void test_get_promotions()
        {
            //Arrange
            var promotion = new PromotionService();

            //Act
            var result = promotion.getPromotions();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void test_check_promotion_scenario_1()
        {
            //Arrange
            var promotion = new PromotionService();
            var products = new List<ProductDTO>()
            {
                new ProductDTO("A"){ ProductQuantity = 1},
                new ProductDTO("B"){ ProductQuantity = 1},
                new ProductDTO("C"){ ProductQuantity = 1}
            };
            decimal? expectedOutput = 100;

            //Act
            decimal? total = promotion.checkApplyPromotion(products);

            //Assert
            Assert.AreEqual(expectedOutput, total);
        }

        [TestMethod]
        public void test_check_promotion_scenario_2()
        {
            //Arrange
            var promotion = new PromotionService();
            var products = new List<ProductDTO>()
            {
                new ProductDTO("A"){ ProductQuantity = 5},
                new ProductDTO("B"){ ProductQuantity = 5},
                new ProductDTO("C"){ ProductQuantity = 1}
            };
            decimal? expectedOutput = 370;

            //Act
            decimal? total = promotion.checkApplyPromotion(products);

            //Assert
            Assert.AreEqual(expectedOutput, total);
        }

        [TestMethod]
        public void test_check_promotion_scenario_3()
        {
            //Arrange
            var promotion = new PromotionService();
            var products = new List<ProductDTO>()
            {
                new ProductDTO("A"){ ProductQuantity = 3},
                new ProductDTO("B"){ ProductQuantity = 5},
                new ProductDTO("C"){ ProductQuantity = 1},
                new ProductDTO("D"){ ProductQuantity = 1}
            };
            decimal? expectedOutput = 280;

            //Act
            decimal? total = promotion.checkApplyPromotion(products);

            //Assert
            Assert.AreEqual(expectedOutput, total);
        }
    }
}
