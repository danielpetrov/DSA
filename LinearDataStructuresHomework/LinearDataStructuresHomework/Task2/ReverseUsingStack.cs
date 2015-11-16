namespace ReadSequenceOfIntegersFromConsole
{
    //Write a program that reads N integers from the console and reverses them using a stack.
    //
    //Use the Stack<int> class.
    using System;
    using System.Collections.Generic;

    public class Task2
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Stack<int> stackOfInts = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stackOfInts.Push(int.Parse(Console.ReadLine()));
            }

            List<int> reversedListOfInts = new List<int>();

            for (int i = 0; i < n; i++)
            {
                reversedListOfInts.Add(stackOfInts.Pop());
            }

            foreach (var item in reversedListOfInts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
