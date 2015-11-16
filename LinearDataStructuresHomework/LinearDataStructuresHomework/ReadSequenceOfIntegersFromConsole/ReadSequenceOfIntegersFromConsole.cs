namespace ReadSequenceOfIntegersFromConsole
{
    //Write a program that reads from the console a sequence of positive integer numbers.
    //
    //The sequence ends when empty line is entered.
    //Calculate and print the sum and average of the elements of the sequence.
    //Keep the sequence in List<int>.

    using System;
    using System.Collections.Generic;

    public static class ReadSequenceOfIntegersFromConsole
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

            int sum = 0;

            foreach (var number in sequenceOfIntegers)
            {
                sum += number;
            }

            double average = sum / sequenceOfIntegers.Count;

            Console.WriteLine("SUM " + sum);
            Console.WriteLine("AVERAGE " + average);
        }
    }
}
