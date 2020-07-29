using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace CoffeeShop
{
    class Program
    {
        public static string Path = @"C:\Users\vui\source\repos\JSonFile\CoffeeShop\data2";
        public static string fileInput = "Oder.json";
        public static string billfilename = $"Bill_{DateTime.Now.ToString("ddMMyyyyhhmm")}.json";

        public static ListTable result = new ListTable();

        public static Drink Coffee = new Drink()
        {
            name = "Black Coffee",
            amount = 1,
            price = 12000
        };
        public static Drink MilkCoffee = new Drink()
        {
            name = "Milk Coffee",
            amount = 1,
            price = 15000
        };
        public static Drink Juice = new Drink()
        {
            name = "Orange Juice",
            amount = 1,
            price = 25000
        };
        public static Drink Lemonade = new Drink()
        {
            name = "Lemonade ",
            amount = 1,
            price = 22000
        };
        public static Drink Coke = new Drink()
        {
            name = "Coke",
            amount = 1,
            price = 18000

        };
        public static Drink Water = new Drink()
        {
            name = "Water",
            amount = 1,
            price = 10000

        };
        public static Drink MilkTea = new Drink()
        {
            name = "Milk Tea",
            amount = 1,
            price = 35000

        };
  
        static void Main(string[] args)
        {
            do
            {
                Menu();
                int test = MustNumBer();
                if (test == 4)                
                   break;
                
                switch(test)
                {
                    case 1:
                        ReadFile();
                        Console.WriteLine("Enter table number");
                        int num = MustNumBer();
                        Table table = new Table();
                        table.NameTable = num;
                        //kiem tra xem table da co trong tablelist chua
                        if (result.FindTable(num) == null)
                            result.listTable.Add(table);

                        else
                        {
                            DrinkMenu();
                            int check = MustNumBer();
                            AddDrinkToTable(check, num);
                        }
                        WriteFile();
                        break;

                    case 2:
                        Console.WriteLine("Enter table number would oder drink");
                        int number = MustNumBer();
                        ReadFile();
                        if (result.FindTable(number) == null)
                            Console.WriteLine("Table not exits");

                        else
                        {
                            DrinkMenu();
                            Console.WriteLine("Choice drinks");
                            int num1 = MustNumBer();
                            AddDrinkToTable(num1, number);
                        }
                        WriteFile();
                        break;

                    case 3:
                        ReadFile();
                        Console.WriteLine("Enter Table Num");
                        int num2 = MustNumBer();
                        var tb = result.FindTable(num2);
                        if (tb == null)
                            Console.WriteLine("Table not exits");

                        else
                        {
                            Bill bill = new Bill();
                            bill.drinks = tb.listDrink;
                            bill.NameTable = tb.NameTable;
                            bill.Total = tb.Total;
                            bill.dateTime = DateTime.Now;

                            using (StreamWriter sw = File.CreateText($@"{Path}\{billfilename}"))
                            {
                                var data = JsonConvert.SerializeObject(bill);
                                sw.Write(data);
                            };
                            Console.WriteLine("Payment acceed");
                        }
                        result.listTable.Remove(result.FindTable(num2));
                        WriteFile();
                        break;
                }
            } while (true);
            
        }

        public static void Menu()
        {
            Console.WriteLine("1.Choice table ");
            Console.WriteLine("2.Enter drinks ");
            Console.WriteLine("3.Payment");
            Console.WriteLine("4.Exit");
        }

        public static void DrinkMenu()
        {
            Console.WriteLine("1.Black Coffee");
            Console.WriteLine("2.Milk Coffee");
            Console.WriteLine("3.Orange Juice");
            Console.WriteLine("4.Lemonade");
            Console.WriteLine("5.Coke");
            Console.WriteLine("6.Water");
            Console.WriteLine("7.Milktea");
        }
        public static void AddDrinkToTable(int checkchose,int numTable)
        {
            switch (checkchose)
            {
                case 1:
                    result.FindTable(numTable).AddDrink(Coffee);
                    break;
                case 2:
                    result.FindTable(numTable).AddDrink(MilkCoffee);
                    break;
                case 3:
                    result.FindTable(numTable).AddDrink(Juice);
                    break;
                case 4:
                    result.FindTable(numTable).AddDrink(Lemonade);
                    break;
                case 5:
                    result.FindTable(numTable).AddDrink(Coke);
                    break;
                case 6:
                    result.FindTable(numTable).AddDrink(Water);
                    break;
                case 7:
                    result.FindTable(numTable).AddDrink(MilkTea);
                    break;
            }
        }

        public static void WriteFile()
        {
            using (StreamWriter sw = File.CreateText($@"{Path}\{fileInput}"))
            {
                var data = JsonConvert.SerializeObject(result);
                sw.Write(data);
            };
        }
        public static void ReadFile()
        {
            using (StreamReader sr = File.OpenText($@"{Path}\{fileInput}"))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<ListTable>(data);
            }
        }

        public static int MustNumBer()
        {
            int num;
            bool check;
            do
            {
                check = int.TryParse(Console.ReadLine(), out num);
                if(check==false)
                    Console.WriteLine("input again!!!");
            } while (check == false);
            return num;
        }
    }
};

   
       
        

        
           
    
