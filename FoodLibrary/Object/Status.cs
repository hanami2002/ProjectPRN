using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Object
{
    public class Status
    {
        public Status(int id, string? sttName)
        {
            Id = id;
            this.sttName = sttName;
        }

        public int Id { get; set; }
        public string? sttName { get; set; }

    }
}
