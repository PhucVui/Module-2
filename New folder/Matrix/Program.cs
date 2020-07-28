using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int size = Convert.ToInt32(Console.ReadLine());

            mang newmang = new mang();

            int[,] matrix = newmang.createMatrix(size);
            newmang.printMatrix(matrix);

            //Console.WriteLine(newmang.sumEven(matrix));
            //Console.WriteLine(newmang.sum2(matrix));
            //Console.WriteLine(newmang.sum3(matrix));
            //Console.WriteLine(newmang.sum4(matrix));


            /*newmang.triangleUnder(matrix);*/
            newmang.triangleTop(matrix);

        }

    }
}
