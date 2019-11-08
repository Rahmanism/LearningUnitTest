using LearningUnitTest.Mocking;
using Moq;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _service;
        private Mock<IFileReader> _fileReader;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _service = new VideoService(_fileReader.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            
            var result = _service.ReadVideoTitle();

            Assert.That(result, Does.Contain("Error").IgnoreCase);
        }
    }
}