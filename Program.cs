using System;
using System.IO;
using System.Linq;

namespace cli_type
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordCount = 10; //Default test is 10 words
            var wordPath = "foo/bar.txt";

            //get random set of wards
            var words = File.ReadAllText(wordPath).Split(' ').OrderBy(x => Guid.NewGuid()).Take(wordCount);
            foreach(string word in words)
            {
                Console.WriteLine(word + " ");
            }

        }
    }
}
