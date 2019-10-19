using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FutureAgro.Web.Models;
using FutureAgro.DataAccess.Services;
using Microsoft.AspNetCore.Authorization;
using FutureAgro.DataAccess.Models;
using FutureAgro.DataAccess.Data;

namespace FutureAgro.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly FutureAgroIdentityDbContext _dbContext;
        private readonly IUserService _userService;

        public HomeController(IUserService userService, FutureAgroIdentityDbContext dbContext)
        {
            _dbContext = dbContext;
            _userService = userService;
        }

        public IActionResult Index()
        {
            /*B-HomeCharts*/
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
        
        /*B-MetodosHomeController*/
    }
}
