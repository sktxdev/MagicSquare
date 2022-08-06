using System;

namespace MagicSquare
{
    public class MagicSquare 
    {
        private int size;
        private int[,] grid;

        public MagicSquare(int size)
        {
            this.size = size;
            this.grid = new int[size, size];
        }

        public void InitializeGrid() 
        {
            for (int row =  0; row  < size; row++) 
            {
                for (int col = 0; col < size; col++) 
                {
                    grid[row, col] = 0;
                }
                
            }

        }

        public void Generate()
        {

            int nextRow = 0;
            int nextCol = size / 2;

            for (int n = 1; n <= size*size; n++)
            {

                grid[nextRow, nextCol] = n;

                nextCol++;
                nextRow--;
                if (nextRow < 0) 
                {
                    nextRow = size-1;
                }
                if (nextCol  >= size) {
                    nextCol = 0;
                }
                if (grid[nextRow, nextCol] != 0)
                {
                    nextRow+=2;
                    if (nextRow >= size)
                    {
                        nextRow = 0;
                    }
                    nextCol--;
                    if (nextCol < 0) 
                    {
                        nextCol = size-1;
                        nextRow++;
                    }
                }
            }
        }

        public void PrintGrid()
        {
            int[] colTotal = new int[size];
            int rowTotal = 0;

            for (int row= 0; row < size; row++) {
                for (int col = 0; col  < size; col++) {
                    var num = $"{grid[row,col],7:##0}";
                    rowTotal += grid[row, col];
                    colTotal[row] += grid[row, col]; 
                    Console.Write(num);
                }
                // Uncomment this line to reveal totals
                // Console.Write($"{rowTotal,7:###0}");
                rowTotal = 0;
                Console.WriteLine("\n");
            }
            // Uncomment next 3 lines to reveal totals for each column
            // for (int i = 0; i<size; i++)
            // {
            //     Console.Write($"{colTotal[i],7:###0}");
            // }
        }
    }

}
