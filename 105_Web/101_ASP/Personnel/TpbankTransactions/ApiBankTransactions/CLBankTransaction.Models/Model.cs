using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CLBankTransaction.Models
{
    public class Model
    {
        [Key]
        [Column("transaction_id")]
        public int Id { get; set; }
    }
}