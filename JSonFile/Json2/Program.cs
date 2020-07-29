using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Json2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Path = @"C:\Users\vui\source\repos\JSonFile\Json2\data";
            var fileInput = "data.json";
            var result = new StudentList();
            using (StreamReader sr = File.OpenText($@"{Path}\{fileInput}"))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<StudentList>(data);
            }

            var output = "Outcome.json";
            List<Xeploai> listAverages = new List<Xeploai>();

            foreach (var item in result.students)
            {
                Xeploai xeploai = new Xeploai();
                xeploai.average = item.getAverage();
                xeploai.Rank = xeploai.SetRank();
                xeploai.name = item.HoTen;
                xeploai.MaHS = item.MaHS;
                listAverages.Add(xeploai);
            }
            listAverages.Sort();
            using (StreamWriter sw = File.CreateText($@"{Path}\{output}"))
            {
                var data = JsonConvert.SerializeObject(listAverages);
                sw.Write(data);
            };
        }
    } 
}
















