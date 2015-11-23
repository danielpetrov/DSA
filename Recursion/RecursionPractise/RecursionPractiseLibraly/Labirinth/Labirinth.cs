namespace RecursionPractiseLibraly.Labirinth
{
    using System;
    using System.Collections.Generic;

    public class Labirinth
    {
        static char[,] lab =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };

        private int counter;

        private Dictionary<int, List<char>> allPaths;

        public Labirinth()
        {
            this.counter = 0;
        }

        public Dictionary<int, List<char>> AllPaths
        {
            get
            {
                return this.allPaths;
            }

            set
            {
                this.allPaths = value;
            }
        }

        public void FindAllPathsInLabirinth(int rowIndex, int colIndex)
        {
            //check if next is avalable (l,u,r,d)
            //move to next
            //left - colIndex - 1, up - rowIndex - 1, right - colIndex + 1, down - rowIndex + 1 
            //mark this as used
            //move to next
            //return
            //mark this as avalable
            if (lab[rowIndex, colIndex] == 'e')
            {
                this.counter++;
                return;
            }

            MarkUsed(rowIndex, colIndex, '+');
            if (IsAvalable(rowIndex, colIndex - 1))//left
            {
                FindAllPathsInLabirinth(rowIndex, colIndex - 1);
            }
            if (IsAvalable(rowIndex - 1, colIndex))//up
            {
                FindAllPathsInLabirinth(rowIndex - 1, colIndex);
            }
            if (IsAvalable(rowIndex, colIndex + 1))//right
            {
                 FindAllPathsInLabirinth(rowIndex, colIndex + 1);
            }
            if (IsAvalable(rowIndex + 1, colIndex))//down
            {
                FindAllPathsInLabirinth(rowIndex + 1, colIndex);
            }
            MarkUsed(rowIndex, colIndex, ' ');
        }

        private void MarkUsed(int rowIndex, int colIndex, char value)
        {
            lab[rowIndex, colIndex] = value;
        }

        private bool IsAvalable(int rowIndex, int colIndex)
        {
            if ( IsInRange(rowIndex, colIndex) && (lab[rowIndex, colIndex] == ' ' || lab[rowIndex, colIndex] == 'e'))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        private bool IsInRange(int rowIndex, int colIndex)
        {
            if(rowIndex >= 0 && colIndex >= 0 && 
                rowIndex < lab.GetLength(0) && colIndex < lab.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
