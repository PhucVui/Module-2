using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix2
{
    class matrix2
    {
        public int[,] CreateMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(10, 40);
                }
            }
            return matrix;
        }

        public void PrintMatrix(int[,] matrix)
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

        public int[,] SumMatrix(int[,] matrix, int[,] matrix2)
        {
            int[,] resultMatrix = new int[matrix.GetLength(0), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = matrix[i, j] + matrix2[i, j];
                }
            }
            return resultMatrix;
        }

        public int[,] multiplyMatrix (int[,] matrix, int[,] matrix2)
        {
            int[,] multiplymatrix = new int[matrix.GetLength(0), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    multiplymatrix[i, j] = matrix[i, j] * matrix2[i, j];
                }
            }
            return multiplymatrix;
        }


    } 

}
