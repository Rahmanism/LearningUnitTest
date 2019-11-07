using LearningUnitTest.Mocking;

namespace LearningUnitTest.UnitTests
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}