namespace OddOccurencesOfString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurencesOfString
    {
        public static void Main()
        {
            List<string> someStringSequence = new List<string>() { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            var someHashSet = someStringSequence.Distinct();

            List<string> OddOccurences = new List<string>();

            foreach (var stringValue in someHashSet)
            {
                int counterForMatches = 0;
                for (int i = 0; i < someStringSequence.Count; i++)
                {
                    if (someStringSequence[i] == stringValue)
                    {
                        counterForMatches++;
                    }
                }

                if (counterForMatches % 2 == 1)
                {
                    OddOccurences.Add(stringValue);
                }
            }

            foreach (var stringValue in OddOccurences)
            {
                Console.WriteLine(stringValue);
            }
        }
    }
}
