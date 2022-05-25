using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    public static class TestDataFileReader
    {
        public static string DirectoryName { get; set; } = "TestData";

        public static string GetFileTextContent(string fileName)
        {
            string filePath = GetFilePath(fileName);
            string textContent = File.ReadAllText(filePath);
            return textContent;
        }

        private static string GetFilePath(string fileName)
        {
            string filePath = $"\\{GetDirectoryPath()}\\{fileName}";
            return filePath;
        }

        private static string GetDirectoryPath()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(AppDomain.CurrentDomain.BaseDirectory);
            stringBuilder.Replace("\\bin\\Debug\\net5.0\\", "");
            stringBuilder.Append($"\\{DirectoryName}");
            return stringBuilder.ToString();
        }
    }
}
