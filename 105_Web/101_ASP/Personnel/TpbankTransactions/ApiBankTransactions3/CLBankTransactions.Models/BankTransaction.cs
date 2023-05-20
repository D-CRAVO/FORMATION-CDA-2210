using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLControls;
using Microsoft.EntityFrameworkCore;

namespace CLBankTransactions.Models
{
    public class BankTransaction : Model
    {
        [Required][Column("transaction_date")]
        public DateTime TransactionDate { get; set; }

        [Required][Column("transaction_from")]
        [RegularExpression(Control.AccountNumber)]
        public Int64 TransactionFrom { get; set; }

        [Required][Column("transaction_to")]
        [RegularExpression(Control.AccountNumber)]
        public Int64 TransactionTo { get; set; }

        [Required][Column("transaction_amount")]
        [Range(0, 99000.00)]
        [Precision(7,2)]
        public decimal TransactionAmount { get; set; }
    }
}
