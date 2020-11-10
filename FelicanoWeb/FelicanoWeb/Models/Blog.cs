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
        public string Content { get; set; }
        public string PublishDate { get; set; }
        public string Views { get; set; }
        public string Likes { get; set; }

    }
}
