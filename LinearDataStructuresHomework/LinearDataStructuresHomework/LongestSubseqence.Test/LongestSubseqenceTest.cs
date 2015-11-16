namespace LongestSubseqence.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using LongestSubsequence;
    using System.Collections.Generic;

    [TestClass]
    public class LongestSubseqenceTest
    {
        [TestMethod]
        public void CheckIfMethodCountsLongestSubseqenceCorrectly()
        {
            LongestSubsequence longestSubseqence = new LongestSubsequence();

            longestSubseqence.SequenceOfIntegers.Add(3);
            longestSubseqence.SequenceOfIntegers.Add(3);
            longestSubseqence.SequenceOfIntegers.Add(2);
            longestSubseqence.SequenceOfIntegers.Add(4);
            longestSubseqence.SequenceOfIntegers.Add(4);
            longestSubseqence.SequenceOfIntegers.Add(4);

            Assert.AreEqual(3, longestSubseqence.FindLongestSubsequence());
        }
    }
}
