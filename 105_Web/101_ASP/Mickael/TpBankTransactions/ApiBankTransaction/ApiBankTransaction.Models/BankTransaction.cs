using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CLControls;
using Microsoft.EntityFrameworkCore;

namespace ApiBankTransaction.Models
{
    [Table("Transactions")]
    public class BankTransaction : Model
    {
        [Required][Column("transaction_date")]
        public DateTime TransactionDate { get; set; }

        [Required][Column("transaction_from")]
        [RegularExpression(Control.AccountNumber)]
        public uint TransactionFrom { get; set; }

        [Required][Column("transaction_to")]
        [RegularExpression(Control.AccountNumber)]
        public uint TransactionTo { get; set; }

        [Required]
        [Column("transaction_amount")]
        [Precision(7, 2)]
        [Range(0.0d,99000.0d)]
        public decimal TransactionAmount { get; set; }
        

        
    }
}