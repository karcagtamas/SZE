using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDataAccessLayer.Models
{
    public class ShoppingOccasion
    {
        public long ShoppingOccasionId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ShoppingItem> ShoppingItems { get; set; }
    }
}
