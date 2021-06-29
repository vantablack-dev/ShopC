using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories { 
            get {
                return new List<Category> { 
                    new Category { categoryName =  "Электромобили", desc = "Экологично и практично"},
                    new Category { categoryName =  "Автомобили с ДВС", desc = "Мощь и рев мотора"}
                };
            } 
        }
    }
}
