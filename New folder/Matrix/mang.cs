using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class mang
    {
        public int[,] createMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0);i++)
            {
                for(int j =0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10, 90);                  
                }
            }
            return matrix;
        }

        public int sumEven(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }

        public void printMatrix(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string resultstr = "";

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                                       
                        resultstr+=$"{matrix[i,j]} ";                   
                }
                Console.WriteLine(resultstr);
            }
        }

        public int sum2(int[,] matrix)          
        {
            int sum = 0;
           for(int i=0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }

        public int sum3(int[,] matrix)
        {
            int sum = 0;
            for(int i =0; i< matrix.GetLength(0); i++)
            {
                for(int j = matrix.GetLength(1) -i-1; j <matrix.GetLength(1) -i ;j++)
                {
                    sum += matrix[i,j];
                }
            }
            return sum;
        }

        public int sum4(int[,] matrix)
        {
           int sum = 0;
            for(int i =0; i<=0; i++)
            {
                for(int j=0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i,j];
                }
            }
            return sum;
        }

        public void triangleUnder(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string triangle = "";

                for (int j = 0; j <=i;j++)
                {
                    triangle +=$"{matrix[i,j]}\t";                   
                }                
                Console.WriteLine(triangle);
            }
            
        }     
        public void triangleTop(int[,] matrix)
        {
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string triangletop = "";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j >= i)
                    {
                        triangletop += $"{matrix[i, j]}\t";
                    }
                    else
                    {
                        triangletop += $"\t";
                    }                  
                }
                Console.WriteLine(triangletop);
            }
           
        }
    }
}