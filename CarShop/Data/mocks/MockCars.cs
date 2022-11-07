using CarShop.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data.Models;

namespace CarShop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{name = "Tesla",shortDesc = "Model 3", longDesc="опис", img="/img/tesla.png", price=45000, isFavourite = true, available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "BMW",shortDesc = "X4", longDesc="опис", img="/img/bmwx4.png", price=50000, isFavourite = true, available = true,Category = _categoryCars.AllCategories.Last()},
                    new Car{name = "BMW",shortDesc = "I8", longDesc="опис", img="/img/bmwi8.png", price=60000, isFavourite = true, available = true,Category = _categoryCars.AllCategories.First()},
                    new Car{name = "Volkswagen",shortDesc = "T-roc", longDesc="опис", img="/img/troc.png", price=30000, isFavourite = true, available = true,Category = _categoryCars.AllCategories.Last()}
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }


}