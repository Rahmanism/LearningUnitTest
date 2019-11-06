using System;
using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;
        
        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }
        
        [Test]
        public void Log_WhenCalled_SetLastErrorProperty()
        {
            const string error = "a";
            _logger.Log(error);
            
            Assert.That(_logger.LastError, Is.EqualTo(error));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var id = Guid.Empty;
            _logger.ErrorLogged += (sender, args) => { id = args; };
            
            _logger.Log("a");
            
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}