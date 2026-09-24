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
        public bool IsAvailable { get; set; }

    }
}
