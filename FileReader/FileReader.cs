using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    public static class FileReader
    {
        public static string GetFileTextContent(string fileName)
        {
            string relativePath = $"\\TestData";
            string baseDirPath = AppDomain.CurrentDomain.BaseDirectory;
            baseDirPath = baseDirPath.Replace("\\bin\\Debug\\net5.0\\", "");
            string directoryPath = baseDirPath + relativePath;
            string filePath = $"\\{directoryPath}\\{fileName}";
            string textContent = File.ReadAllText(filePath);
            return textContent;
        }
    }
}
