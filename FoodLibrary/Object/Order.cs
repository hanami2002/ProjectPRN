using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Object
{
    public class Order
    {
        public int Id { get; set; }
        public int IdTable { get; set; }
        public DateOnly DateCheckIn { get; set; }
        public DateOnly DateCheckOut { get; set; }
        public int StatusID { get; set; }

    }
}
