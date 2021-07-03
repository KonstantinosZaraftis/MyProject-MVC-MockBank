using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class Card
    {
        [ForeignKey("Customer")]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        [Display(Name="Card Number")]
        
        public string CardNumber { get; set; }
        
        public Customer Customer { get; set; }

        public int? BankAccountId { get; set; }

        public virtual  BankAccount BankAccount { get; set; }
    }
}