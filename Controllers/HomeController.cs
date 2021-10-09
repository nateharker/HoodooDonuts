using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HoodooDonuts.Models;
using HoodooDonuts.Models.ViewModel;
using HoodooDonuts.Data;

namespace HoodooDonuts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DonutContext _context;
        public HomeController(ILogger<HomeController> logger, DonutContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Donuts(string type)
        {

            IEnumerable<Donut> donutList = null;

            if (type != null)
            {
                donutList = _context.Donut
                .Where(x => x.Type == type)
                .ToList()
                .OrderBy(x => x.Name)
                .AsEnumerable();
            }
            else
            {
                donutList = _context.Donut
                .ToList()
                .OrderBy(x => x.Name)
                .AsEnumerable();
            }

            var viewModel = new HomeViewModel
            {
                Donuts = donutList,
                Type = type
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
