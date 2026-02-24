using ShoppingDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WebApplication1.ViewModels;

namespace WebApplication1.App_Code
{
    public class ShoppingQueries
    {
        public ShoppingQueries()
        {

        }

        public List<ListItem> GetFutureShoppingOccasions()
        {
            using (var db = new ShoppingContext())
            {
                var currDate = DateTime.Now.Date;
                var query = db.ShoppingOccasions.Where(x => x.Date >= currDate).OrderBy(x => x.Date).ToList().Select(x => new ListItem { Value = x.ShoppingOccasionId.ToString(), Text = x.Date.ToShortDateString() });
                return query.ToList();
            }
        }
        public IEnumerable<ShoppingItem> GetShoppingItems(string occasionId)
        {
            var selectedId = long.Parse(occasionId);
            using (var db = new ShoppingContext())
            {
                var items = db.ShoppingItems.Where(x => x.ShoppingOccasion.ShoppingOccasionId == selectedId).OrderBy(x => x.Name).ToList();

                return items;
            }
        }

        public IEnumerable<ShoppingItemGridViewModel> GetShoppingItemGridViewModels(string occasionId)
        {
            var selectedId = long.Parse(occasionId);
            using (var db = new ShoppingContext())
            {
                var items = db.ShoppingItems
                    .Where(x => x.ShoppingOccasion.ShoppingOccasionId == selectedId)
                    .OrderBy(x => x.ShoppingPlace.Name)
                    .Select(x => new ShoppingItemGridViewModel { ShoppingItemName = x.Name, Quantity = x.Quantity, ShoppingPlaceName = x.ShoppingPlace.Name, UniOfMeasure = x.UnitOfMeasure })
                    .ToList();

                return items;
            }
        }
    }
}