using ShoppingDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Shopping
{
    public partial class AddShoppingOccasion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var selectedDate = cndDate.SelectedDate;
            var desc = txtDesc.Text;
            using (var db = new ShoppingContext())
            {
                var isSelectedDataExist = db.ShoppingOccasions.Any(x => x.Date.Year == selectedDate.Year && x.Date.Month == selectedDate.Month && x.Date.Day == selectedDate.Day);
                if (isSelectedDataExist)
                {
                    lResult.Text = "Already exists";
                }
                else
                {
                    var occasion = new ShoppingOccasion
                    {
                        Date = selectedDate,
                        Description = desc
                    };
                    db.ShoppingOccasions.Add(occasion);
                    db.SaveChanges();
                    lResult.Text = "Successfully persisted";
                }
            }
        }
    }
}