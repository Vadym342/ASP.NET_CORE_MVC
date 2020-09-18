using ASP.NET_Core_MVC.Data.Interfaces;
using ASP.NET_Core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars iallCars, ICarsCategory iCarCat)
        {
            _allCars = iallCars;
            _carsCategory = iCarCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page with cars";
            CarListViewModel obj = new CarListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.currCategory = "Cars";

            return View(obj);
        }


    }
}
