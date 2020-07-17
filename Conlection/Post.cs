using System;
using System.Collections.Generic;
using System.Text;

namespace Conlection
{
    class Post : IPost
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public float averageRates { get; set; }
        public static int icrement = 0;
        public List<int> ratesList { get; set; }

        public Post (string title, string content, string author)
        {            
            this.title = title;
            this.content = content;
            this.author = author;
            id = ++icrement;
            ratesList  = new List<int>();
        }

        public void DisPlay()
        {
            Console.WriteLine($" ID: {this.id}\t Title: {this.title}\t Content: {this.content}\t " +
                $"Author: {this.author}\t Count: {this.ratesList.Count}\t AverageRates: {this.averageRates}");
        }

        public void CalculatorRate()
        {
            float sum = 0;
            for (int i = 0; i < ratesList.Count; i++)
            {
                sum += ratesList[i];
            }
            averageRates = sum / this.ratesList.Count;
        }
    }
}
