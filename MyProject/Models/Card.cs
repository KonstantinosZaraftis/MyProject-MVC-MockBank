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
        public int Id { get; set; }//auto einai foreing key ston BankAccount
        [Required]
        [StringLength(maximumLength:50)]
        [Display(Name="Card Number")]
        
        public string CardNumber { get; set; }

        public Customer Customer { get; set; }

    }
}