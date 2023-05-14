using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CLControls;
using CLBankTransaction.Models;

namespace CLBankTransaction
{
    public class BankTransaction : Model
    {
        [Required][Column("transaction_date")]
        public DateTime TransactionDate { get; set; }

        [Required][Column("transaction_from")]
        [RegularExpression("")]
        public int TransactionFrom { get; set; }

        [Required][Column("transaction_to")]
        public int TransactionTo { get; set; }

        [Required][Column("transaction_amount")]
        public int TransactionAmount { get; set; }
    }
}