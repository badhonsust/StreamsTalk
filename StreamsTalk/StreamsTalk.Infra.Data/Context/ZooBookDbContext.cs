using Microsoft.EntityFrameworkCore;
using StreamsTalk.Domain.Entities;
using StreamsTalk.Infra.Data.DataSeeder;

namespace StreamsTalk.Infra.Data.Context
{
    public class StreamsTalkDbContext : DbContext
    {
        public StreamsTalkDbContext(DbContextOptions<StreamsTalkDbContext> options)
          : base(options)
        {
        }

        public DbSet<Employee> Employes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(EmployeeDataSeeder.SeedData());
            base.OnModelCreating(builder);
        }
      

    }
}
