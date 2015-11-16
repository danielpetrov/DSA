namespace RemoveAllNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    //Write a program that removes from given sequence all negative numbers.
    public class RemoveAllNegativeNumbers
    {
        static void Main()
        {
            List<int> someSeqence = new List<int>() { -3, 2, -2, 3, 4, 5, -2, -1, -3 };

            bool hasNegatives;

            do
            {
                hasNegatives = false;

                for (int i = 0; i < someSeqence.Count; i++)
                {
                    if (someSeqence[i] < 0)
                    {
                        someSeqence.RemoveAt(i);
                        hasNegatives = true;
                        break;
                    }
                }

            } while (hasNegatives);

            foreach (var number in someSeqence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
