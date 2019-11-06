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
    }
}