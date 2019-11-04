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
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            // Arrange - is in SetUP
            
            // Act
            var result = math.Add( 1, 2 );
            
            // Assert
            Assert.That( result, Is.EqualTo( 3 ) );
        }

        [Test]
        public void Max_FirstArgIsGreater_ReturnsFistArgument()
        {
            // Arrange - is in SetUP

            // Act
            var result = math.Max( 2, 1 );
            
            // Assert
            Assert.That( result, Is.EqualTo( 2 ) );
        }

        [Test]
        public void Max_SecondArgIsGreater_ReturnsSecondArgument()
        {
            // Arrange - is in SetUP

            // Act
            var result = math.Max( 1, 2 );
            
            // Assert
            Assert.That( result, Is.EqualTo( 2 ) );
        }

        [Test]
        public void Max_ArgsAreEqual_ReturnsTheSameArgument()
        {
            // Arrange - is in SetUP
            
            // Act
            var result = math.Max( 1, 1 );
            
            // Assert
            Assert.That( result, Is.EqualTo( 1 ) );
        }
    }
}