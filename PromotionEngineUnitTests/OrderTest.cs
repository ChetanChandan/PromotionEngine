using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineBLL.PromotionService;

namespace PromotionEngineUnitTests
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void test_create_orders()
        {
            //Arrange
            var orderService = new OrderService();
            string[] order = { "A-1", "B-1", "C-1", "D-1" };

            //Act
            var result = orderService.createOrders(order);

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void test_create_orders_numbers_fail()
        {
            //Arrange
            var orderService = new OrderService();
            string[] order = { "A-1", "B-1", "C-1", "D-1" };
            int failCount = 3;

            //Act
            var result = orderService.createOrders(order);

            //Assert
            Assert.AreNotEqual(result.products.Count, failCount);
        }

        [TestMethod]
        public void test_create_orders_numbers_pass()
        {
            //Arrange
            var orderService = new OrderService();
            string[] order = { "A-1", "B-1", "C-1", "D-1" };
            int expectedCount = 4;

            //Act
            var result = orderService.createOrders(order);

            //Assert
            Assert.AreEqual(result.products.Count, expectedCount);
        }
    }
}
