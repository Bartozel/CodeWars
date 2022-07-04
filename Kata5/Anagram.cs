using System;
using System.Collections.Generic;

/* 
 * https://www.codewars.com/kata/523a86aa4230ebb5420001e1/train/csharp
 * https://en.wikipedia.org/wiki/Anagram
 *  What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:

 * 'abba' & 'baab' == true

 * 'abba' & 'bbaa' == true

 * 'abba' & 'abbba' == false

 * 'abba' & 'abca' == false

 * Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:

 * anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']

 * anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']

 * anagrams('laser', ['lazing', 'lazy', 'lacer']) => []

 * Note for Go
 * For Go: Empty string slice is expected when there are no anagrams found.
*/

namespace CodeWars
{
    public static class Anagram 
    {
        public static void Test()
        {
            Anagrams("abba", new[] { "aabb", "abcd", "bbaa", "dada" }.ToList()).ConsolePrint();
            Anagrams("racer", new[] { "crazer", "carer", "racar", "caers", "racer" }.ToList()).ConsolePrint();
            Anagrams("laser", new[] { "lazing", "lazy", "lacer" }.ToList()).ConsolePrint();

        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> ans = new List<string>();
            var wordOcurences = GetCharOcurences(word);
            foreach (var w in words)
            {
                var wOcurences = GetCharOcurences(w);
                if (Enumerable.SequenceEqual(wordOcurences, wOcurences))
                    ans.Add(w);
            }

            return ans;
        }

        public static IEnumerable<(char Char, int Count)> GetCharOcurences(string word)
        {
            IEnumerable<(char Char, int Count)> result;
            if (!string.IsNullOrEmpty(word))
            {
                result = word.GroupBy(c => c)
                    .Select(c => (Char: c.Key, Count: c.Count()))
                    .OrderBy(x=>x.Char);
            }
            else
                result = new List<(char Char, int Count)>();


            return result;
        }
    }
}
