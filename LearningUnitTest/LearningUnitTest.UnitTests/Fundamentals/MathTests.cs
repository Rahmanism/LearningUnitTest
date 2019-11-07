using System.Linq;
using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests.Fundamentals
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        /// <summary>
        /// Will run before every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        // [Ignore("Just for learning IGNORE!")]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            // Arrange - is in SetUP

            // Act
            var result = _math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(
            int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            // very general test - bad
            Assert.That(result, Is.Not.Empty);

            // a little more specific but we still can any wrong numbers.
            Assert.That(result.Count(), Is.EqualTo(3));

            // the better way
            // order is not important so:
            Assert.That(result, Is.EquivalentTo(new[] {1, 3, 5}));
            
            // if we want ordered or unique arrays
            // Assert.That(result, Is.Ordered);
            // Assert.That(result, Is.Unique);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void GetOddNumbers_LimitIsZeroOrLess_ReturnEmpty(int limit)
        {
            var result = _math.GetOddNumbers(limit);
            
            Assert.That(result, Is.Empty);
        }
    }
}