using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FelicanoWeb.Models;
using FelicanoWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FelicanoWeb.Controllers
{
    public class FoodController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public FoodController(AppDbContext appDbContext)
        {

            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                /*Products = _appDbContext.Products.Where(prod => EF.Functions.Like(prod.Name, "%a%")).Include(p => p.Category).ToList(),*/
                Foods = _appDbContext.Foods.Include(p => p.Category).ToList(),
                Categories = _appDbContext.Categories
            };


            return View(homeIndexVM);
        }
    }
}
