﻿using CarShop.Data.interfaces;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Controllers
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
            var homeCars = new HomeViewModel
            {
                favCars=_carRep.getFavCars
            };
            return View(homeCars);
        }

    }
}
