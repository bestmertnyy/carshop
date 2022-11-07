using CarShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {



            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car { name = "Tesla", shortDesc = "Model 3", longDesc = "опис", img = "/img/tesla.jpg", price = 45000, isFavourite = true, available = true, Category = Categories["Електромобілі"] },
                    new Car { name = "BMW", shortDesc = "X4", longDesc = "опис", img = "/img/bmwx4.jpg", price = 50000, isFavourite = true, available = true, Category = Categories["Автомобілі з ДВЗ"] },
                    new Car { name = "BMW", shortDesc = "I8", longDesc = "опис", img = "/img/bmwi8.jpg", price = 60000, isFavourite = true, available = true, Category = Categories["Електромобілі"] },
                    new Car { name = "Volkswagen", shortDesc = "T-roc", longDesc = "опис", img = "/img/troc.jpg", price = 30000, isFavourite = true, available = true, Category = Categories["Автомобілі з ДВЗ"] }
                    );
            }
            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                         new Category{categoryName = "Електромобілі", desc = "Автомобілі які працюють використовуючи електроенергію" },
                         new Category{categoryName = "Автомобілі з ДВЗ", desc = "Автомобілі які працюють використовуючи двигуни внутрішнього згорання" }
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
