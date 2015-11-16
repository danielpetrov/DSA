using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionPractiseLibraly.Combinations
{
    public class Combinations
    {
        private IList<int[]> listOfCombinations;
        
        public Combinations()
        {
            this.ListOfCombinations = new List<int[]>();
        }

        public IList<int[]> ListOfCombinations
        {
            get
            {
                return this.listOfCombinations;
            }

            private set
            {
                listOfCombinations = value;
            }
        }

        public void GenerateVectors(int[] vector, int vectorType, int currentIndex = 0)
        {
            if (currentIndex == vector.Length)
            {
                var newIntArray = new int[vector.Length];
                vector.CopyTo(newIntArray, 0);
                this.ListOfCombinations.Add(newIntArray);

                return;
            }

            for (int i = 0; i <= vectorType; i++)
            {
                vector[currentIndex] = i;
                GenerateVectors(vector, vectorType, currentIndex + 1);
            }
        }

        public void GenerateAllCombinationsWithDuplex(int[] vector, int startingNumberFromSet, 
            int endingNumberFromSet, int currentIndex = 0)
        {
            if (currentIndex == vector.Length)
            {
                var newIntArray = new int[vector.Length];
                vector.CopyTo(newIntArray, 0);
                this.ListOfCombinations.Add(newIntArray);

                return;
            }

            for (int i = startingNumberFromSet; i <= endingNumberFromSet; i++)
            {
                vector[currentIndex] = i;
                GenerateAllCombinationsWithDuplex(vector, startingNumberFromSet, endingNumberFromSet, currentIndex + 1);
            }
        }

        public void GenerateAllCombinationsWithoutDuplex(int[] vector, int startingNumberFromSet,
            int endingNumberFromSet, int currentIndex = 0)
        {
            if (currentIndex == vector.Length)
            {
                var newIntArray = new int[vector.Length];
                vector.CopyTo(newIntArray, 0);
                this.ListOfCombinations.Add(newIntArray);

                return;
            }

            for (int i = startingNumberFromSet; i <= endingNumberFromSet; i++)
            {
                vector[currentIndex] = i;
                GenerateAllCombinationsWithoutDuplex(vector, i + 1, endingNumberFromSet, currentIndex + 1);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var combination in this.ListOfCombinations)
            {
                foreach (var number in combination)
                {
                    result.Append(number);
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
