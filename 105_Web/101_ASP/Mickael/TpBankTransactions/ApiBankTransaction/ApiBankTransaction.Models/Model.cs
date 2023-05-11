using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBankTransaction.Models
{
    public class Model
    {
        [Key]
        [Column("transaction_id")]
        public int Id { get; set; }
    }
}
