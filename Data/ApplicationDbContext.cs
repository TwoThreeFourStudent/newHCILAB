using assig2.Models;
using Microsoft.EntityFrameworkCore;


namespace assig2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Province>? Provinces { get; set; }
        public DbSet<City>? Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<City>().Property(m => m.CityName).IsRequired();
            builder.Entity<Province>().Property(p => p.ProvinceName).HasMaxLength(30);

            builder.Entity<Province>().ToTable("Province");
            builder.Entity<City>().ToTable("City");

            // Configure the relationship between Province and City
            builder.Entity<City>()
                .HasOne(c => c.Province)         
                .WithMany(p => p.Cities)         
                .HasForeignKey(c => c.ProvinceCode); 

            // Seed the data
            builder.Seed();
        }
    }
}
