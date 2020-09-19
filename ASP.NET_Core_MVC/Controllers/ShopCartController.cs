using ASP.NET_Core_MVC.Data.Interfaces;
using ASP.NET_Core_MVC.Data.Models;
using ASP.NET_Core_MVC.Data.Repository;
using ASP.NET_Core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASP.NET_Core_MVC.Controllers
{
    public class ShopCartController:Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;

        }
        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart

            };

            return View(obj);

        }
        public RedirectToActionResult addToCard(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i=>i.id==id);  // item with int id 
            if(item!=null)
            {
                _shopCart.AddToCard(item);
            }
            return RedirectToAction("Index");

        }



    }
}
