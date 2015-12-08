namespace ConsoleApplication2
{
    using System;
    using System.Collections.Generic;
    public class Words
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            int counter = 0;
            //make pref-suf pairs
            //foreach pair count each of the strings and multyply them
            //combine them in one result
            //add the count of the whole word in the text

            Dictionary<string, string> prefixSuffixPairs = new Dictionary<string, string>();

            for (int i = 1; i < word.Length; i++)
            {
                prefixSuffixPairs[word.Substring(0, i)] = word.Substring(i, word.Length - i);
            }

            foreach (var pair in prefixSuffixPairs)
            {
                int prefixCount = (text.Length - text.Replace(pair.Key, "").Length) / pair.Key.Length;
                int sufixCount = (text.Length - text.Replace(pair.Value, "").Length) / pair.Value.Length;
                counter += prefixCount * sufixCount;
            }
            // somewhere from google i copied this regex to find occurences of string in text :)
            counter +=  (text.Length - text.Replace(word, "").Length) / word.Length;
            
            Console.WriteLine(counter);
        }
    }
}
