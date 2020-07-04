﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineBLL.PromotionService;

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
    }
}
