namespace Task3
{
    //Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.
    using System;
    using System.Collections.Generic;

    public class BubbleSort
    {
        static void Main()
        {
            List<int> sequenceOfIntegers = new List<int>();

            while (true)
            {
                string nextValue = Console.ReadLine();

                if (nextValue == String.Empty)
                {
                    break;
                }

                sequenceOfIntegers.Add(int.Parse(nextValue));
            }

            //BubbleSort
            int count = sequenceOfIntegers.Count;
            int substitutor = 0;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (sequenceOfIntegers[j] > sequenceOfIntegers[j + 1])
                    {
                        substitutor = sequenceOfIntegers[j];
                        sequenceOfIntegers[j] = sequenceOfIntegers[j + 1];
                        sequenceOfIntegers[j + 1] = substitutor;
                    }
                }
            }

            foreach (var item in sequenceOfIntegers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
