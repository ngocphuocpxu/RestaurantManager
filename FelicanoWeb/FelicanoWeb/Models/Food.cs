using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FelicanoWeb.Models
{
    public class Food
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bắt buộc nhập tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nhập mô tả")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Nhập giá")]
        public int Price { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<FoodTag> FoodTags { get; set; } = new List<FoodTag>();
    }
}