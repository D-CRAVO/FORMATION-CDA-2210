using Microsoft.EntityFrameworkCore;
using CLBankTransactions.Models;

namespace CLBankTransactions.Db
{
    public class BankDbContext : DbContext
    {
        public DbSet<BankTransaction> BankTransactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=tp_banks3");
        }
    }
}