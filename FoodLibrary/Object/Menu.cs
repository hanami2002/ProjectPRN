using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Object
{
    public class Menu
    {
        public Menu(int id, string name, double price, int idCategory)
        {
            Id = id;
            Name = name;
            Price = price;
            IdCategory = idCategory;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int IdCategory { get; set; }

    }
}
