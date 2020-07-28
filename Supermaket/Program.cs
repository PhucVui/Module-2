using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Supermaket
{
    class Program
    {
        public static string Path = @"C:\Users\vui\source\repos\JSonFile\Supermaket\datamaket";
        public static string fileInput = "product.json";
        public static string fileOutput = "hoadon.json";
        public static Basket result = new Basket();

        public static SanPham IPhone5 = new SanPham()
        {
            name = "IPhone 5",
            amount = 1,
            price = 3000000
        };

        public static SanPham IPhone6 = new SanPham()
        {
            name = "IPhone 6",
            amount = 1,
            price = 4500000
        };

        public static SanPham IPhone7 = new SanPham()
        {
            name = "IPhone 7",
            amount = 1,
            price = 6000000
        };
        public static SanPham IPhone8 = new SanPham()
        {
            name = "IPhone 8",
            amount = 1,
            price = 8000000
        };
        public static SanPham IPhone10 = new SanPham()
        {
            name = "IPhone 10",
            amount = 1,
            price = 10000000
        };
        public static SanPham IPhone11 = new SanPham()
        {
            name = "IPhone 11",
            amount = 1,
            price = 20000000
        };

        static void Main(string[] args)
        {
            do
            {
                Menu();
                int test = Convert.ToInt32(Console.ReadLine());
                if (test == 4)
                    break;
                switch (test)
                {
                    case 1:
                        sanPhamMenu();
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                ReadFile();
                                result.AddSP(IPhone5);
                                WriteFile();
                                break;
                            case 2:
                                ReadFile();
                                result.AddSP(IPhone6);
                                WriteFile();
                                break;
                            case 3:
                                ReadFile();
                                result.AddSP(IPhone7);
                                WriteFile();
                                break;
                            case 4:
                                ReadFile();
                                result.AddSP(IPhone8);
                                WriteFile();
                                break;
                            case 5:
                                ReadFile();
                                result.AddSP(IPhone10);
                                WriteFile();
                                break;
                            case 6:
                                ReadFile();
                                result.AddSP(IPhone11);
                                WriteFile();
                                break;
                        }
                        break;

                    case 2:
                        ReadFile();
                        if(result.list.Count != 0)
                        {
                            result.View();
                        }
                        else
                        {
                            Console.WriteLine("Haven't product to show");
                        }
                        
                        break;

                    case 3:

                        ReadFile();
                        result.TongCong = result.payMent();
                        if (result.checkSale == true)
                        {
                            using (StreamWriter sw = File.CreateText($@"{Path}\{fileOutput}"))
                            {
                                var data = JsonConvert.SerializeObject(result);
                                sw.Write(data);
                            };
                            Console.WriteLine("Payment acceed");
                            result.list.Clear();
                            result.TongCong = 0;

                            result.checkSale = false;
                            WriteFile();
                        }
                        else
                        {
                            Console.WriteLine("No product in basket");
                        }
                        break;
                }
            } while (true);

        }

        public static void ReadFile()
        {
            using (StreamReader sr = File.OpenText($@"{Path}\{fileInput}"))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Basket>(data);
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
        public static void Menu()
        {
            Console.WriteLine("1.Add product into basket");
            Console.WriteLine("2.Show product in basket");
            Console.WriteLine("3.Payment");
            Console.WriteLine("4.Exit");
        }

        public static void sanPhamMenu()
        {
            Console.WriteLine("1.iphone 5");
            Console.WriteLine("2.iphone 6");
            Console.WriteLine("3.iphone 7");
            Console.WriteLine("4.iphone 8");
            Console.WriteLine("5.iphone 10");
            Console.WriteLine("6.iphone 11");
        }
    }
}
