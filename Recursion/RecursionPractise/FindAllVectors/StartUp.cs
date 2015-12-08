namespace StartUp
{
    using System;
    using RecursionPractiseLibraly.Combinations;
    using System.Diagnostics;
    using RecursionPractiseLibraly.QeenProblem;
    using RecursionPractiseLibraly.Labirinth;

    public class StartUp
    {
        static void Main()
        {
            
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            //Task 1 from homework
            //int n = 5;
            //int k = 3;
            //Combinations allVectors = new Combinations();
            //allVectors.GenerateVectors(new int[k], n);

            //Task 2 from homework
            int n = 3;
            int k = n;
            Combinations allCombinationsWithDuplex = new Combinations();
            allCombinationsWithDuplex.GenerateAllCombinationsWithDuplex(new int[k], 1, n);

            //Task 3 from homework
            //int n = 6;
            //int k = 2;
            //Combinations allCombinationsWithoutDuplex = new Combinations();
            //allCombinationsWithoutDuplex.GenerateAllCombinationsWithoutDuplex(new int[k], 1, n);

            //Task 11 Qeen problem 
            //int size = 12;

            //QueenProblem qeenProblem = new QueenProblem(size);
            //qeenProblem.SolveQueenProblem();

            //FindAllPathsInLabirinth
           // Labirinth labirinth = new Labirinth();
            //labirinth.FindAllPathsInLabirinth(0, 0);

            

           // stopwatch.Stop();

           // Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

            //Task 1 print on console
            //Console.WriteLine(allVectors);

            //Task 2 print on console
            Console.WriteLine(allCombinationsWithDuplex);

            //Task 3 print on console
            //Console.WriteLine(allCombinationsWithoutDuplex);

            //Task 11 print on console
            //Console.WriteLine(qeenProblem.count);
        }
    }
}
