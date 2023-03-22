using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Object
{
    public class OrderDetails
    {
        public OrderDetails(int id, int idOrder, int idFood, int? count)
        {
            Id = id;
            IdOrder = idOrder;
            IdFood = idFood;
            Count = count;
        }

        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdFood { get; set; }
        public int? Count { get; set; }
    }
}
