using ShopApp.Logic;
using System;
using System.Diagnostics;

namespace ShopApp
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["ProductID"];
            int productId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId ))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR");
                throw new Exception("ERROR");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}