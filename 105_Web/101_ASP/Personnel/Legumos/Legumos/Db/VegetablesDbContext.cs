using Legumos.Models;
using Microsoft.EntityFrameworkCore;

namespace Legumos.Db
{
    public class VegetablesDbContext : DbContext
    {
        public DbSet<Vegetable> Vegetables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_legumos");
        }
    }
}
