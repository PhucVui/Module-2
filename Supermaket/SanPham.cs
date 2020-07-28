using System;
using System.Collections.Generic;
using System.Text;

namespace Supermaket
{
    class SanPham
    {
        public string name { get; set; }
        public double price { get; set; }
        public int amount { get; set; }

        public double totalPro { get; set; }
        public override string ToString()
        {
            return $"Name : {name}  Price : {price}  Amount : {amount} totalPro : {this.totalPro}";
        }
    }

    class Basket
    {
        public List<SanPham> list = new List<SanPham>();
        public bool checkSale = true;
        public double TongCong { get; set; }
        public void AddSP(SanPham sp)
        {
            if (FindSanPham(sp.name) == null)
            {
                this.checkSale = true;
                list.Add(sp);
                FindSanPham(sp.name).totalPro = FindSanPham(sp.name).price * FindSanPham(sp.name).amount;
            }
            else
            {
                this.checkSale = true;
                FindSanPham(sp.name).amount++;
                FindSanPham(sp.name).totalPro = FindSanPham(sp.name).price * FindSanPham(sp.name).amount;
            }
                
        }

        public SanPham FindSanPham(string name)
        {
            return list.Find(
                    delegate (SanPham sp)
                    {
                        return sp.name == name;
                    }
                );
        }
        public void View()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public double payMent()
        {
            double sum = 0;
            foreach(var item in list)
            {
                sum += item.totalPro;
            }
            return sum;
        }


    }
}
