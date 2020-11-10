using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FelicanoWeb.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FoodTag>().HasKey(foodtag => new { foodtag.FoodId, foodtag.TagId });

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Breakfast"});
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Lunch" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Dinner" });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 1,
                Name = "Xôi",
                Description = "Nguyên liệu chính vẫn là xôi nếp, nhưng để hấp dẫn hơn, người bán có thể chế biến theo nhiều kiểu như: xôi chiên, xôi lá chuối, xôi đậu xanh, xôi thịt, xôi khúc…",
                Price = 10000,
                ImageUrl = "https://jobsgo.vn/blog/wp-content/uploads/2019/09/com-tam.png",
                CategoryId = 1
            });
            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 2,
                Name = "Cơm tấm",
                Description = "Cơm tấm được nấu từ các hạt gạo vụn, bị bể rớt xuống khi sàng gạo. Sau đó ăn kèm với cơm là sườn, trứng, bì, chả…",
                Price = 20000,
                ImageUrl = "https://toplist.vn/images/800px/banh-my-pate-606.jpg",
                CategoryId = 2
            });
            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 3,
                Name = "Mực chiên",
                Description = "Mực ống được sắt miếng vừa phải và tẩm bột chiên giòn. Món ăn này được mọi lứa tuổi và vùng miền yêu thích vì rất dễ ăn.",
                Price = 50000,
                ImageUrl = "https://cdn.24h.com.vn/upload/3-2019/images/2019-08-16/10-1565953389-469-width1440height969.jpg",
                CategoryId = 3
            });


            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 1,
                Name = "Món ngon Việt Nam"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 2,
                Name = "Đồ ăn hấp dẫn"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 3,
                Name = "Món ngon tuyệt vời"
            });
        }
    }
}
