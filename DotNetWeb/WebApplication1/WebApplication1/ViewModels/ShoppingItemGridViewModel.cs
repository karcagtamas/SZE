using ShoppingDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class ShoppingItemGridViewModel
    {
        public string ShoppingItemName { get; set; }
        public int Quantity { get; set; }
        public string UniOfMeasure { get; set; }
        public string ShoppingPlaceName { get; set; }
    }
}