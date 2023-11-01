using logpot.io.customers_management_app.entities.Restaurant;
using logpot.io.customers_management_app.entities.Service;
using Microsoft.EntityFrameworkCore;

namespace logpot.io.customers_management.repositories
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ServiceEntity>()
                .HasDiscriminator(s => s.Name);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    var connectionString = configuration.GetConnectionString("DefaultConnection");
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

        public DbSet<RestaurantEntity> Restaurants { get; set; }
        public DbSet<ManagedService> ManagedServices { get; set; }
        public DbSet<DigitalProductService> DigitalServices { get; set; }
    }
}
