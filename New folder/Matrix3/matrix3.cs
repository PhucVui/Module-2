using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix3
{
    class matrix3
    {
        public int[,] CreateMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];

            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(20,60);
                }
            }
            return matrix;
        }
        public void PrintMatrix3(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string matrixstr = "";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixstr += $"{matrix[i, j]}\t";
                }
                Console.WriteLine($"{matrixstr}");
            }
        }
        public void multipleOf5(int[,] matrix)
        {
            for(int i =0; i < matrix.GetLength(0); i++)
            {
                for(int j =0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] %5==0)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    else
                    {
                        Console.Write("X\t");
                    }
                }
                Console.WriteLine();
            }
        }
        public void newMatrix1(int[,] matrix)
        {
            for(int j=0; j< matrix.GetLength(1); j++)
            {
                string index = "";
                for(int i =0; i< matrix.GetLength(0); i++)
                {
                    index += $"{matrix[i, j]}\t  ";
                }
                Console.WriteLine(index);
            }          
        }
    }
}
