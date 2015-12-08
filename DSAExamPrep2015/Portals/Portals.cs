using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portals
{
    public class Portals
    {

        public static char[,] matrix;
        public static bool[,] used;
        public static int maxSum = 0;

        static int MaxRow;
        const int MinRow = 0;
        static int MaxCol;
        const int MinCol = 0;

        public static void Main()
        {
            string firstRow = Console.ReadLine();
            string secondRow = Console.ReadLine();
            
            int x = (int)firstRow[0] - 48;
            int y = (int)firstRow[2] - 48;
            int r = int.Parse(secondRow.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0]);
            int c = int.Parse(secondRow.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);

            MaxRow = r - 1;
            MaxCol = c - 1;

            matrix = new char[r, c];
            used = new bool[r, c];

            for (int i = 0; i < r; i++)
            {
                string row = Console.ReadLine();

                string[] rows = row.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < c; j++)
                {
                    if (char.Parse(rows[j]) == '#')
                    {
                        used[i, j] = true;
                    }
                    matrix[i, j] = char.Parse(rows[j]);
                }
            }

            nextItem(x, y, 0);

            Console.WriteLine(maxSum);
            
        }

        public static void nextItem(int r, int c, int sum)
        {

            int value = matrix[r, c] - 48;
            
            if (!(
                ((value + r <= MaxRow) && matrix[value + r, c] != '#') ||
                ((value + c <= MaxCol) && matrix[r, value + c] != '#') ||
                ((r - value >= MinRow) && matrix[r - value, c] != '#') ||
                ((c - value >= MinCol) && matrix[r, c - value] != '#')
                ))
            {
                return;
            }

            sum += value;

            if ((!(value + r > MaxRow)) && !used[value + r, c])
            {
                used[value + r, c] = true;
                nextItem(matrix[r, c] - 48 + r, c, sum);
                used[value + r, c] = false;
            }

            if ((!(value + c > MaxCol)) && !used[r, value + c])
            {
                used[r, value + c] = true;
                nextItem(r, matrix[r, c] - 48 + c, sum);
                used[r, value + c] = false;
            }

            if ((!(r - value < MinRow)) && !used[r - value, c])
            {
                used[r - value, c] = true;
                nextItem(r - (matrix[r, c] - 48), c, sum);
                used[r - value, c] = false;
            }

            if ((!(c - value < MinCol)) && !used[r, c - value])
            {
                used[r, c - value] = true;
                nextItem(r, c - (matrix[r, c] - 48), sum);
                used[r, c - value] = false;
            }
            
            
            if (maxSum < sum)
            {
                maxSum = sum;
            }

         }
    }
}
