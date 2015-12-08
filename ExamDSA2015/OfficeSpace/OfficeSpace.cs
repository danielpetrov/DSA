using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSpace
{
    public class OfficeSpace
    {
        static int n;
        static int maxSum = 0;
        static int[] allTasks;
        static List<int[]> taskDependancies = new List<int[]>();
        static int sumFromAllTasks = 0;
        static int operationsCounter = 0;

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());

            allTasks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

             for (int i = 0; i < n; i++)
            {
                taskDependancies.Add(Console.ReadLine().Split(' ').Select(int.Parse).ToArray()); 
            }

            sumFromAllTasks = allTasks.Sum();
            solve(taskDependancies);

            Console.WriteLine(sumFromAllTasks);
        }
        public static void solve(List<int[]> taskDependancies)
        {
            
            for (int i = 0; i < n; i++)
            {
                int currentSum = 0;
                ////add from task
                ////check if task has dependancies
                //add from task from dep - but max
                //check if task from dep has dep while task from dep has no dep - but max
                currentSum += allTasks[i];
                if (taskDependancies != null)
                {
                    DFS(i, currentSum);
                }
            }
        }

        //DFS recursive
        public static void DFS(int taskIndex, int sum)
        {
             if (operationsCounter > 100000)
             {
                  maxSum = sumFromAllTasks;
                  return;
             }

             if (taskDependancies[taskIndex][0] == 0)
             {
                maxSum = Math.Max(sum, maxSum);
                return;
             }

            for (int i = 0; i < taskDependancies[taskIndex].Count(); i++)
            {
               DFS(taskDependancies[taskIndex][i] - 1, sum + allTasks[taskDependancies[taskIndex][i] - i]);
            }
        }
    }
}
