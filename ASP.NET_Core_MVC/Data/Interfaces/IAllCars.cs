using ASP.NET_Core_MVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.Data.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> Cars { get;  }
        IEnumerable<Car> getFavCars { get; set; }

        Car getObjCar(int carId);



    }
}
