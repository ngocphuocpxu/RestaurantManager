using FelicanoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FelicanoWeb.ViewModels
{
    public class HomeIndexVM
    {
        public List<Food> Foods { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
