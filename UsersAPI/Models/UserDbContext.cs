using Microsoft.EntityFrameworkCore;

namespace UsersAPI.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext()
        {

        }
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=192.168.0.117; database=User; user=root;password=password",ServerVersion.AutoDetect("server=192.168.0.117; database=User; user=root;password=password"));
            }
        }
        public DbSet<User> Users { get; set; } = null!;
    }
}
