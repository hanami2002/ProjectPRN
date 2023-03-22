using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Object
{
    public class Order
    {
        public Order(int id, int idTable, DateTime dateCheckIn, DateTime dateCheckOut, int status)
        {
            Id = id;
            IdTable = idTable;
            DateCheckIn = dateCheckIn;
            DateCheckOut = dateCheckOut;
            Status = status;
            
        }

        public int Id { get; set; }
        public int IdTable { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }
        public int Status { get; set; }
     
    }
}
