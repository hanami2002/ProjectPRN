using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Object
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdFood { get; set; }
        public int Count { get; set; }

    }
}
