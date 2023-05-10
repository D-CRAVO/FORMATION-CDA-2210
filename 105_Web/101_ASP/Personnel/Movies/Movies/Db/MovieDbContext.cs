using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Movies.Models;

namespace Movies.Db
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_cereals");
        }
    }
}
