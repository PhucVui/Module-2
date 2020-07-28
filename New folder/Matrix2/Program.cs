using System;

namespace Matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int size = Convert.ToInt32(Console.ReadLine());
            
            matrix2 newMatrix = new matrix2();

            int[,] matrix = newMatrix.CreateMatrix(size);
            newMatrix.PrintMatrix(matrix);           
            Console.WriteLine("----------------------------\n");

            int[,] matrix2 = newMatrix.CreateMatrix(size);
            newMatrix.PrintMatrix(matrix2);
            Console.WriteLine("----------------------------\n");

            newMatrix.PrintMatrix(newMatrix.SumMatrix(matrix, matrix2));
            Console.WriteLine("----------------------------\n");
            newMatrix.PrintMatrix(newMatrix.multiplyMatrix(matrix, matrix2));
        }
    }
}
