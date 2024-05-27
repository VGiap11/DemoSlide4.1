using DemoSlide4.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoSlide4.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=VGiap;Initial Catalog=DemoSlide4;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employess> Employesses { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<DemoSlide4User> DemoSlide4Users { get; set;}

    }
}
