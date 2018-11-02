using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;


namespace FileUnzipper
{
    class Program
    {
        static StringBuilder errorMessage = new StringBuilder();

        static void Main(string[] args)
        {
            Console.Write("Name the file that you want to unzip: ");
            string nameOfZippedFile = AppDomain.CurrentDomain.BaseDirectory + Console.ReadLine() + ".zip";
            Console.Write("Name the folder that you want to unzip to: ");
            string nameOfNewFile = AppDomain.CurrentDomain.BaseDirectory + Console.ReadLine();

            System.IO.Compression.ZipFile.ExtractToDirectory(nameOfZippedFile, nameOfNewFile);

            RecursivelyUnzipFiles(nameOfNewFile, nameOfNewFile);
            Console.WriteLine(errorMessage);
            Console.ReadLine();
        }

        static void RecursivelyUnzipFiles(string parentPath, string saveToFolderLocation)
        {
            foreach (FileInfo file in new DirectoryInfo(parentPath).GetFiles("*.zip"))
            {
                try
                {
                    string[] split = file.FullName.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                    System.IO.Compression.ZipFile.ExtractToDirectory(file.FullName, saveToFolderLocation + "\\" + split[split.Length - 3]);
                }
                catch (Exception e)
                {
                    errorMessage.AppendLine(e.Message);
                }
            }

            foreach (DirectoryInfo file in new DirectoryInfo(parentPath).GetDirectories())
            {
                RecursivelyUnzipFiles(file.FullName, saveToFolderLocation);
            }
        }
    }
}
