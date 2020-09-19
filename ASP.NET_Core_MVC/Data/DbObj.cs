using ASP.NET_Core_MVC.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.Data
{
    public class DbObj
    {
        public static void Initial(AppDBContent content)
        {
           
               
            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c=>c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car { name = "Tesla", shortDesc = "Electro, so fast ", longDesc = "New type of electro car whick can ride with speed more than 300k/h ", img = "https://autoreview.ru/images/Article/1700/Article_170068_860_575.jpg", price = 45000, isFavourite = true, avaible = true, Category = Categories["Electro Cars"] },
                    new Car { name = "Land Cruiser", shortDesc = "Bisnes class", longDesc = "So comfortable auto for drive", img = "https://s.auto.drom.ru/i24207/c/photos/fullsize/toyota/land_cruiser/toyota_land_cruiser_699944.jpg", price = 100000, isFavourite = true, avaible = true, Category = Categories["DTI"] }


                    );




            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static  Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[] {
                        new Category{categoryName="Electro Cars", description="New kind cars"},
                        new Category{ categoryName="DTI", description="Usual cars"}

                    };
                    category = new Dictionary<string, Category>();
                    
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }

        }

    }
}
