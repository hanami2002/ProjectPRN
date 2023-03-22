using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Object
{
    public class Table
    {
        public Table(int id, string nameTablee, int sttId)
        {
            Id = id;
            NameTablee = nameTablee;
            SttId = sttId;
        }

        public int Id { get; set; }
        public string NameTablee { get; set; }
        public int SttId { get; set; }
    }
}
