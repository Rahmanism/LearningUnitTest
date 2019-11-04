using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math math;

        /// <summary>
        /// Will run before every test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            math = new Math();
        }

        [Test]
        // [Ignore("Just for learning IGNORE!")]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            // Arrange - is in SetUP

            // Act
            var result = math.Add( 1, 2 );

            // Assert
            Assert.That( result, Is.EqualTo( 3 ) );
        }

        [Test]
        [TestCase( 2, 1, 2 )]
        [TestCase( 1, 2, 2 )]
        [TestCase( 1, 1, 1 )]
        public void Max_WhenCalled_ReturnsTheGreaterArgument(
            int a, int b, int expectedResult )
        {
            var result = math.Max( a, b );

            Assert.That( result, Is.EqualTo( expectedResult ) );
        }
    }
}