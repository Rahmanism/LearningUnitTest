using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_NumberIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NumberIsDivisibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);
            
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_NumberIsDivisibleBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NumberIsNotDivisibleBy3Nor5_ReturnNumberItSelf()
        {
            var result = FizzBuzz.GetOutput(2);
            
            Assert.That(result, Is.EqualTo("2"));
        }
    }
}