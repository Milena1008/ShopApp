using ShopApp.Logic;
using ShopApp.Models;
using System;
using System.Data.Entity;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;


namespace ShopApp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Initialize the product database
            Database.SetInitializer(new ProductDatabaseInitializer());

            //Create the custom role and user. 
            RoleActions roleActions = new RoleActions();
            roleActions.AddUserAndRole();

            // Add Routes: 
            RegisterCustomRoutes(RouteTable.Routes);
        }

        void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "ProductsByCategoryRoute",
                "Category/{categoryName}",
                "~/ProductList.aspx"
                );

            routes.MapPageRoute(
                "ProductByNameRoute",
              "Product/{productName}",
              "~/ProductDetails.aspx"
          );
        }
    }
}