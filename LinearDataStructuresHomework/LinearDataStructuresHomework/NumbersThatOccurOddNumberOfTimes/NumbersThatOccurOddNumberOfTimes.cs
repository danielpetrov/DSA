namespace NumbersThatOccurOddNumberOfTimes
{
    //Write a program that removes from given sequence all numbers that occur odd number of //times.
    //
    //Example:
    //    { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}

    using System;
    using System.Collections.Generic;

    class NumbersThatOccurOddNumberOfTimes
    {
        static void Main(string[] args)
        {
            List<int> someSequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            HashSet<int> someHashSet = new HashSet<int>();

            for (int i = 0; i < someSequence.Count; i++)
            {
                someHashSet.Add(someSequence[i]);
            }
           
            foreach (var number in someHashSet)
            {
                int counterForMatches = 0;
                for (int i = 0; i < someSequence.Count; i++)
                {
                    if (someSequence[i] == number)
                    {
                        counterForMatches++;
                    }
                }

                if (counterForMatches % 2 == 1)
                {
                    someSequence.RemoveAll(item => item == number);
                }
            }

            foreach (var number in someSequence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
