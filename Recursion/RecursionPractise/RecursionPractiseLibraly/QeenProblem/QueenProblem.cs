namespace RecursionPractiseLibraly.QeenProblem
{
    public class QueenProblem
    {
        public int count;

        private int size;

        private bool[,] board;

        private int[,] isOccupied;

        public QueenProblem(int size)
        {
            this.count = 0;
            this.size = size;
            this.board = new bool[size, size];
            this.isOccupied = new int[size, size];
        }
        public void SolveQueenProblem(int columnIndex = 0)
        {
            if (columnIndex == this.size)
            {
                count++;
                return;
            }

            for (int rowIndex = 0; rowIndex < this.size; rowIndex++)
            {
                if (this.isOccupied[rowIndex, columnIndex] == 0)
                {
                    this.board[rowIndex, columnIndex] = true;
                    MarkOccupied(1, rowIndex, columnIndex);

                    SolveQueenProblem(columnIndex + 1);

                    this.board[rowIndex, columnIndex] = false;
                    MarkOccupied(-1, rowIndex, columnIndex);
                }
            }
        }

        public void MarkOccupied(int value, int rowIndex, int colIndex)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (colIndex + i < this.size)
                {
                    this.isOccupied[rowIndex, colIndex + i] += value;
                }

                if (rowIndex + i < this.size)
                {
                    this.isOccupied[rowIndex + i, colIndex] += value;
                }

                if (rowIndex + i < this.size
                    && colIndex + i < this.size)
                {
                    this.isOccupied[rowIndex + i, colIndex + i] += value;
                }

                if (rowIndex - i >= 0
                    && colIndex + i < this.size)
                {
                    this.isOccupied[rowIndex - i, colIndex + i] += value;
                }
            }
        }
    }
}
