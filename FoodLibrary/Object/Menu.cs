using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Object
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int IdCategory { get; set; }
    }
}
