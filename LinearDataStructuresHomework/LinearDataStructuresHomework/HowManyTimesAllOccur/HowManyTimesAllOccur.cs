namespace HowManyTimesAllOccur
{
   //Write a program that finds in given array of integers(all belonging to the range//[0..1000]) how many times each of them occurs.
   //
   // Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
   //    2 → 2 times
   //    3 → 4 times
   //    4 → 3 times

    using System;
    using System.Collections.Generic;

    class HowManyTimesAllOccur
    {
        static void Main()
        {
            List<int> someSequence = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            HashSet<int> someHashSet = new HashSet<int>();
            Dictionary<int, string> howManyTimesAllOccur = new Dictionary<int, string>();

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

                howManyTimesAllOccur.Add(number, counterForMatches + " times");
            }

            foreach (var number in howManyTimesAllOccur)
            {
                Console.WriteLine(number);
            }
        }
    }
}
