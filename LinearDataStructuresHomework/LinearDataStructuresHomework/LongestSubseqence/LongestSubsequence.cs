namespace LongestSubsequence
{
    //Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
    //
    //Write a program to test whether the method works correctly.

    using System.Collections.Generic;

    public class LongestSubsequence
    {
        private List<int> sequenceOfIntegers;

        public LongestSubsequence()
        {
            sequenceOfIntegers = new List<int>();
        }

        public List<int> SequenceOfIntegers
        {
            get
            {
                return this.sequenceOfIntegers;
            }

            set
            {
                this.sequenceOfIntegers = value;
            }
        }

        public int FindLongestSubsequence()
        {
            int counterForRepeatingNumbers = 1;
            int longestSubseqence = 1;
            int seqenceLength = sequenceOfIntegers.Count;


            for (int i = 0; i < seqenceLength - 1; i++)
            {
                if (sequenceOfIntegers[i] == sequenceOfIntegers[i + 1])
                {
                    counterForRepeatingNumbers++;
                    if (counterForRepeatingNumbers > longestSubseqence)
                    {
                        longestSubseqence = counterForRepeatingNumbers;
                    }
                }
                else
                {
                    counterForRepeatingNumbers = 1;
                }
            }

            return longestSubseqence;
        }

    }
}

