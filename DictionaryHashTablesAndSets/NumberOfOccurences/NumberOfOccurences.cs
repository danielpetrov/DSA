namespace NumberOfOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumberOfOccurences
    {
        public static void Main()
        {
            List<double> someSequence = new List<double>() { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            //HashSet<int> someHashSet = new HashSet<int>();
            Dictionary<double, string> howManyTimesAllOccur = new Dictionary<double, string>();

            //for (int i = 0; i < someSequence.Count; i++)
            //{
            //    someHashSet.Add(someSequence[i]);
            //}
            var someHashSet = someSequence.Distinct();
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
