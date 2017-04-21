using System;
using Domain;
using Domain.RepositoryPatterns;
using Domain.StrategyPatterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StrategyTests
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        [TestMethod]
        public void CustomerWithId1IsCalledClare()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var customerId = 1;

            // Act
            var customer = customerRepository.FindBy(customerId);

            // Assert
            Assert.AreEqual("Clare", customer.Name);
        }
    }
}
