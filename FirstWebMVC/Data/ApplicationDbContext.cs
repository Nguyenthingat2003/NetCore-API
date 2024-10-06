using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models.Entities;


namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
    
        }
        public DbSet<Person> Person { get; set;} = default;

    }
}