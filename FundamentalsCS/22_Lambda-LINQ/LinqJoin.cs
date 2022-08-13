using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._22_Lambda_LINQ
{
    public class LinqJoin
    {
        //Joining Data with LINQ
        //Syntax
        //----------------------
        //from [variable name from collection 1] in [collection 1] join
        //[variable name from collection 2] in [collection 2] on [part of 
        //the compare condition from collection 1] equals [part of the 
        //compare condition from collection 2]

        static void MainLJ()
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { ID = 1, Name = "Fruit" },
                new Category() { ID = 2, Name = "Food" },
                new Category() { ID = 3, Name = "Shoe" },
                new Category() { ID = 4, Name = "Juice" },
            };
            List<Product> products = new List<Product>()
            {
                new Product() {Name = "Strawberry", CategoryID = 1 },
                new Product() {Name = "Banana", CategoryID = 1 },
                new Product() {Name = "Chicken Meat", CategoryID = 2 },
                new Product() {Name = "Apple Juice", CategoryID = 4 },
                new Product() {Name = "Fish", CategoryID = 2 },
                new Product() {Name = "Orange Juice", CategoryID = 4 },
                new Product() {Name = "Sandal", CategoryID = 3 },
            };
            var productsWithCategories = from product in products
                                         join category in categories
                                         on product.CategoryID equals category.ID
                                         select new { Name = product.Name, Category = category.Name };

            foreach (var item in productsWithCategories)
            {
                Console.WriteLine(item);
            }

            //The result is:
            //{ Name = Strawberry, Category = Fruit }
            //{ Name = Banana, Category = Fruit }
            //{ Name = Chicken meat, Category = Food }
            //{ Name = Apple Juice, Category = Juice }
            //{ Name = Fish, Category = Food }
            //{ Name = Orange Juice, Category = Juice }
            //{ Name = Sandal, Category = Shoe }
            //Nested LINQ Queries
            var productsWithCategoriesN = from product in products
                                          select new {
                                              Name = product.Name,
                                              Category =
                                              (from category in categories
                                               where category.ID == product.CategoryID
                                               select category.Name).First()
                                          };
            //Same Result\\

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int CategoryID { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
