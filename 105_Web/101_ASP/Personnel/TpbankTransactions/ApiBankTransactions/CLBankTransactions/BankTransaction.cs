using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CLBankTransaction.Models;
using CLControls;
using Microsoft.EntityFrameworkCore;

namespace CLBankTransactions
{
    public class BankTransaction : Model
    {
        [Required]
        [Column("transaction_date")]
        public DateTime TransactionDate { get; set; }

        [Required]
        [Column("transaction_from")]
        [RegularExpression(Control.AmountNumber)]
        public int TransactionFrom { get; set; }

        [Required]
        [Column("transaction_to")]
        [RegularExpression(Control.AmountNumber)]
        public int TransactionTo { get; set; }

        [Required]
        [Column("transaction_amount")]
        [Precision(7, 2)]
        [Range(0.00, 99000.00)]
        public decimal TransactionAmount { get; set; }
    }
}