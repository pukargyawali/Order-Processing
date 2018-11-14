using System;
using System.Collections.Generic;
using NUnit.Framework;
using OrderProcess.Models;
using OrderProcess.DataContext;
using OrderProcess.Repositories;
using OrderProcess.BusinessLayer.Interfaces;
using OrderProcess.BusinessLayer;

namespace OrderProcessTest
{
    /// <summary>
    /// Contains the test for whole order processing with 4 different cases. 
    /// </summary>

    [TestFixture]
    public class OrderProcessServiceTest
    {
        [Test]
        public void ProcessOrderTestWithQuantityAvailable()
        {
            //Arrange
            OrderProcessService orderService =
                new OrderProcessService(new FakeInventoryRepository(MockupData.GetMockupInventories()),
                                        new FakeOrderRepository(),
                                        new FakeEmailService(),
                                        new FakePaymentGateway());


            // Create the Mockup order for testing as we dont have the UI to collect the real order data. 
            Order order = MockupData.GetMockupOrder();
            var expected = true;

            //Act 
            var actual = orderService.ProcessOrder(order);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ProcessOrderTestWithQuantityUnavailable()
        {
            //Arrange
            OrderProcessService orderService =
                new OrderProcessService(new FakeInventoryRepository(MockupData.GetMockupInventories()), 
                                        new FakeOrderRepository(), 
                                        new FakeEmailService(), 
                                        new FakePaymentGateway()); 


            // Create the Mockup order for testing as we dont have the UI to collect the real order data. 
            Order order = MockupData.GetMockupOrder();

            // Modify the product quantity to order to higher number than available. 
            foreach (Product p in order.Products)
            {
                p.QuantityOrdered.Quantity = 10;
            }

            var expected = false;

            //Act 
            var actual = orderService.ProcessOrder(order);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ProcessOrderTestWithOrderAsNull()
        {
            //Arrange
            OrderProcessService orderService =
                new OrderProcessService(new FakeInventoryRepository(MockupData.GetMockupInventories()),
                                        new FakeOrderRepository(),
                                        new FakeEmailService(),
                                        new FakePaymentGateway());
           
            Order order = null;              
            var expected = false;

            //Act 
            var actual = orderService.ProcessOrder(order); 

            //Assert
            Assert.AreEqual(expected, actual);  
        }

        [Test] 
        public void ProcessOrderTestWithQuantityZero()
        {
            OrderProcessService orderService =
                new OrderProcessService(new FakeInventoryRepository(MockupData.GetMockupInventories()),
                                        new FakeOrderRepository(),
                                        new FakeEmailService(),
                                        new FakePaymentGateway());

            Order order = MockupData.GetMockupOrder();

            // set the quantity of all products ordered to 0. 
            foreach(Product p in order.Products)
            {
                p.QuantityOrdered.Quantity = 0; 
            }

            var expected = false;

            //Act 
            var actual = orderService.ProcessOrder(order);

            //Assert
            Assert.AreEqual(expected, actual);
         }
    }
}

