namespace FilesDirectoriesPaths
{
    using System;
    using System.IO;

    internal class FilesHelper
    {
        /// <summary>
        /// Files methods.
        /// Used for small operations, not for many operations like in file looping operations.
        /// </summary>
        internal static void FileMethods()
        {
            string path = @"c:\somefile.jpg";

            File.Copy(path, @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //Do something
            }

            string content = File.ReadAllText(path);
        }

        /// <summary>
        /// Files the information methods.
        /// </summary>
        internal static void FileInfoMethods()
        {
            string path = @"c:\somefile.jpg";
            FileInfo fi = new FileInfo(path);

            fi.CopyTo("...");
            fi.Delete();
            if (fi.Exists)
            {
                // do something
            }

            fi.OpenRead(); // more complex and not the best route.
        }


        internal static void DirectoryMethods()
        {
            string path = @"c:\projects\CSharpFundamentals";
            Directory.CreateDirectory(path);
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            string[] directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists(path);

            Directory.Delete(path);
        }

        internal static void DirectoryInfoMethods()
        {
            string path = @"c:\projects\CSharpFundamentals";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles("*.*",SearchOption.AllDirectories);
            foreach (FileInfo fileInfo in files)
            {
                Console.WriteLine(fileInfo.Name);
                Console.WriteLine(fileInfo.FullName);
            }

            DirectoryInfo[] directories = directoryInfo.GetDirectories("*.*",SearchOption.AllDirectories);
            foreach (DirectoryInfo directory in directories)
            {
                Console.WriteLine(directory.Name);
                Console.WriteLine(directory.FullName);
            }

        }

        internal static void PathMethods()
        {
            string path = @"c:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            Console.WriteLine($"Extension: {Path.GetExtension(path)}");
            Console.WriteLine($"File Name: {Path.GetFileName(path)}");
            Console.WriteLine($"File Name without Extention: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"Directory Name: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"Full Path: {Path.GetFullPath(path)}");
            Console.WriteLine($"Path Root: {Path.GetPathRoot(path)}");
            Console.WriteLine($"Temp Path: {Path.GetTempPath()}");
            Console.WriteLine($"Temp FileName: {Path.GetTempFileName()}");
            Console.WriteLine($"Random FileName: {Path.GetRandomFileName()}");


            Console.WriteLine($"Volume Separator: {Path.VolumeSeparatorChar}");
            Console.WriteLine($"Path Separator: {Path.PathSeparator}");
            Console.WriteLine($"Directory Separator: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"AltDirectory Separator: {Path.AltDirectorySeparatorChar}");

        }

        internal static int NumberOfWordsInFile(string path)
        {
            //string path = @"c:\somefile.jpg";
            int wordsCount = 0;
            if (!File.Exists(path))
            {
                return wordsCount;
            }

            string content = File.ReadAllText(path);
            content = content.Replace("\r", string.Empty);
            content = content.Replace("\n", string.Empty);
            content = content.Trim();
            string[] words = content.Split(' ');
            wordsCount = words.Length;

            return wordsCount;
        }

        internal static string[] AllWordsInFile(string path)
        {
            if (!File.Exists(path))
            {
                return Array.Empty<string>();
            }

            string content = File.ReadAllText(path);
            content = content.Replace("\r", " ");
            content = content.Replace("\n", " ");
            content = content.Trim();
            return content.Split(' ');

        }

        internal static string FindLongestWord(string[] input)
        {
            string longestWord = string.Empty;
            foreach (string word in input)
            {
                if (word.Length >= longestWord.Length)
                {
                    longestWord = string.IsNullOrWhiteSpace(longestWord) ? word : $"{longestWord},{word}";
                }
            }
            return longestWord;   
        }
    }
}