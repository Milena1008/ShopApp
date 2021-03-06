using System.Collections.Generic;
using System.Data.Entity;

namespace ShopApp.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID= 1,
                    CategoryName= "Dresses"
                },

                new Category
                {
                    CategoryID= 2,
                    CategoryName= "Skirts"
                },
                new Category
                {
                    CategoryID= 3,
                    CategoryName= "Shoes"
                },
                new Category
                {
                    CategoryID= 4,
                    CategoryName= "Handbags"
                },
                new Category
                {
                    CategoryID= 5,
                    CategoryName= "Tops"
                },

            };
            return categories;

        }

        private static List<Product> GetProducts()

        {
            var products = new List<Product> {
            new Product
                {
                    ProductID = 1,
                    ProductName = "Dress",
                    Description =   "Nice dress", 
                    ImagePath="dress.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
     new Product
                {
                    ProductID = 2,
                    ProductName = "Skirt",
                    Description =   "Pretty skirt", 
                    ImagePath="skirt.png",
                    UnitPrice = 12.50,
                    CategoryID = 2
               },

 new Product
                {
                    ProductID = 3,
                    ProductName = "Shoes",
                    Description =   "Comfy shoes", 
                    ImagePath="shoes.png",
                    UnitPrice = 22.50,
                    CategoryID = 3
               },

     new Product
                {
                    ProductID = 4,
                    ProductName = "Handbag",
                    Description =   "Handbag details", 
                    ImagePath="handbag.jpg",
                    UnitPrice = 19.50,
                    CategoryID = 4
               },

     new Product
                {
                    ProductID = 5,
                    ProductName = "Top",
                    Description =   "Tshirt for men", 
                    ImagePath="top.png",
                    UnitPrice = 22.50,
                    CategoryID = 5
               }
    };
    return products;
    }
    }
}