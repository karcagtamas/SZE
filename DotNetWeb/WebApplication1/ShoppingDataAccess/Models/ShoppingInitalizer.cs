using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDataAccess.Models
{
    public class ShoppingInitalizer : CreateDatabaseIfNotExists<ShoppingContext>
    {
        protected override void Seed(ShoppingContext context)
        {
            var list = new List<ShoppingPlace> 
            { 
                new ShoppingPlace { Name="Bolt", Address="Yap"}
            };
            context.ShoppingPlaces.AddRange(list);

            base.Seed(context);
        }
    }
}
