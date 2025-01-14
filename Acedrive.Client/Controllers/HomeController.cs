﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Acedrive.Client.Models;
using Microsoft.Extensions.Options;
using Acedrive.Domain.Models;

namespace Acedrive.Client.Controllers
{

    public class HomeController : Controller
    {
        Session _session = SessionHandler.Instance();
        public IActionResult Index()
        {
          //retrieve list of all cars in db with
          List<Vehicle> vehicles = _session.GetAllVehicles();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
