using FelicanoWeb.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FelicanoWeb.ViewModels
{
    public class ProductCreateVM
    {
        public Food Food { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
        public IEnumerable<SelectListItem> TagSelectList { get; set; }
        public IEnumerable<int> SelectListTagIds { get; set; }
    }
}
