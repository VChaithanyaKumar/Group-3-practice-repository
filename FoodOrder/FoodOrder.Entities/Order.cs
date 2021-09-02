using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Order_Name { get; set; }
        public DateTime Order_Date { get; set; }
    }
}
