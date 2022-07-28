

namespace FilesDirectoriesPaths
{
    using System;
    using System.IO;

    public static class Exercises
    {
        //1- Write a program that reads a text file and displays the number of words.
        public static void CountTheWords()
        {
            string path = @"D:\MyRepos\LearnCs\Mosh\Csharp Basics\FilesDirectoriesPaths\ExampleFile.txt";
            int count = FilesHelper.NumberOfWordsInFile(path);
            Console.WriteLine($"There are {count} words in the file {path}");
        }
        
        //2- Write a program that reads a text file and displays the longest word in the file.
        public static void FindLongestWord()
        {
            string path = @"D:\MyRepos\LearnCs\Mosh\Csharp Basics\FilesDirectoriesPaths\ExampleFile.txt";
            string[] words = FilesHelper.AllWordsInFile(path);
            string longestWords = FilesHelper.FindLongestWord(words);
            if (longestWords.Contains(","))
            {
                Console.WriteLine($"The longest words in the file {path} are");
                foreach (string s in longestWords.Split(','))
                {
                    Console.WriteLine($"\t{s}");
                }

            }
            else
            {
                Console.WriteLine($"The longest word in the file {path}{Environment.NewLine} is {longestWords}");
            }
        }
    }
}
