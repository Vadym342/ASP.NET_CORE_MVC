using ASP.NET_Core_MVC.Data.Interfaces;
using ASP.NET_Core_MVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.Data.mocks
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
                    new Car { name="Tesla", shortDesc="Electro, so fast ",longDesc="New type of electro car whick can ride with speed more than 300k/h ",img="https://autoreview.ru/images/Article/1700/Article_170068_860_575.jpg",price=45000, isFavourite=true, avaible=true, Category=_categoryCars.AllCategories.First()},
                    new Car { name="Land Cruiser", shortDesc="Bisnes class",longDesc="So comfortable auto for drive",img="https://s.auto.drom.ru/i24207/c/photos/fullsize/toyota/land_cruiser/toyota_land_cruiser_699944.jpg",price=100000, isFavourite=true, avaible=true, Category=_categoryCars.AllCategories.Last()}
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }
        
        public Car getObjCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
