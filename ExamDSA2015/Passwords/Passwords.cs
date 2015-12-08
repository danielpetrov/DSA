namespace Password
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PassWord
    {

        static IList<int[]> listOfCombinations;

        static List<int> passArray = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        static int[] minNumberArray;
        static int[] maxNumberArray;
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string shifts = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            int minNumber = 1;
            int maxNumber = 10;
            listOfCombinations = new List<int[]>();
            minNumberArray = new int[n];
            maxNumberArray = new int[n];
            minNumberArray[0] = minNumber;
            maxNumberArray[0] = maxNumber;

            for (int i = 1; i <= shifts.Length; i++)
            {
                if (shifts[i - 1] == '>')
                {
                    minNumber++;//+-1
                    maxNumber = 10;
                }
                else if (shifts[i - 1] == '<')
                {
                    minNumber = 1;
                    maxNumber--;
                }
                else if (shifts[i] == '=')
                {
                    //password [i+1] == password [i]
                }
                minNumberArray[i] = minNumber;
                maxNumberArray[i] = maxNumber;
            }
            GenerateAllCombinationsWithDuplex(new int[n], minNumberArray[0], maxNumberArray[0]);



            Console.WriteLine(Hi());

        }
        public static void GenerateAllCombinationsWithDuplex(int[] vector, int startingNumberFromSet,
            int endingNumberFromSet, int currentIndex = 0)
        {
            if (currentIndex == vector.Length - 1)
            {
                var newIntArray = new int[vector.Length];
                vector.CopyTo(newIntArray, 0);
                listOfCombinations.Add(newIntArray);

                return;
            }

            for (int i = startingNumberFromSet; i <= endingNumberFromSet; i++)
            {
                vector[currentIndex] = passArray[i - 1];
                GenerateAllCombinationsWithDuplex(vector, minNumberArray[currentIndex], maxNumberArray[currentIndex], currentIndex + 1);
            }
        }

        public static string Hi()
        {
            StringBuilder result = new StringBuilder();

            foreach (var combination in listOfCombinations)
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