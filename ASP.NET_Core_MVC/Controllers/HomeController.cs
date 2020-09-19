using ASP.NET_Core_MVC.Data.Interfaces;
using ASP.NET_Core_MVC.Data.Models;
using ASP.NET_Core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.Controllers
{
    public class HomeController:Controller
    {
        private readonly IAllCars _carRep;
      

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
          
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel {
             favCars= _carRep.getFavCars
            };

            return View(homeCars);
        }




    }
}
