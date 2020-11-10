using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FelicanoWeb.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string FullContent { get; set; }
        public string PublishDate { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
