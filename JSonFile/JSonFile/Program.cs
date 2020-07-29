
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JSonFile
{
    class Program
    {
        static void Main()
        {
            var filePath = @"C:\Users\vui\source\repos\JSonFile\JSonFile\Data";
            var fileInput = "input.json";
            var fileOutput1 = "output1.json";
            var fileOutput2 = "output2.json";
            var fileOutput3 = "output3.json";
            // Đọc dữ liệu từ file input.json
            var result = new List();
            using (StreamReader sr = File.OpenText($@"{filePath}\{fileInput}"))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<List>(data);
            }
            // Tạo dữ liẹu output2 từ dữ liệu file input(result)
            var dataOutput2= new List()
            {
                list = new List<Data>()
            };

            foreach(var item in result.list)
            {
                dataOutput2.list.Add(new Data()
                {
                    a = item.a*2, 
                    b = item.b*2,
                    c = item.c*2
                });
            }
            // Viet du lieu vao file output2 (convert)
            using (StreamWriter sw = File.CreateText($@"{filePath}\{fileOutput2}"))
            {
                var data = JsonConvert.SerializeObject(dataOutput2);
                sw.Write(data);
            };
            // Tạo dữ liẹu output1 từ dữ liệu file input(result)
            var dataOutput1 = new ListSum1()
            {
                listSum = new List<Sum>()
            };
            foreach(var item in result.list)
            {
                dataOutput1.listSum.Add(new Sum()
                {
                    sum = item.Sum()
                });
            }
            using (StreamWriter sw = File.CreateText($@"{filePath}\{fileOutput1}"))
            {
                var data1 = JsonConvert.SerializeObject(dataOutput1);
                sw.Write(data1);
            };

            var dataOutput3 = new SumAndData()
            {
                listHaveSum = new List<HaveSum>()
            };
            foreach(var item in result.list)
            {
                dataOutput3.listHaveSum.Add(new HaveSum()
                {
                    a = item.a,
                    b= item.b,
                    c= item.c
                });
            }
            using (StreamWriter sw = File.CreateText($@"{filePath}\{fileOutput3}"))
            {
                var data4 = JsonConvert.SerializeObject(dataOutput3);
                sw.Write(data4);
            };

        }
    }

    class ListSum1
    {
        public List<Sum> listSum { get; set; }
    }
    class Sum
    {
        public int sum { get; set; }
    }
    class List
    { 
        public List<Data> list { get; set; }
    }
    class Data
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public int Sum()
        {
            return a + b + c;
        }
    }
    class SumAndData
    {
         public List<HaveSum> listHaveSum { get; set; }
    }
    class HaveSum : Data
    {
        public int sum => Sum();
    }
}
