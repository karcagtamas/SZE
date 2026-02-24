using ShoppingDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Shopping
{
    public partial class AddShoppingItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using(var db = new ShoppingContext())
                {
                    var places = db.ShoppingPlaces.ToList()
                        .Select(x => new ListItem { Text = x.Name, Value = x.ShoppingPlaceId.ToString() })
                        .ToArray();
                    ddlShoppingPlaces.Items.AddRange(places);

                    var occasions = db.ShoppingOccasions.ToList()
                        .Select(x => new ListItem { Text = x.Date.ToShortDateString(), Value = x.ShoppingOccasionId.ToString() })
                        .ToArray();
                    ddlShoppingOccasions.Items.AddRange(occasions);
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new ShoppingContext())
                {
                    var placeId = Convert.ToInt64(ddlShoppingPlaces.SelectedValue);
                    var place = db.ShoppingPlaces.FirstOrDefault(x => x.ShoppingPlaceId == placeId);
                    var occasionId = Convert.ToInt64(ddlShoppingOccasions.SelectedValue);
                    var occasion = db.ShoppingOccasions.FirstOrDefault(x => x.ShoppingOccasionId == occasionId);

                    var shoppingItem = new ShoppingItem
                    {
                        Name = txtName.Text,
                        UnitOfMeasure = txtUniOfMeasure.Text,
                        Quantity = int.Parse(txtQuantity.Text),
                        ShoppingPlace = place,
                        ShoppingOccasion = occasion
                    };
                    db.ShoppingItems.Add(shoppingItem);
                    db.SaveChanges();
                    lResult.Text = "Successfully persisted";
                }
            }
            catch (Exception)
            {
                lResult.Text = "Hiba";
            }
        }
    }
}