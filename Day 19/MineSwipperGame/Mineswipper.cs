using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSwipperGame
{
    internal class Mineswipper
    {
        private const int size = 5;
        private const int Mines = 5;
        private CellState[,] grid = new CellState[size,size];
        private bool[,] opened = new bool[size, size];
        private Random random = new Random();

        public Mineswipper()
        {
            InitGrid();
        }
        private void InitGrid()
        {
            for (int i = 0; i < Mines; i++)
            {
                int x, y;
                do
                {
                    x = random.Next(size);
                    y = random.Next(size);
                } while (grid[x, y] == CellState.Mine);
                grid[x, y] = CellState.Mine;
            }
        }
        public void play()
        {
            while (true)
            {
                PrintBoard();
                Console.Write("Enter the row and column value:");
                var input = Console.ReadLine().Split();
                int row = int.Parse(input[0]) - 1;
                int col = int.Parse(input[1]) - 1;
                if (grid[row, col] == CellState.Mine)
                {
                    Console.WriteLine("Game over You hit a mine try again!!!!!");
                    break;
                }
                opened[row, col] = true;

            }
        }
        private void PrintBoard()
        {
            Console.Clear();
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (opened[i, j])
                    {
                        if (grid[i, j] == CellState.Mine)
                        {
                            Console.WriteLine('*' + " ");
                        }
                        else
                        {
                            Console.WriteLine(((int)grid[i, j]) + " ");
                        }
                        
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
       

    }
}
