using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml;

namespace CoffeeShop
{
    class ListTable
    {
        public List<Table> listTable = new List<Table>();       

        public Table FindTable(int NameTable)
        {
            return listTable.Find(
                delegate(Table tb)
                {
                    return tb.NameTable == NameTable;
                }               
                );
        }
        public void AddTable(Table table)
        {
            if (FindTable(table.NameTable) == null)
            {
                listTable.Add(table);
            }          
        }
    }
    class Bill 
    {
        public List<Drink> drinks = new List<Drink>(); 
        public int NameTable { get; set; }
        public double Total { get; set; }
        public DateTime dateTime { get; set; }
    }
    class Table
    {
        public List<Drink> listDrink = new List<Drink>();
        public int NameTable { get; set; }
        public double Total { get; set; }

        //tìm tên thức uống có chưa, nếu chưa mới add vào bàn, còn có rồi thì tăng số lượng
        public Drink FindDrink(string name)
        {
            return listDrink.Find(
                delegate (Drink drink)
                {
                    return drink.name == name;
                }
                );
        }

        public void AddDrink(Drink dr)
        {
            if(FindDrink(dr.name)== null)
            {
                listDrink.Add(dr);
                FindDrink(dr.name).totalDrink = FindDrink(dr.name).price * FindDrink(dr.name).amount;
                Payment();
            }
            else
            {
                FindDrink(dr.name).amount++;
                FindDrink(dr.name).totalDrink = FindDrink(dr.name).price * FindDrink(dr.name).amount;
                Payment();
            }            
        }
        public void Payment()
        {
            double sum = 0;
            foreach(var item in listDrink)
            {
                sum += item.totalDrink;
            }
            this.Total = sum;
        }
    }

    class Drink
    {
        public string name { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public double totalDrink { get; set; }

        public override string ToString()
        {
            return $"Name : {name}  Price : {price}  Amount : {amount} Total Drink : {totalDrink} ";
        }

      
    }
    
}
