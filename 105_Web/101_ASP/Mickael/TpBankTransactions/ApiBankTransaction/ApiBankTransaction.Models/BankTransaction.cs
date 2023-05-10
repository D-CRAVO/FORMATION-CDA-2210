using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CLControls;

namespace ApiBankTransaction.Models
{
    [Table("Transactions")]
    public class BankTransaction
    {
        [Key][Column ("transaction_id")]
        public int TransactionId { get; private set; }
        [Required][Column("transaction_date")]
        
        public DateTime TransactionDate { get; private set; }

        [Required][Column("transaction_from")]
        [RegularExpression(Control.AccountNumber)]
        public uint TransactionFrom { get; private set; }

        [Required][Column("transaction_to")]
        [RegularExpression(Control.AccountNumber)]
        public uint TransactionTo { get; private set; }

        [Required][Column("transaction_amount")]
        public float TransactionAmount { get; private set; }

        public BankTransaction(DateTime _transactionDate, uint _transactionFrom, uint _transactionTo, float _transactionAmount)
        {
            TransactionDate = _transactionDate;
            TransactionFrom = _transactionFrom;
            TransactionTo = _transactionTo;
            if (Control.Amount(_transactionAmount))
            {
                TransactionAmount = _transactionAmount;
            }
            
        }
    }
}