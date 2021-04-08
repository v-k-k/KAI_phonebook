using System.IO;
using System.Reflection;

namespace KAI_phonebook
{
    /// <summary>
    /// Implements main constants
    /// </summary>
    class File
    {
        private static readonly string _projectPath = Path.GetFullPath(Assembly.GetExecutingAssembly().Location);
        private static readonly string _relativePath = Path.GetFullPath(Path.Combine(_projectPath, @"..\..\..\SerializedData\"));
        public static readonly string data = $"{_relativePath}data.xml";
        public static readonly string fios = $"{_relativePath}fios.xml";
        public static readonly string places = $"{_relativePath}places.xml";
        public static readonly string numbers = $"{_relativePath}numbers.xml";
    }

    class MessageWindow
    {
        public const string header = "Error";
        public const string message = "No selected rows!!!";
    }
    class WindowLabels
    {
        public static readonly string deleted = "DELETED";
    }
}
