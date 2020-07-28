using System;
using System.Collections.Generic;
using System.Text;

namespace FindAndSort
{
    class Array
    {
        public int[] CreateArray(int size)
        {
            Random random = new Random();
            int[] Array = new int[size];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(30, 60);
            }
            return Array;
        }

        public void PrintArray(int [] Array)
        {
            string array = "";

            for (int i = 0; i < Array.Length; i++)
            {
                array+= $"{Array[i]}\t";                
            }
            Console.WriteLine(array);
            }
            

        public bool IsSymmetryArray(int [] newArray)
        {
            for(int i =0; i < newArray.Length; i++)
            {
                if(newArray[i] != newArray[newArray.Length -i -1])
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckSort(int[] arr)
        {
            for (int i=0;i<arr.Length-1;i++)
            {
                if (arr[i]>=arr[i+1])
                {
                    return false;
                }
            }
            return true;
        }

        public void SelectionSort(int [] Array1)
        {
            for(int i =0; i < Array1.Length-1; i++)
            {
                int min = Array1[i];
                int pos = i;
                for(int j=i+1; j< Array1.Length; j++)
                {
                   if(Array1[j]<min)
                    {
                        min = Array1[j];
                        pos = j;
                    }                    
                }
                int temp;
                temp = Array1[i];
                Array1[i] = Array1[pos];
                Array1[pos] = temp;
            }
        }

        public int Find(int[] Array, int key) 
        {
            int First = 0;
            int Last = Array.Length - 1;
            while (Last >= First) 
            {
                int mid = (First + Last) / 2;

                if (key < Array[mid])
                {
                    Last = mid - 1;  
                }
                else if(key == Array[mid])
                {
                    return mid;
                }
                else
                {
                    First = mid + 1; 
                }
            } return -1;           
        }
     }
}
