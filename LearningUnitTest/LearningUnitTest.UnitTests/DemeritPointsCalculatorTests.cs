using System;
using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _demerit;

        [SetUp]
        public void SetUp()
        {
            _demerit = new DemeritPointsCalculator();
        }
        
        [Test]
        public void CalculateDemeritPoints_SpeedIsNegative_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => _demerit.CalculateDemeritPoints(-1));
        }

        [Test]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(85, 4)]
        public void CalculateDemeritPoints_SpeedIsNotNegative_ReturnDemeritPoints(
            int speed, int expectedDemeritPoints)
        {
            var result = _demerit.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedDemeritPoints));
        }
    }
}