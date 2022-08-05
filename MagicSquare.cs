using System;

namespace MagicSquare
{
    public class MagicSquare 
    {
        private int size;
        private int startNumber;
        private int endNumber;
        private int[,] grid;

        public MagicSquare(int size, int startNumber)
        {
            this.size = size;
            this.startNumber = startNumber;
            this.grid = new int[size, size];
            this.endNumber = startNumber + (size*size);
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

        private int ComputeNextRow(int row, int col)
        {
            var nextRow = row++;
            if (nextRow >= size)
                nextRow = 0;
            return nextRow;
        }
        void foo(int n) {  
	    int currCol = 0;
	    int currRow = 0;
	    int row = 0;
            row--;

            currCol++; currRow--;
            if (currRow < 0) {
                currRow = size - 1;
            }
            if (currCol > size - 1) {
                currCol = 0;
            }
            if (grid[currRow, currCol] == 0) {
                grid[currRow, currCol] = n;
            }
            else {
                currRow--;
            }
        }

        private void ComputeNextCol(int row, int col)
        {
	    int currCol = 0;
	    int currRow = 0;
	    int n = 0;
            currCol++; currRow--;
            if (currRow < 0) {
                currRow = size - 1;
            }
            if (currCol > size - 1) {
                currCol = 0;
            }
            if (grid[currRow, currCol] == 0) {
                grid[currRow, currCol] = n;
            }
            else {
                currRow--;
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
                Console.Write($"{rowTotal,7:###0}");
                rowTotal = 0;
                Console.WriteLine("\n");
            }
            for (int i = 0; i<size; i++)
            {
                Console.Write($"{colTotal[i],7:###0}");
            }
        }
    }

}
