using cqrs.Model;
using Microsoft.EntityFrameworkCore;

namespace cqrs.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            Console.WriteLine(options);
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<StudentDetails> Students { get; set; }
    }
}
