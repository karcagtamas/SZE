using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDataAccessLayer.Models
{
    public class ShoppingItem
    {
        public long ShoppingItemId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public virtual ShoppingPlace ShoppingPlace { get; set; }
        public virtual ShoppingOccasion ShoppingOccasion { get; set; }
    }
}
