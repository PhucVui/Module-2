using System;

namespace Matrix3
{
    class Program
    {
        static void Main(string[] args)
        {
/*            Console.WriteLine("Enter row:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column:");
            int col = Convert.ToInt32(Console.ReadLine());*/

            matrix3 newMatrix = new matrix3();

           /* int[,] matrix3 = newMatrix.CreateMatrix(row, col);
            newMatrix.PrintMatrix3(matrix3);

            Console.WriteLine("Hien thi nhung phan tu chia het cho 5 :");
            newMatrix.multipleOf5(matrix3);*/

            int[,] matrix4 = newMatrix.CreateMatrix(3, 4);
            newMatrix.PrintMatrix3(matrix4);
            Console.WriteLine("---------------------------------------");
            newMatrix.newMatrix1(matrix4);
        }
    }
}
