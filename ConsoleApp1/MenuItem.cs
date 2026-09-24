using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MenuItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        private int _price;
        public int Price { get { return _price; } set { if (value < 0) { value = 0; }; } }
        public bool IsAvailable = true;
        public static int Count = 0;
        public void SellOut()
        {
            IsAvailable = false;
        }
        public void Restock()
        {
            IsAvailable = true;
        }
        public MenuItem(string name, string category, int price)
        {
            Name = name;
            Category = category;
            Price = price;
            Count++;
        }
        public string GetDescription()
        {
            return $"Name: {Name} | Category: {Category} | Price: {Price}";
        }
    }
}
