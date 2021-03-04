using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Csharp
{

    class myclass
    {
        public static void getstudent()
        {

            string dir = Directory.GetCurrentDirectory();
            string path = dir + "\\TextFile1.txt";

            if (File.Exists(path))
            {
                string[] contents = File.ReadAllLines(path);
                foreach (string content in contents)
                {
                    string[] details = content.Split(",");
                    Console.WriteLine($"Name: {details[0]}, Age: {details[1]}, Dept: {details[2]}");
                }
            }
        }
    }
}