using System.IO;

namespace LearningUnitTest.Mocking
{
    public class FileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}