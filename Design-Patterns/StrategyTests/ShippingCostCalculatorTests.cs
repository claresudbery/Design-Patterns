using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StrategyTests
{
    [TestClass]
    public class ShippingCostCalculatorTests
    {
        [TestMethod]
        public void FedExCosts_5()
        {
            // Arrange
            var shippingCostsCalculator = new ShippingCostCalculatorService();
            var order = new Order();
            order.ShippingMethod = ShippingOptions.FedEx;

            // Act 
            var cost = shippingCostsCalculator.CalculateShippingCost(order);

            // Assert
            Assert.AreEqual(5, cost);
        }

        [TestMethod]
        public void UPSCosts_4point25()
        {
            // Arrange
            var shippingCostsCalculator = new ShippingCostCalculatorService();
            var order = new Order();
            order.ShippingMethod = ShippingOptions.UPS;

            // Act 
            var cost = shippingCostsCalculator.CalculateShippingCost(order);

            // Assert
            Assert.AreEqual(4.25, cost);
        }

        [TestMethod]
        public void SchenkerCosts_3()
        {
            // Arrange
            var shippingCostsCalculator = new ShippingCostCalculatorService();
            var order = new Order();
            order.ShippingMethod = ShippingOptions.Schenker;

            // Act 
            var cost = shippingCostsCalculator.CalculateShippingCost(order);

            // Assert
            Assert.AreEqual(3, cost);
        }
    }
}
