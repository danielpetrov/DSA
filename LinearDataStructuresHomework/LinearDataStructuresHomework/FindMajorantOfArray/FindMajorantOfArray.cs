namespace FindMajorantOfArray
{
    using System;
    using System.Collections.Generic;
    // * The majorant of an array of size N is a value that occurs in it at least N/2 + 1 //times.
    //
    //  Write a program to find the majorant of given array(if exists).
    // Example:
    //     {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3

    public class FindMajorantOfArray
    {
        static void Main()
        {
            List<int> someSequence = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            HashSet<int> someHashSet = new HashSet<int>();
            bool theMajorantExist = false;
            int theMajorant = 0;

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

                    if (counterForMatches >= someSequence.Count / 2 + 1)
                    {
                        theMajorant = someSequence[i];
                        theMajorantExist = true;
                    }
                }
            }

            if (theMajorantExist)
            {
                Console.WriteLine("The majorant is " + theMajorant);
            }
            else
            {
                Console.WriteLine("There is no majorant");
            }
        }
    }
}
