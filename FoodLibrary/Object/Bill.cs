using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Object
{
    public class Bill
    {
        public Bill(string name, int count, double price, double total)
        {
            Name = name;
            Count = count;
            Price = price;
            Total = total;
        }

        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }

    }
}
