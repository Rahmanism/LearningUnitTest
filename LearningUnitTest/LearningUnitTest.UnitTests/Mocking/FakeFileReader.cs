using LearningUnitTest.Mocking;

namespace LearningUnitTest.UnitTests.Mocking
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}