using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FelicanoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FelicanoWeb.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public AboutController(AppDbContext appDbContext)
        {

            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var abouts = _appDbContext.Abouts.ToList();
            return View(abouts);
        }
    }
}
