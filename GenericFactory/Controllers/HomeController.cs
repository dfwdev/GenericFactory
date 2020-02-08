using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GenericFactory.Models;

namespace GenericFactory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var x = 1;

            CarFactory carFactory = new CarFactory();

            Audi audi = carFactory.CreateCar<Audi>(100, "A3", "AA11ABC");
            Ford ford = carFactory.CreateCar<Ford>(200, "Focus", "FF22DEF");
            Seat seat = carFactory.CreateCar<Seat>(300, "Leon Cupra", "SS33GHJ");

            var a = audi.AudiOnly();
            var b = ford.FordOnly();
            var c = seat.SeatOnly();


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
