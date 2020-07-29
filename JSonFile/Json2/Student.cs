using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Json2
{
    public class MonHoc
    {
        public string TenMonHoc { get; set; }
        public double DiemThi { get; set; }      
    }
    public class Student
    {
        public string MaHS { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public List<MonHoc> DSMonHoc { get; set; }
        public double getAverage ()
        {
            double sum = 0;
            foreach (var item in DSMonHoc)
            {
                if (item.TenMonHoc == "Toan")
                {
                    sum += item.DiemThi * 2;
                }
                else
                    sum += item.DiemThi;
            }

            return sum/(DSMonHoc.Count+1);
        }
    }

    public class StudentList
    {
        public List<Student> students { get; set; }
    }

    public class Xeploai : IComparable<Xeploai>
    { 
        public string name { get; set; }
        public string MaHS { get; set; }
        public double average { get; set; }
        public string Rank { get; set; }

        public int CompareTo(Xeploai other)
        {
            if (other.average > this.average)
                return 1;
            if (other.average < this.average)
                return -1;
            return 0;
        }

        public string SetRank()
        {
            if (average >= 9 && average <= 10)
            {
                return "Xuat Sac";
            }
            else if (average >=8)
            {
                return "Gioi";
            }
            else if (average >=7)
            {
                return "Kha";
            }
            else if (average >=6.5) 
            {
                return "Trung Binh Kha";
            }
            else if (average >=5)
            {
                return "Trung Binh";
            }
            else if(average >=3.5)
            {
                return "Yeu";
            }
            return "Kem";
        }
      

    }
}
