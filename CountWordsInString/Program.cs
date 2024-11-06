using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CountWordsInString
{
    class Program
    {
        static void Main(string[] args)
        {

            String input = "Hi hello myself akhila";
            var c = input.Split(' ');
            //--------------------------------------------------------------------------
                                                                           //find longest word
            //Console.WriteLine("Enter as sentence");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');
            //string longestWord = "";

            //foreach(var word in words)
            //{
            //    if (word.Length > longestWord.Length)
            //    {
            //        longestWord = word;
            //    }
            //}
            //Console.WriteLine("Longest word in the sentence is:" + longestWord);

            //---------------------------------------------------------------------------
                                                               //count vowels
            //string text = "Akhila patil";
            //int vowels = 0;
            //int constants = 0;
            //foreach(char c in text.ToLower())
            //{
            //    if ("aieou".Contains(c))
            //    {
            //        vowels++;
            //    }
            //    else if(char.IsLetter(c))
            //    {
            //        constants++;
            //    }
            //}
            //Console.WriteLine($"Vowels:{vowels} Constants:{constants}");

            //------------------------------------------------------------------

                                                                           //count repeated word
            //Console.WriteLine("Enter a sentence:");
            //string input = Console.ReadLine();

            //var wordCounts = CountWordRepetition(input);

            //Console.WriteLine("\nRepeated words and their counts:");
            //foreach (var item in wordCounts)
            //{
            //    Console.WriteLine($"{item.Key}:{item.Value}");
            //}
        }

        //static Dictionary<string, int> CountWordRepetition(string text)
        //{

            //var words = text.ToLower().Split(' ');

            
            //Dictionary<string, int> wordCount = new Dictionary<string, int>();

            //foreach (string word in words)
            //{
            //    if (wordCount.ContainsKey(word)) 
            //    {
            //        wordCount[word]++;
            //    }
            //    else 
            //    {
            //        wordCount[word] = 1;
            //    }
            //}

            //return wordCount;
        //}
    }
}
