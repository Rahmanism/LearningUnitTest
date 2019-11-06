﻿using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new CustomerController();
        }
        
        [Test]
        public void GetCustomer_IdIsZero_ReturnsNotFound()
        {
            var result = _controller.GetCustomer(0);

            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());
            
            // NotFound or one of its derivatives
            // Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnsOk()
        {
            var result = _controller.GetCustomer(1);
            
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}