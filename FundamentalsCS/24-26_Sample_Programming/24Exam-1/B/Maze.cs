using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._24_26_Sample_Programming._24Exam_1.B
{
    public class Maze
    {
        //
        private const string InputFileName = "Problem2.in";
        private const string OutputFileName = "Problem2.out";        //

        private char[,] maze;
        private int size;
        private Cell startCell = null;

        public void ReadFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                //Read the maze size and create the maze
                this.size = int.Parse(reader.ReadLine());
                this.maze = new char[this.size, this.size];

                //Read the maze cells from the file
                for (int row = 0; row < this.size; row++)
                {
                    string line = reader.ReadLine();
                    for (int col = 0; col < this.size; col++)
                    {
                        this.maze[row, col] = line[col];
                        if (line[col] == '*')
                        {
                            this.startCell = new Cell(row, col, 0);
                        }
                    }
                }
            }
        }

        public int FindShortestPath()
        {
            if (this.startCell == null)
            {
                //Start cell is missing -> no path
                return -1;
            }
            //Queue for traversing the cells in the maze
            Queue<Cell> visitedCells = new Queue<Cell>();
            VisitCell(visitedCells, this.startCell.Row, this.startCell.Column, 0);

            // Perform Breadth-First Search (BFS)
            while (visitedCells.Count > 0)
            {
                Cell currentCell = visitedCells.Dequeue();
                int row = currentCell.Row;
                int column = currentCell.Column;
                int distance = currentCell.Distance;
                if ((row == 0) || (row == size -1) || (column == 0) || (column == size -1))
                {
                    //We are at the maze border
                    return distance + 1;
                }
                VisitCell(visitedCells, row, column + 1, distance + 1);
                VisitCell(visitedCells, row, column - 1, distance + 1);
                VisitCell(visitedCells, row + 1, column, distance + 1);
                VisitCell(visitedCells, row - 1, column, distance + 1);
            }
            //We didn't reach any cell at the maze border -> no path
            return -1;
        }

        private void VisitCell(Queue<Cell> visitedCells, int row, int column, int distance)
        {
            if (this.maze[row, column] != 'x')
            {
                //The cell is free --> visit it
                maze[row, column] = 'x';
                Cell cell = new Cell(row, column, distance);
                visitedCells.Enqueue(cell);
            }
        }

        public void SaveResult(String fileName, int result)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("The shortest way is: "+result);
            }
        }
    }
}
