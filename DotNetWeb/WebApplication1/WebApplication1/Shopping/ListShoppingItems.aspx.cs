using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Shopping
{
    public partial class ListShoppingItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlSelectedDate3.DataSource = SqlDataSource2;
            ddlSelectedDate3.DataTextField = "Date";
            ddlSelectedDate3.DataValueField = "ShoppingOccasionId";
            ddlSelectedDate3.DataBind();
        }

        protected void ddlSelectedDate4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.DataBind();
            GridView2.DataBind();
        }
    }
}