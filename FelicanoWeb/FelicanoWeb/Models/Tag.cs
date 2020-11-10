using System.Collections.Generic;

namespace FelicanoWeb.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FoodTag> FoodTags { get; set; }
    }
}