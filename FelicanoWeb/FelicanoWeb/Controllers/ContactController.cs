using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FelicanoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FelicanoWeb.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public ContactController(AppDbContext appDbContext)
        {

            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var contacts = _appDbContext.Contacts.ToList();
            return View(contacts);
        }
    }
}
