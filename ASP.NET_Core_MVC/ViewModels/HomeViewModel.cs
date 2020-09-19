using ASP.NET_Core_MVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favCars { get; set; }

    }
}
