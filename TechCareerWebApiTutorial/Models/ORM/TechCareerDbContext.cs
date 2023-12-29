using Microsoft.EntityFrameworkCore;

namespace TechCareerWebApiTutorial.Models.ORM
{
    public class TechCareerDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
           optionsBuilder.UseSqlServer("Server=DESKTOP-EET2RGT; Database=TechCareerDb; trusted_connection=true");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
