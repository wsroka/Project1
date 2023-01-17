using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Project1
{
    internal class TxtFile
    {
        string path = "C:\\Users\\wikto\\Desktop\\file.txt";
        public void ViewTheFile()
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        public void SaveText(string text)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(text);
            sw.Close();
        }
        public void ViewTheLine(int txtline)
        {
            int counter = 1;
            string[] lines = File.ReadLines(path).ToArray();
            foreach (string r in lines)
            {
                if (counter == txtline)
                {
                    Console.WriteLine(r);
                }
                counter++;
            }
        }
    }
}
