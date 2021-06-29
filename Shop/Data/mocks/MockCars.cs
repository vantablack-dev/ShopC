using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car> {
                    new Car {
                        name = "Tesla model S", 
                        shortDesc = "electric sedan", 
                        longDesc = "600HP 2000k", 
                        img = "/img/tesla-model-s.jpg", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First() 
                    },
                    new Car {
                        name = "BMW M5",
                        shortDesc = "Turbo",
                        longDesc = "Turbo 22222222222",
                        img = "/img/BMWM5.jpg", 
                        price = 100000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Mercedes E63 AMG",
                        shortDesc = "Luctiory",
                        longDesc = "Extra luctiory and hyperfast",
                        img = "/img/Mercedes-e63.jpg",
                        price = 120000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Tesla model X",
                        shortDesc = "Ultrarosket",
                        longDesc = "Ultrarosket 33333333333",
                        img = "/img/tesla-model-x.jpg", 
                        price = 80000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set;}

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
