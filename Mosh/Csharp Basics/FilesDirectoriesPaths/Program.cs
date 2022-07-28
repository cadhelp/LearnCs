using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDirectoriesPaths
{
    internal class Program
	{
		static void Main(string[] args)
		{
			/*
			FileInfo = Instance methods: Should be used more often since the security checking is done only once.
			DirectoryInfo same as FileInfo
			File = Static methods: Should only be called on a small number of operations. The OS does security checking every call
			Directory is the same as File
			Path is used to trim a string based on what you want, GetDirectoryName, Get Extension...
			 */

            //FilesHelper.PathMethods();
            Exercises.CountTheWords();
            Exercises.FindLongestWord();
        }


	}
}
