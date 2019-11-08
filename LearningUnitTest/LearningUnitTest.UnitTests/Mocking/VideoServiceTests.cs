using LearningUnitTest.Mocking;
using NUnit.Framework;

namespace LearningUnitTest.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new VideoService(new FakeFileReader());
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var result = _service.ReadVideoTitle();

            Assert.That(result, Does.Contain("Error").IgnoreCase);
        }
    }
}