using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {
        public string Name { get; set; }
        private List<MenuItem> items;
        public Menu(string name)
        {
            Name = name;
            items = new List<MenuItem>();
        }
        public void AddItem(MenuItem item)
        {
            items.Add(item);
        }
        public MenuItem FindByName(string name)
        {
            foreach (MenuItem item in items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        public List<MenuItem> AvailableItem()
        {
            List<MenuItem> list = new List<MenuItem>();
            foreach (MenuItem item in items)
            {
                if (item.IsAvailable)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
