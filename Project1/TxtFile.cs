using System.IO;

namespace Project1
{
    internal class TxtFile
    {
        const string path = "C:\\Users\\wikto\\Desktop\\file.txt";

        public void ReadFile()
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        public void WriteFile(string text)
        {
            using (StreamWriter _streamWriter = new StreamWriter(path))
            {
                _streamWriter.WriteLine(text);
            }
        }
        public void ReadTheLine(int lineNumber)
        {
            int counter = 1;
            string[] lines = File.ReadLines(path).ToArray();
            foreach (string line in lines)
            {
                if (counter == lineNumber)
                {
                    Console.WriteLine(line);
                }
                counter++;
            }
        }
    }
}
