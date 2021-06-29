using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content) {
            
                

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any()) {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla model SS",
                        shortDesc = "electric sedan",
                        longDesc = "600HP 2000k",
                        img = "/img/tesla-model-s.jpg",
                        price = 45000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "BMW M5",
                        shortDesc = "Turbo",
                        longDesc = "Turbo 22222222222",
                        img = "/img/BMWM5.jpg",
                        price = 100000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Автомобили с ДВС"]
                    },
                    new Car
                    {
                        name = "Mercedes E63 AMG",
                        shortDesc = "Luctiory",
                        longDesc = "Extra luctiory and hyperfast",
                        img = "/img/Mercedes-e63.jpg",
                        price = 120000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Автомобили с ДВС"]
                    },
                    new Car
                    {
                        name = "Tesla model X",
                        shortDesc = "Ultrarosket",
                        longDesc = "Ultrarosket 33333333333",
                        img = "/img/tesla-model-x.jpg",
                        price = 80000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    }
                );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get {
                if (category == null) {
                    var list = new Category[] {
                        new Category { categoryName =  "Электромобили", desc = "Экологично и практично"},
                        new Category { categoryName =  "Автомобили с ДВС", desc = "Мощь и рев мотора"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}
