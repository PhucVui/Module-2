using System;
using System.Collections.Immutable;

namespace FindAndSort
{
    class Program
    {
        public static Array ArrCls = new Array();
        public static int[] array;
        public static void Menu()
        {
            Console.WriteLine("1.Create Array");
            Console.WriteLine("2.Check SymmetryArray");
            Console.WriteLine("3.Sort Array");
            Console.WriteLine("4.Find Array");
            Console.WriteLine("5.Exit");          
        }

        public static void Create()
        {
            array = new int[0];
            Console.WriteLine($"Enter size:");
            int n = Convert.ToInt32(Console.ReadLine());
            array = ArrCls.CreateArray(n);
            ArrCls.PrintArray(array);
        }

        static void CheckSymmetryArray()
        {          
            Console.WriteLine($"Array Is {(!ArrCls.IsSymmetryArray(array) ? "Not" : "")} Symmetry");
        }

        static void SortArray()
        {   
            ArrCls.SelectionSort(array);
            ArrCls.PrintArray(array);
        }

         public static void FindArray()
        {
            if (ArrCls.CheckSort(array))
            {
                Console.WriteLine($"Enter number to find:");
                int num = int.Parse(Console.ReadLine());
                int index = ArrCls.Find(array, num);
                if (index == -1)
                {
                    Console.WriteLine("not found");
                }
                else
                {
                    Console.WriteLine($"found at: {index}");
                }
            }
            else
            {
                Console.WriteLine("not yet sort");
            }           
        }

        public static  void Main()
        {
            do
            {
                Menu();
                int choice = int.Parse(Console.ReadLine());
                if(choice == 5)
                {
                    break;
                }
                switch(choice)
                {
                    case 1: Create();                       
                        break;
                    
                    case 2: CheckSymmetryArray();                        
                        break;
                    
                    case 3: SortArray();                      
                        break;
                    
                    case 4: FindArray();
                        break;
                }               
            } while (true);
        }


    }    
}
