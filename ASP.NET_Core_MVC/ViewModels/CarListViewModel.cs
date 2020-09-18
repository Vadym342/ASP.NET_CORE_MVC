using ASP.NET_Core_MVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }

        public string currCategory { get; set; }

    }
}
