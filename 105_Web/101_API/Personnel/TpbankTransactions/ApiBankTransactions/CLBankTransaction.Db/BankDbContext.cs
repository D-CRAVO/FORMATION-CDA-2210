using CLBankTransaction.Models;
using Microsoft.EntityFrameworkCore;


namespace CLBankTransaction.Db
{
    public class BankDbContext : DbContext
    {
        public DbSet<BankTransaction> BankTransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=tp_banks2");
        }
    }
}