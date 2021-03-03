using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LoadProject
{
    static class FileProcessor
    {
        private const string Filename = "file.txt";

        public static void WriteCredentialsToFile(string login, string password)
        {
            string text = login + " " + password;
            string path = $"{ Environment.CurrentDirectory}\\{Filename}";
            using (FileStream fstream = new FileStream(path, FileMode.Truncate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
            }
        }

        public static (string, string) ReadCredentialsFromFile()
        {
            string[] words;
            using (FileStream fstream = File.OpenRead($"{Environment.CurrentDirectory}\\{Filename}"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                words = System.Text.Encoding.Default.GetString(array)
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            return (words[0], words[1]);
        }

        public static bool IsHashFileExisting()
        {
            return File.Exists($"{Environment.CurrentDirectory}\\{Filename}");
        }
    }
}
